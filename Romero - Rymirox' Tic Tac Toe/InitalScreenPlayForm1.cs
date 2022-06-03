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
    public partial class InitalScreenPlayForm1 : Form
    {
        public InitalScreenPlayForm1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            String input1 = txtbx1.Text;
            MessageBox.Show(input1);

            Boolean willExecute = input1 == "X" || input1 == "O";
            if (willExecute)
            {
                //true
                txtbx1.Enabled = false;
                B1.Enabled = false;
            }
            else
            {
                //false
                txtbx1.Enabled = true;
                MessageBox.Show("Try Again");
                B1.Enabled = true;
            }
        }


        private void B2_Click(object sender, EventArgs e)
        {
            String input2 = txtbx2.Text;
            MessageBox.Show(input2);
            txtbx2.Enabled = false;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            String input3 = txtbx2.Text;
            MessageBox.Show(input3);
            txtbx3.Enabled = false;
        }
    }
}
