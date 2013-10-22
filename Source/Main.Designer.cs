namespace ImageEffectswithGUI
{
    partial class Main
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
            this.ButtonGreyscale = new System.Windows.Forms.Button();
            this.ButtonBlackandWhite = new System.Windows.Forms.Button();
            this.ButtonHistogram = new System.Windows.Forms.Button();
            this.Button3x3 = new System.Windows.Forms.Button();
            this.Button11x11 = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirectImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGreyscale
            // 
            this.ButtonGreyscale.Location = new System.Drawing.Point(12, 485);
            this.ButtonGreyscale.Name = "ButtonGreyscale";
            this.ButtonGreyscale.Size = new System.Drawing.Size(75, 23);
            this.ButtonGreyscale.TabIndex = 0;
            this.ButtonGreyscale.Text = "Greyscale";
            this.ButtonGreyscale.UseVisualStyleBackColor = true;
            this.ButtonGreyscale.Click += new System.EventHandler(this.ButtonGreyscale_Click);
            // 
            // ButtonBlackandWhite
            // 
            this.ButtonBlackandWhite.Location = new System.Drawing.Point(119, 485);
            this.ButtonBlackandWhite.Name = "ButtonBlackandWhite";
            this.ButtonBlackandWhite.Size = new System.Drawing.Size(75, 23);
            this.ButtonBlackandWhite.TabIndex = 0;
            this.ButtonBlackandWhite.Text = "B/W";
            this.ButtonBlackandWhite.UseVisualStyleBackColor = true;
            this.ButtonBlackandWhite.Click += new System.EventHandler(this.ButtonBlackandWhite_Click);
            // 
            // ButtonHistogram
            // 
            this.ButtonHistogram.Location = new System.Drawing.Point(224, 485);
            this.ButtonHistogram.Name = "ButtonHistogram";
            this.ButtonHistogram.Size = new System.Drawing.Size(75, 23);
            this.ButtonHistogram.TabIndex = 0;
            this.ButtonHistogram.Text = "Histogram ";
            this.ButtonHistogram.UseVisualStyleBackColor = true;
            this.ButtonHistogram.Click += new System.EventHandler(this.ButtonHistogram_Click);
            // 
            // Button3x3
            // 
            this.Button3x3.Location = new System.Drawing.Point(324, 485);
            this.Button3x3.Name = "Button3x3";
            this.Button3x3.Size = new System.Drawing.Size(75, 23);
            this.Button3x3.TabIndex = 0;
            this.Button3x3.Text = "3x3";
            this.Button3x3.UseVisualStyleBackColor = true;
            // 
            // Button11x11
            // 
            this.Button11x11.Location = new System.Drawing.Point(424, 485);
            this.Button11x11.Name = "Button11x11";
            this.Button11x11.Size = new System.Drawing.Size(75, 23);
            this.Button11x11.TabIndex = 0;
            this.Button11x11.Text = "11x11";
            this.Button11x11.UseVisualStyleBackColor = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(512, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "MainMenuStrip";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.ladenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // DirectImage
            // 
            this.DirectImage.Location = new System.Drawing.Point(12, 54);
            this.DirectImage.Name = "DirectImage";
            this.DirectImage.Size = new System.Drawing.Size(487, 425);
            this.DirectImage.TabIndex = 2;
            this.DirectImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 520);
            this.Controls.Add(this.DirectImage);
            this.Controls.Add(this.Button11x11);
            this.Controls.Add(this.Button3x3);
            this.Controls.Add(this.ButtonHistogram);
            this.Controls.Add(this.ButtonBlackandWhite);
            this.Controls.Add(this.ButtonGreyscale);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Main";
            this.Text = "ImageEffects";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DirectImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonGreyscale;
        private System.Windows.Forms.Button ButtonBlackandWhite;
        private System.Windows.Forms.Button ButtonHistogram;
        private System.Windows.Forms.Button Button3x3;
        private System.Windows.Forms.Button Button11x11;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.PictureBox DirectImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

