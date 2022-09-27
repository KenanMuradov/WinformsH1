using BakuAndLondon.Properties;

namespace BakuAndLondon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(this, new EventArgs());
        }
        bool state = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += (s, e) => timeLabel.Text = state ? DateTime.Now.ToLongTimeString() : DateTime.UtcNow.ToLongTimeString();
        }

        private void cityChangeButton_Click(object sender, EventArgs e)
        {
            state = !state;
            BackgroundImage = state ? Resources.Baku : Resources.London;
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}