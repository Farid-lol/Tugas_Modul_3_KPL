namespace Tugas_Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            textStatus.Text = "Jawaban Benar";
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            textStatus.Text = "Jawaban salah";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textStatus.Text = "Jawaban salah";
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            textStatus.Text = "Jawaban salah";
        }

        private void textStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
