namespace DeltaBicycles.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassaword = new System.Windows.Forms.Label();
            this.rbLogin = new System.Windows.Forms.RadioButton();
            this.rbSingUp = new System.Windows.Forms.RadioButton();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.label1.Size = new System.Drawing.Size(341, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delta Bikes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.Location = new System.Drawing.Point(55, 360);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(225, 29);
            this.btnAction.TabIndex = 6;
            this.btnAction.Text = "Login";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(124, 141);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Exp: Franv16";
            this.txtUsername.Size = new System.Drawing.Size(192, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(124, 186);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Your password";
            this.txtPassword.Size = new System.Drawing.Size(192, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(124, 230);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.PlaceholderText = "Confirm your password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(192, 23);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // lblConfirmPassaword
            // 
            this.lblConfirmPassaword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmPassaword.AutoSize = true;
            this.lblConfirmPassaword.Location = new System.Drawing.Point(11, 233);
            this.lblConfirmPassaword.Name = "lblConfirmPassaword";
            this.lblConfirmPassaword.Size = new System.Drawing.Size(107, 15);
            this.lblConfirmPassaword.TabIndex = 9;
            this.lblConfirmPassaword.Text = "Confirm Password:";
            // 
            // rbLogin
            // 
            this.rbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbLogin.AutoSize = true;
            this.rbLogin.Checked = true;
            this.rbLogin.Location = new System.Drawing.Point(75, 301);
            this.rbLogin.Name = "rbLogin";
            this.rbLogin.Size = new System.Drawing.Size(55, 19);
            this.rbLogin.TabIndex = 4;
            this.rbLogin.TabStop = true;
            this.rbLogin.Text = "Login";
            this.rbLogin.UseVisualStyleBackColor = true;
            this.rbLogin.CheckedChanged += new System.EventHandler(this.rbLogin_CheckedChanged);
            // 
            // rbSingUp
            // 
            this.rbSingUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSingUp.AutoSize = true;
            this.rbSingUp.Location = new System.Drawing.Point(203, 301);
            this.rbSingUp.Name = "rbSingUp";
            this.rbSingUp.Size = new System.Drawing.Size(66, 19);
            this.rbSingUp.TabIndex = 5;
            this.rbSingUp.Text = "Sing Up";
            this.rbSingUp.UseVisualStyleBackColor = true;
            this.rbSingUp.CheckedChanged += new System.EventHandler(this.rbSingUp_CheckedChanged);
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(203, 258);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(113, 19);
            this.cbShowPassword.TabIndex = 3;
            this.cbShowPassword.Text = "Reveal Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.rbSingUp);
            this.Controls.Add(this.rbLogin);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassaword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAction;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassaword;
        private RadioButton rbLogin;
        private RadioButton rbSingUp;
        private CheckBox cbShowPassword;
    }
}