using DeltaBicycles.Business;
using DeltaBicycles.Data;

namespace DeltaBicycles.UI
{
    public partial class LoginForm : Form
    {
        private List<Users> listOfUsers = DeltaSequentialData.Load();

        MainForm Main = new MainForm();
        public LoginForm()
        {
            InitializeComponent();
            RefreshRb();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (rbLogin.Checked)
            {
                // .. read account and match and open
                var user = new Users(txtUsername.Text, txtPassword.Text);

                user.GotInvalidNotification += User_GotInvalidNotification;

                if (!Validator.CheckValidity(user))
                    return;

                if (listOfUsers.Exists(s => s.Username == user.Username && s.Password == user.Password))
                {
                    this.Hide();
                    Main.ShowDialog();
                    Application.Exit();
                }
                

                else 
                {
                    MessageBox.Show("The username and password given doens't match any user.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

            }

            else
            {
                // .. 

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords don't match", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var  newUser = new Users(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                newUser.GotInvalidNotification += User_GotInvalidNotification;

                if (!Validator.CheckValidity(newUser))
                    return;

                listOfUsers.Add(newUser);

                DeltaSequentialData.Save(listOfUsers);

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("User has been created, Spaces before and after the text has been eliminated", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void User_GotInvalidNotification(string message)
        {
            MessageBox.Show(message, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RefreshRb()
        {
            if (rbLogin.Checked)
            {
                btnAction.Text = "Login";
                txtConfirmPassword.Hide();
                lblConfirmPassaword.Hide();
            }

            else
            {
                btnAction.Text = "Sing Up";
                txtConfirmPassword.Show();
                lblConfirmPassaword.Show();
            }
        }

        private void rbLogin_CheckedChanged(object sender, EventArgs e)
        {
            RefreshRb();
        }

        private void rbSingUp_CheckedChanged(object sender, EventArgs e)
        {
            RefreshRb();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                char v = '\0';
                txtPassword.PasswordChar = v;
                txtConfirmPassword.PasswordChar = v;
            }

            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }
    }
}
