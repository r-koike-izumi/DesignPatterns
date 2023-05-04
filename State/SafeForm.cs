namespace State
{
    public partial class SafeForm : Form, IContext
    {
        private IState _state = DayState.Singleton;
        private int _hour = 0;

        public SafeForm()
        {
            InitializeComponent();
        }

        public void SetClock(int hour)
        {
            string clockstring = "åªç›ÇÃéûçèÇÕ";
            if (hour < 10)
            {
                clockstring += $"0{hour}:00";
            }
            else
            {
                clockstring += $"{hour}:00";
            }
            Console.WriteLine(clockstring);
            ClockLabel.Text = clockstring;
            _state.DoClock(this, hour);
        }

        public void ChangeState(IState state)
        {
            Console.WriteLine($"{_state}Ç©ÇÁ{state}Ç÷èÛë‘Ç™ïœâªÇµÇ‹ÇµÇΩÅB");
            _state = state;
        }

        public void CallSecurityCenter(string msg)
        {
            ScreenTextBox.Text += $"call! {msg}{Environment.NewLine}";
        }

        public void RecordLog(string msg)
        {
            ScreenTextBox.Text += $"record ... {msg}{Environment.NewLine}";
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            _state.DoUse(this);
        }

        private void AlarmButton_Click(object sender, EventArgs e)
        {
            _state.DoAlarm(this);
        }

        private void PhoneButton_Click(object sender, EventArgs e)
        {
            _state.DoPhone(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetClock(_hour++);
            if (_hour >= 24)
            {
                _hour = 0;
            }

        }
    }
}
