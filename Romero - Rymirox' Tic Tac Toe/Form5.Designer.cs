namespace Romero___Rymirox__Tic_Tac_Toe
{
    partial class continueoptions2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(continueoptions2));
            this.labelforcontinueoptions1 = new System.Windows.Forms.Label();
            this.playnowbutton2 = new System.Windows.Forms.Button();
            this.instructions2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelforcontinueoptions1
            // 
            this.labelforcontinueoptions1.AutoSize = true;
            this.labelforcontinueoptions1.BackColor = System.Drawing.Color.Transparent;
            this.labelforcontinueoptions1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelforcontinueoptions1.ForeColor = System.Drawing.Color.Pink;
            this.labelforcontinueoptions1.Location = new System.Drawing.Point(43, 30);
            this.labelforcontinueoptions1.Name = "labelforcontinueoptions1";
            this.labelforcontinueoptions1.Size = new System.Drawing.Size(249, 24);
            this.labelforcontinueoptions1.TabIndex = 1;
            this.labelforcontinueoptions1.Text = "Do you want to proceed?";
            // 
            // playnowbutton2
            // 
            this.playnowbutton2.BackColor = System.Drawing.Color.Pink;
            this.playnowbutton2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playnowbutton2.Location = new System.Drawing.Point(110, 72);
            this.playnowbutton2.Name = "playnowbutton2";
            this.playnowbutton2.Size = new System.Drawing.Size(111, 37);
            this.playnowbutton2.TabIndex = 2;
            this.playnowbutton2.Text = "Play Now!";
            this.playnowbutton2.UseVisualStyleBackColor = false;
            this.playnowbutton2.Click += new System.EventHandler(this.playnowbutton2_Click);
            // 
            // instructions2
            // 
            this.instructions2.BackColor = System.Drawing.Color.Pink;
            this.instructions2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.instructions2.Location = new System.Drawing.Point(110, 115);
            this.instructions2.Name = "instructions2";
            this.instructions2.Size = new System.Drawing.Size(111, 37);
            this.instructions2.TabIndex = 3;
            this.instructions2.Text = "Instructions ";
            this.instructions2.UseVisualStyleBackColor = false;
            this.instructions2.Click += new System.EventHandler(this.instructions2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(110, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "No";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // continueoptions2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Romero___Rymirox__Tic_Tac_Toe.Properties.Resources._1ccbae11952e748c403b5d98cdb07fab;
            this.ClientSize = new System.Drawing.Size(324, 220);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.instructions2);
            this.Controls.Add(this.playnowbutton2);
            this.Controls.Add(this.labelforcontinueoptions1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "continueoptions2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rymirox\' Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelforcontinueoptions1;
        private Button playnowbutton2;
        private Button instructions2;
        private Button button3;
    }
}