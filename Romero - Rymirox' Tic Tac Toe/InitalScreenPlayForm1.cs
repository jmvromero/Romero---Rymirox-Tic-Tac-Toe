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

            //for turns
            Boolean willExecute2 = input2 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input2 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
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

            //for turns
            Boolean willExecute2 = input3 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input3 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
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

            //for turns
            Boolean willExecute2 = input4 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input4 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
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

            //for turns
            Boolean willExecute2 = input5 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input5 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
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

            //for turns
            Boolean willExecute2 = input6 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input6 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
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

            //for turns
            Boolean willExecute2 = input7 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input7 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
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

            //for turns
            Boolean willExecute2 = input8 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input8 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
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

            //for turns
            Boolean willExecute2 = input9 == "X";
            if (willExecute2)
            {
                //true
                MessageBox.Show("Player O Turn");
            }

            Boolean willExecute3 = input9 == "O";
            if (willExecute3)
            {
                //true
                MessageBox.Show("Player X Turn");
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
            Boolean draw1 = (input1 != input2 || input3 != input2) && (input4 != input5 || input6 != input5) && (input7 != input8 || input9 != input8) && (input1 != input4 || input7 != input4) && (input2 != input5 || input8 != input5) && (input3 != input6 || input9 != input6) && (input1 != input5 || input9 != input5) && (input3 != input5 || input7 != input5);

            //draw
            if (draw1)
            {
                MessageBox.Show("Draw");
                MessageBox.Show("Play Again");
            }

                //patternsforwinning
                Boolean willExecuteproperly = true;
                if (willExecuteproperly)
                {
                    //horizontalpatternforwinners
                    //for input1, input2, and input3
                    bool h1 = input1 == input2 && input3 == input2;
                    Boolean willExecute = h1;
                    if (willExecute)
                    {
                        if (input1 == "X" && input2 == "X" && input3 == "X")
                        {
                            this.Hide();
                            MessageBox.Show("Player X Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                        else if (input1 == "O" && input2 == "O" && input3 == "O")
                        {
                            this.Hide();
                            MessageBox.Show("Player O Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                    }

                    //for input4, input5, and input6
                    bool h2 = input4 == input5 && input6 == input5;
                    Boolean willExecute2 = h2;
                    if (willExecute2)
                    {
                        if (input4 == "X" && input5 == "X" && input6 == "X")
                        {
                            this.Hide();
                            MessageBox.Show("Player X Wins");
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
                    }

                    //for input7, input8, and input9
                    bool h3 = input7 == input8 && input9 == input8;
                    Boolean willExecute3 = h3;
                    if (willExecute3)
                    {
                        if (input7 == "X" && input8 == "X" && input9 == "X")
                        {
                            this.Hide();
                            MessageBox.Show("Player X Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                        else if (input7 == "O" && input8 == "O" && input9 == "O")
                        {
                            this.Hide();
                            MessageBox.Show("Player O Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                    }

                    //verticalpatternsforwinners
                    //for input1, input4, and input7
                    bool h4 = input1 == input4 && input7 == input4;
                    Boolean willExecute4 = h4;
                    if (willExecute4)
                        if (input1 == "X" && input4 == "X" && input7 == "X")
                        {
                            this.Hide();
                            MessageBox.Show("Player X Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                        else if (input1 == "O" && input4 == "O" && input7 == "O")
                        {
                            this.Hide();
                            MessageBox.Show("Player O Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }

                    //for input2, input5, and input8
                    bool h5 = input2 == input5 && input8 == input5;
                    Boolean willExecute5 = h5;
                    if (willExecute5)
                        if (input2 == "X" && input5 == "X" && input8 == "X")
                        {
                            this.Hide();
                            MessageBox.Show("Player X Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                        else if (input2 == "O" && input5 == "O" && input8 == "O")
                        {
                            this.Hide();
                            MessageBox.Show("Player O Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }

                    //for input3, input6, and input9
                    bool h6 = input3 == input6 && input9 == input6;
                    Boolean willExecute6 = h6;
                    if (willExecute6)
                        if (input3 == "X" && input6 == "X" && input9 == "X")
                        {
                            this.Hide();
                            MessageBox.Show("Player X Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                        else if (input3 == "O" && input6 == "O" && input9 == "O")
                        {
                            this.Hide();
                            MessageBox.Show("Player O Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }

                    //fordiagonal
                    //for input1, input5, and input9
                    bool h7 = input1 == input5 && input9 == input5;
                    Boolean willExecute7 = h7;
                    if (willExecute7)
                        if (input1 == "X" && input5 == "X" && input9 == "X")
                        {
                            this.Hide();
                            MessageBox.Show("Player X Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                        else if (input1 == "O" && input5 == "O" && input9 == "O")
                        {
                            this.Hide();
                            MessageBox.Show("Player O Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }

                    //for input3, input5, and input7
                    bool h8 = input3 == input5 && input7 == input5;
                    Boolean willExecute8 = h8;
                    if (willExecute8)
                        if (input3 == "X" && input5 == "X" && input7 == "X")
                        {
                            this.Hide();
                            MessageBox.Show("Player X Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }
                        else if (input3 == "O" && input5 == "O" && input7 == "O")
                        {
                            this.Hide();
                            MessageBox.Show("Player O Wins");
                            ContinueOptions form2 = new ContinueOptions();
                            form2.Show();
                        }


                }

            }

        private void restart1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContinueOptions form2 = new ContinueOptions();
            form2.Show();
        }

        private void mainmenu1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    }