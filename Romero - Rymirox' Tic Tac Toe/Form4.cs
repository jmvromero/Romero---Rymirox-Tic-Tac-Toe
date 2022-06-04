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
    public partial class guidelinesandfunctions1 : Form
    {
        public guidelinesandfunctions1()
        {
            InitializeComponent();
        }

        private void nextbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();   
        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructionscreen1 instructionscreen1 = new instructionscreen1();
            instructionscreen1.Show();
            
        }
    }
}
