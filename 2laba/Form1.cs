namespace _2laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void func_for_first()
        {
            int a = 123 * 123;
            MessageBox.Show(a.ToString());
        }
        void func_for_second()
        {
            double b = 20 / 3.0;
            MessageBox.Show(b.ToString());
        }
        void func_for_third()
        {
            string c = Environment.UserName;
            MessageBox.Show(c.ToString());
        }
        void func_for_fourth()
        {
            string d = Environment.OSVersion.ToString();
            MessageBox.Show(d.ToString());
        }

        void func_for_firth()
        {
            Environment.Exit(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(func_for_first);
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(func_for_second);
            t.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(func_for_third);
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(func_for_fourth);
            t.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(func_for_firth);
            t.Start();
        }
    }
}