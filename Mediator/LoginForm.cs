using System.Security.Permissions;

namespace Mediator
{
    public partial class LoginForm : Form, IMediator
    {
        private ColleagueRadioButton _guestRadioButton;
        private ColleagueRadioButton _loginRadioButton;
        private ColleagueTextBox _userTextBox;
        private ColleagueTextBox _passTextBox;
        private ColleagueButton _okButton;
        private ColleagueButton _cancelButton;

        public LoginForm()
        {
            InitializeComponent();

            CreateColleagues();

            _guestRadioButton.Parent = this;
            _guestRadioButton.Checked = true;
            _guestRadioButton.Location = new Point(10, 10);
            _loginRadioButton.Parent = this;
            _loginRadioButton.Location = new Point(150, 10);

            Label usernameLabel = new Label();
            usernameLabel.Parent = this;
            usernameLabel.Text = "Username:";
            usernameLabel.Location = new Point(10, 40);
            _userTextBox.Parent = this;
            _userTextBox.Location = new Point(150, 37);

            Label passwordLabel = new Label();
            passwordLabel.Parent = this;
            passwordLabel.Text = "Password:";
            passwordLabel.Location = new Point(10, 70);
            _passTextBox.Parent = this;
            _passTextBox.Location = new Point(150, 67);

            _okButton.Parent = this;
            _okButton.Location = new Point(10, 95);
            _cancelButton.Parent = this;
            _cancelButton.Location = new Point(150, 95);

            ColleagueChanged();
        }

        public void CreateColleagues()
        {
            // ¶¬
            _guestRadioButton = new ColleagueRadioButton("Guest");
            _loginRadioButton = new ColleagueRadioButton("Login");
            _userTextBox = new ColleagueTextBox("");
            _passTextBox = new ColleagueTextBox("");
            _okButton = new ColleagueButton("OK");
            _cancelButton = new ColleagueButton("Cancel");

            // Mediator‚ÌƒZƒbƒg
            _guestRadioButton.SetMediator(this);
            _loginRadioButton.SetMediator(this);
            _userTextBox.SetMediator(this);
            _passTextBox.SetMediator(this);
            _okButton.SetMediator(this);
            _cancelButton.SetMediator(this);
        }

        public void ColleagueChanged()
        {
            if (_guestRadioButton.Checked)
            {
                _userTextBox.SetColleagueEnabled(false);
                _passTextBox.SetColleagueEnabled(false);
                _okButton.SetColleagueEnabled(true);
            }
            else
            {
                _userTextBox.SetColleagueEnabled(true);
                UserpassChanged();
            }
        }

        private void UserpassChanged()
        {
            if (_userTextBox.Text.Length > 0)
            {
                _passTextBox.SetColleagueEnabled(true);
                if (_passTextBox.Text.Length > 0)
                {
                    _okButton.SetColleagueEnabled(true);
                }
                else
                {
                    _okButton.SetColleagueEnabled(false);
                }
            }
            else
            {
                _passTextBox.SetColleagueEnabled(false);
                _okButton.SetColleagueEnabled(false);
            }
        }
    }
}