namespace Bank
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.closeButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.PictureBox();
            this.BottomPanel = new System.Windows.Forms.PictureBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.PlusImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusImage)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1163, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1200, 100);
            this.TopPanel.TabIndex = 5;
            this.TopPanel.TabStop = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 650);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1200, 100);
            this.BottomPanel.TabIndex = 6;
            this.BottomPanel.TabStop = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LogoLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.ForeColor = System.Drawing.Color.SpringGreen;
            this.LogoLabel.Location = new System.Drawing.Point(25, 27);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(145, 42);
            this.LogoLabel.TabIndex = 7;
            this.LogoLabel.Text = "Bank13   |";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(182, 30);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 20);
            this.UserLabel.TabIndex = 8;
            // 
            // CardLabel
            // 
            this.CardLabel.AutoSize = true;
            this.CardLabel.BackColor = System.Drawing.Color.Transparent;
            this.CardLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardLabel.ForeColor = System.Drawing.Color.Black;
            this.CardLabel.Location = new System.Drawing.Point(350, 262);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(552, 33);
            this.CardLabel.TabIndex = 9;
            this.CardLabel.Text = "Your Card Number: 9090 9090 9090 9090";
            this.CardLabel.Click += new System.EventHandler(this.CardLabel_Click);
            // 
            // PlusImage
            // 
            this.PlusImage.Image = ((System.Drawing.Image)(resources.GetObject("PlusImage.Image")));
            this.PlusImage.Location = new System.Drawing.Point(567, 330);
            this.PlusImage.Name = "PlusImage";
            this.PlusImage.Size = new System.Drawing.Size(85, 85);
            this.PlusImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlusImage.TabIndex = 10;
            this.PlusImage.TabStop = false;
            this.PlusImage.Click += new System.EventHandler(this.PlusImage_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.PlusImage);
            this.Controls.Add(this.CardLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.LogoLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWin";
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox TopPanel;
        private System.Windows.Forms.PictureBox BottomPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.PictureBox PlusImage;
    }
}