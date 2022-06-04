namespace Romero___Rymirox__Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            continueoptions2 continueoptions2 = new continueoptions2();
            continueoptions2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructionscreen1 instructionscreen1 = new instructionscreen1();
            instructionscreen1.Show();
        }
    }
}