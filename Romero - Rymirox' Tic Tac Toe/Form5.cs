using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Romero___Rymirox__Tic_Tac_Toe
{
    public partial class continueoptions2 : Form
    {
        public continueoptions2()
        {
            InitializeComponent();
        }

        private void playnowbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InitalScreenPlayForm1 initalScreenPlayForm1 = new InitalScreenPlayForm1();
            initalScreenPlayForm1.Show();
        }

        private void instructions2_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructionscreen1 instructionscreen1 = new instructionscreen1();
            instructionscreen1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();   
        }
    }
}
