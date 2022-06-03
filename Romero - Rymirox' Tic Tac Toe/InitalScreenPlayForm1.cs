﻿using System;
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

            //for turns
            Boolean willExecute2 = input1 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input1 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
            }


        }

        private void B2_Click(object sender, EventArgs e)
        {
            String input2 = txtbx2.Text;
            MessageBox.Show(input2);

            Boolean willExecute = input2 == "X" || input2 == "O";
            if (willExecute)
            {
                //true
                txtbx2.Enabled = false;
                B2.Enabled = false;
            }
            else
            {
                //false
                txtbx2.Enabled = true;
                MessageBox.Show("Try Again");
                B2.Enabled = true;
            }
         
        }

        private void B3_Click(object sender, EventArgs e)
        {
            String input3 = txtbx3.Text;
            MessageBox.Show(input3);

            Boolean willExecute = input3 == "X" || input3 == "O";
            if (willExecute)
            {
                //true
                txtbx3.Enabled = false;
                B3.Enabled = false;
            }
            else
            {
                //false
                txtbx3.Enabled = true;
                MessageBox.Show("Try Again");
                B3.Enabled = true;


            }

        }

        private void B4_Click(object sender, EventArgs e)
        {
            String input4 = txtbx4.Text;
            MessageBox.Show(input4);

            Boolean willExecute = input4 == "X" || input4 == "O";
            if (willExecute)
            {
                //true
                txtbx4.Enabled = false;
                B4.Enabled = false;
            }
            else
            {
                //false
                txtbx4.Enabled = true;
                MessageBox.Show("Try Again");
                B4.Enabled = true;
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            String input5 = txtbx5.Text;
            MessageBox.Show(input5);

            Boolean willExecute = input5 == "X" || input5 == "O";
            if (willExecute)
            {
                //true
                txtbx5.Enabled = false;
                B5.Enabled = false;
            }
            else
            {
                //false
                txtbx5.Enabled = true;
                MessageBox.Show("Try Again");
                B5.Enabled = true;
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            String input6 = txtbx6.Text;
            MessageBox.Show(input6);

            Boolean willExecute = input6 == "X" || input6 == "O";
            if (willExecute)
            {
                //true
                txtbx6.Enabled = false;
                B6.Enabled = false;
            }
            else
            {
                //false
                txtbx6.Enabled = true;
                MessageBox.Show("Try Again");
                B6.Enabled = true;
            }

        }

        private void B7_Click(object sender, EventArgs e)
        {
            String input7 = txtbx7.Text;
            MessageBox.Show(input7);

            Boolean willExecute = input7 == "X" || input7 == "O";
            if (willExecute)
            {
                //true
                txtbx7.Enabled = false;
                B7.Enabled = false;
            }
            else
            {
                //false
                txtbx7.Enabled = true;
                MessageBox.Show("Try Again");
                B7.Enabled = true;
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            String input8 = txtbx8.Text;
            MessageBox.Show(input8);

            Boolean willExecute = input8 == "X" || input8 == "O";
            if (willExecute)
            {
                //true
                txtbx8.Enabled = false;
                B8.Enabled = false;
            }
            else
            {
                //false
                txtbx8.Enabled = true;
                MessageBox.Show("Try Again");
                B8.Enabled = true;
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            String input9 = txtbx9.Text;
            MessageBox.Show(input9);

            Boolean willExecute = input9 == "X" || input9 == "O";
            if (willExecute)
            {
                //true
                txtbx9.Enabled = false;
                B9.Enabled = false;
            }
            else
            {
                //false
                txtbx9.Enabled = true;
                MessageBox.Show("Try Again");
                B9.Enabled = true;
            }
        }

        private void results1_Click(object sender, EventArgs e)
        {
            String input1 = txtbx1.Text;
            String input2 = txtbx2.Text;
            String input3 = txtbx3.Text;    
            String input4 = txtbx4.Text;
            String input5 = txtbx5.Text;
            String input6 = txtbx6.Text;
            String input7 = txtbx7.Text;
            String input8 = txtbx8.Text; 
            String input9 = txtbx9.Text;

            //horizontalpatternforwinners
            //for input1, input2, and input 3
            if (input1 == "X" && input2 == "X" && input3 == "X")
            {
                this.Hide();
                MessageBox.Show("Player X Wins");
                ContinueOptions form2 = new ContinueOptions();
                form2.Show();
            }
            else if (input1 == "O" && input2 == "O" && input1 == "O" ) 
            {
                this.Hide();
                MessageBox.Show("Player O Wins");
                ContinueOptions form2 = new ContinueOptions();
                form2.Show();

            }
            else if (input4 == "O" && input5 == "O" && input6 == "O")
            {
                this.Hide();
                MessageBox.Show("Player O Wins");
                ContinueOptions form2 = new ContinueOptions();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Try Again");
            }

            
        }
    }
}
