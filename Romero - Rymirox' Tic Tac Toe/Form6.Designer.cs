namespace Romero___Rymirox__Tic_Tac_Toe
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.labelforFOBsentence = new System.Windows.Forms.Label();
            this.labelforFOB = new System.Windows.Forms.Label();
            this.pictureforFOB = new System.Windows.Forms.PictureBox();
            this.playnowbutton1 = new System.Windows.Forms.Button();
            this.backbutton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureforFOB)).BeginInit();
            this.SuspendLayout();
            // 
            // labelforFOBsentence
            // 
            this.labelforFOBsentence.AutoSize = true;
            this.labelforFOBsentence.BackColor = System.Drawing.Color.Transparent;
            this.labelforFOBsentence.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelforFOBsentence.ForeColor = System.Drawing.Color.Pink;
            this.labelforFOBsentence.Location = new System.Drawing.Point(31, 29);
            this.labelforFOBsentence.Name = "labelforFOBsentence";
            this.labelforFOBsentence.Size = new System.Drawing.Size(391, 20);
            this.labelforFOBsentence.TabIndex = 25;
            this.labelforFOBsentence.Text = "And last is, the Functions of Buttons in game.";
            // 
            // labelforFOB
            // 
            this.labelforFOB.AutoSize = true;
            this.labelforFOB.BackColor = System.Drawing.Color.Transparent;
            this.labelforFOB.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelforFOB.ForeColor = System.Drawing.Color.Pink;
            this.labelforFOB.Location = new System.Drawing.Point(213, 71);
            this.labelforFOB.Name = "labelforFOB";
            this.labelforFOB.Size = new System.Drawing.Size(302, 32);
            this.labelforFOB.TabIndex = 26;
            this.labelforFOB.Text = "Function of Buttons";
            // 
            // pictureforFOB
            // 
            this.pictureforFOB.Image = global::Romero___Rymirox__Tic_Tac_Toe.Properties.Resources.Screenshot_2022_06_04_234255;
            this.pictureforFOB.Location = new System.Drawing.Point(50, 120);
            this.pictureforFOB.Name = "pictureforFOB";
            this.pictureforFOB.Size = new System.Drawing.Size(626, 610);
            this.pictureforFOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureforFOB.TabIndex = 27;
            this.pictureforFOB.TabStop = false;
            // 
            // playnowbutton1
            // 
            this.playnowbutton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.playnowbutton1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playnowbutton1.ForeColor = System.Drawing.Color.White;
            this.playnowbutton1.Location = new System.Drawing.Point(569, 62);
            this.playnowbutton1.Name = "playnowbutton1";
            this.playnowbutton1.Size = new System.Drawing.Size(133, 35);
            this.playnowbutton1.TabIndex = 28;
            this.playnowbutton1.Text = "Play Now!";
            this.playnowbutton1.UseVisualStyleBackColor = false;
            this.playnowbutton1.Click += new System.EventHandler(this.playnowbutton1_Click);
            // 
            // backbutton2
            // 
            this.backbutton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backbutton2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbutton2.ForeColor = System.Drawing.Color.White;
            this.backbutton2.Location = new System.Drawing.Point(569, 21);
            this.backbutton2.Name = "backbutton2";
            this.backbutton2.Size = new System.Drawing.Size(133, 35);
            this.backbutton2.TabIndex = 29;
            this.backbutton2.Text = "Back";
            this.backbutton2.UseVisualStyleBackColor = false;
            this.backbutton2.Click += new System.EventHandler(this.backbutton2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Romero___Rymirox__Tic_Tac_Toe.Properties.Resources._1ccbae11952e748c403b5d98cdb07fab;
            this.ClientSize = new System.Drawing.Size(731, 767);
            this.Controls.Add(this.backbutton2);
            this.Controls.Add(this.playnowbutton1);
            this.Controls.Add(this.pictureforFOB);
            this.Controls.Add(this.labelforFOB);
            this.Controls.Add(this.labelforFOBsentence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rymirox\' Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureforFOB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelforFOBsentence;
        private Label labelforFOB;
        private PictureBox pictureforFOB;
        private Button playnowbutton1;
        private Button backbutton2;
    }
}