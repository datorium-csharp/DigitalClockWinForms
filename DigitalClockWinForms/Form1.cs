namespace DigitalClockWinForms
{
    public partial class Clock : Form       
    {
        int deciSecond = 0;
        int second = 0;
        int minute = 0;
        int hour = 0;

        public Clock()
        {
            InitializeComponent();
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            deciSecond += 1;
            if(deciSecond == 10)
            {
                deciSecond = 0;
                second += 1;
            }           
            if(second == 60)
            {
                second = 0;
                minute += 1;
            }
            if(minute == 60)
            {
                minute = 0;
                hour += 1;
            }

            string clockText;
            clockText = hour.ToString("00") + ":";
            clockText += minute.ToString("00") + ":";
            clockText += second.ToString("00") + ":";
            clockText += deciSecond.ToString("0");

            Display.Text = clockText;

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            TimerClock.Start();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {          
            TimerClock.Stop();
        }
    }
}