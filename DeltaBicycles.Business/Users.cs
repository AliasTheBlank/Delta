using DeltaBicycles.Business.Delegates;
using DeltaBicycles.Business.Interface;

namespace DeltaBicycles.Business
{
    public class Users : IValidatable
    {
        private string _username;
        private string _password;
        private string _invalidMessage;

        public event Notify GotInvalidNotification;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string InvalidMessage
        {
            get => _invalidMessage;
            set => _invalidMessage = value;
        }

        public Users(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public Users()
        {
            _username = "";
            _password = "";
        }

        public bool IsValid()
        {
            if (_username == "")
            {
                CallGotInvalidNotification("Please inform a name");
                return false;
            }
            else if (_password == "")
            {
                CallGotInvalidNotification("Please inform a password");
                return false;
            }
            return true;
        }

        private void CallGotInvalidNotification(string Message)
        {
            _invalidMessage = Message;
            GotInvalidNotification(Message);
        }
    }
}
