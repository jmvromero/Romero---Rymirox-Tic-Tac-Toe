namespace Romero___Rymirox__Tic_Tac_Toe
{
    partial class guidelinesandfunctions1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guidelinesandfunctions1));
            this.nextbutton2 = new System.Windows.Forms.Button();
            this.labelforguidelinessentence = new System.Windows.Forms.Label();
            this.labelforguidelines = new System.Windows.Forms.Label();
            this.pictureforguidelines = new System.Windows.Forms.PictureBox();
            this.backbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureforguidelines)).BeginInit();
            this.SuspendLayout();
            // 
            // nextbutton2
            // 
            this.nextbutton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.nextbutton2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextbutton2.ForeColor = System.Drawing.Color.White;
            this.nextbutton2.Location = new System.Drawing.Point(569, 62);
            this.nextbutton2.Name = "nextbutton2";
            this.nextbutton2.Size = new System.Drawing.Size(133, 35);
            this.nextbutton2.TabIndex = 23;
            this.nextbutton2.Text = "Next";
            this.nextbutton2.UseVisualStyleBackColor = false;
            this.nextbutton2.Click += new System.EventHandler(this.nextbutton2_Click);
            // 
            // labelforguidelinessentence
            // 
            this.labelforguidelinessentence.AutoSize = true;
            this.labelforguidelinessentence.BackColor = System.Drawing.Color.Transparent;
            this.labelforguidelinessentence.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelforguidelinessentence.ForeColor = System.Drawing.Color.Pink;
            this.labelforguidelinessentence.Location = new System.Drawing.Point(31, 29);
            this.labelforguidelinessentence.Name = "labelforguidelinessentence";
            this.labelforguidelinessentence.Size = new System.Drawing.Size(311, 20);
            this.labelforguidelinessentence.TabIndex = 24;
            this.labelforguidelinessentence.Text = "Next is, the Guidelines of the game.";
            // 
            // labelforguidelines
            // 
            this.labelforguidelines.AutoSize = true;
            this.labelforguidelines.BackColor = System.Drawing.Color.Transparent;
            this.labelforguidelines.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelforguidelines.ForeColor = System.Drawing.Color.Pink;
            this.labelforguidelines.Location = new System.Drawing.Point(278, 68);
            this.labelforguidelines.Name = "labelforguidelines";
            this.labelforguidelines.Size = new System.Drawing.Size(165, 32);
            this.labelforguidelines.TabIndex = 25;
            this.labelforguidelines.Text = "Guidelines";
            // 
            // pictureforguidelines
            // 
            this.pictureforguidelines.Image = global::Romero___Rymirox__Tic_Tac_Toe.Properties.Resources.Screenshot_2022_06_04_234102;
            this.pictureforguidelines.Location = new System.Drawing.Point(50, 117);
            this.pictureforguidelines.Name = "pictureforguidelines";
            this.pictureforguidelines.Size = new System.Drawing.Size(626, 610);
            this.pictureforguidelines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureforguidelines.TabIndex = 26;
            this.pictureforguidelines.TabStop = false;
            // 
            // backbutton1
            // 
            this.backbutton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backbutton1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backbutton1.ForeColor = System.Drawing.Color.White;
            this.backbutton1.Location = new System.Drawing.Point(569, 21);
            this.backbutton1.Name = "backbutton1";
            this.backbutton1.Size = new System.Drawing.Size(133, 35);
            this.backbutton1.TabIndex = 27;
            this.backbutton1.Text = "Back";
            this.backbutton1.UseVisualStyleBackColor = false;
            this.backbutton1.Click += new System.EventHandler(this.backbutton1_Click);
            // 
            // guidelinesandfunctions1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Romero___Rymirox__Tic_Tac_Toe.Properties.Resources._1ccbae11952e748c403b5d98cdb07fab;
            this.ClientSize = new System.Drawing.Size(731, 767);
            this.Controls.Add(this.backbutton1);
            this.Controls.Add(this.pictureforguidelines);
            this.Controls.Add(this.labelforguidelines);
            this.Controls.Add(this.labelforguidelinessentence);
            this.Controls.Add(this.nextbutton2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "guidelinesandfunctions1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rymirox\' Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureforguidelines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nextbutton2;
        private Label labelforguidelinessentence;
        private Label labelforguidelines;
        private PictureBox pictureforguidelines;
        private Button skipbutton2;
        private Button backbutton1;
    }
}