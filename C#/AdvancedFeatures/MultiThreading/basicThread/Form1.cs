namespace basicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread thread = null;
        private void buttonCounter_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(counter));
            thread.Start();
            thread.Join();
            MessageBox.Show("Bitti");
        }

        private void counter()
        {
            for (int i = 0; i < 10000; i++)
            {
                labelCounter.Text = i.ToString();
                progressBar2.Value = i / 100;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("show");
        }
    }
}