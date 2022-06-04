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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void playnowbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InitalScreenPlayForm1 initalScreenPlayForm1 = new InitalScreenPlayForm1();
            initalScreenPlayForm1.Show();
        }

        private void backbutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            guidelinesandfunctions1 guidelinesandfunctions1 = new guidelinesandfunctions1();
            guidelinesandfunctions1.Show();
        }
    }
}
