namespace Inlamning2WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.ShowDialog();
        }
    }
}