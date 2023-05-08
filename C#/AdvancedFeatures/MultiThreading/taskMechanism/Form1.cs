namespace taskMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void buttonCounter_Click(object sender, EventArgs e)
        {
            Task.Run(counter);
            MessageBox.Show("bitti");
        }

        async Task counter()
        {
            for (int i = 0; i < 10000; i++)
            {
                labelCounter.Text = i.ToString();
                progressBar2.Value = i / 100;
            }

            //return Task.CompletedTask;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naptın?");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Parallel.
        }
    }
}