namespace Bank
{
    partial class RegistrationForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.FirstNameInp = new System.Windows.Forms.TextBox();
            this.SecondNameInp = new System.Windows.Forms.TextBox();
            this.FathersNameInp = new System.Windows.Forms.TextBox();
            this.PhoneNumInp = new System.Windows.Forms.TextBox();
            this.PassInp = new System.Windows.Forms.TextBox();
            this.PassInpRepeat = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.FathersNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.PassLabel0 = new System.Windows.Forms.Label();
            this.PassLabel1 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.BackToLogButton = new System.Windows.Forms.Button();
            this.VisiblePass = new System.Windows.Forms.CheckBox();
            this.VisiblePass1 = new System.Windows.Forms.CheckBox();
            this.PassStatus = new System.Windows.Forms.PictureBox();
            this.PassRepStatus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PassStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassRepStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(463, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FirstNameInp
            // 
            this.FirstNameInp.Location = new System.Drawing.Point(190, 113);
            this.FirstNameInp.Name = "FirstNameInp";
            this.FirstNameInp.Size = new System.Drawing.Size(149, 20);
            this.FirstNameInp.TabIndex = 5;
            this.FirstNameInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameInp_KeyPress);
            // 
            // SecondNameInp
            // 
            this.SecondNameInp.Location = new System.Drawing.Point(190, 150);
            this.SecondNameInp.Name = "SecondNameInp";
            this.SecondNameInp.Size = new System.Drawing.Size(149, 20);
            this.SecondNameInp.TabIndex = 6;
            this.SecondNameInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondNameInp_KeyPress);
            // 
            // FathersNameInp
            // 
            this.FathersNameInp.Location = new System.Drawing.Point(190, 187);
            this.FathersNameInp.Name = "FathersNameInp";
            this.FathersNameInp.Size = new System.Drawing.Size(149, 20);
            this.FathersNameInp.TabIndex = 7;
            this.FathersNameInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FathersNameInp_KeyPress);
            // 
            // PhoneNumInp
            // 
            this.PhoneNumInp.Location = new System.Drawing.Point(190, 258);
            this.PhoneNumInp.Name = "PhoneNumInp";
            this.PhoneNumInp.Size = new System.Drawing.Size(149, 20);
            this.PhoneNumInp.TabIndex = 8;
            this.PhoneNumInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumInp_KeyPress);
            // 
            // PassInp
            // 
            this.PassInp.Location = new System.Drawing.Point(190, 295);
            this.PassInp.Name = "PassInp";
            this.PassInp.Size = new System.Drawing.Size(149, 20);
            this.PassInp.TabIndex = 9;
            this.PassInp.UseSystemPasswordChar = true;
            this.PassInp.TextChanged += new System.EventHandler(this.PassInp_TextChanged);
            this.PassInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassInp_KeyPress);
            // 
            // PassInpRepeat
            // 
            this.PassInpRepeat.Location = new System.Drawing.Point(190, 331);
            this.PassInpRepeat.Name = "PassInpRepeat";
            this.PassInpRepeat.Size = new System.Drawing.Size(149, 20);
            this.PassInpRepeat.TabIndex = 10;
            this.PassInpRepeat.UseSystemPasswordChar = true;
            this.PassInpRepeat.TextChanged += new System.EventHandler(this.PassInpRepeat_TextChanged);
            this.PassInpRepeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassInpRepeat_KeyPress);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(119, 113);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 11;
            this.FirstNameLabel.Text = "First Name";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(109, 150);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(75, 13);
            this.SecondNameLabel.TabIndex = 12;
            this.SecondNameLabel.Text = "Second Name";
            // 
            // FathersNameLabel
            // 
            this.FathersNameLabel.AutoSize = true;
            this.FathersNameLabel.Location = new System.Drawing.Point(109, 187);
            this.FathersNameLabel.Name = "FathersNameLabel";
            this.FathersNameLabel.Size = new System.Drawing.Size(75, 13);
            this.FathersNameLabel.TabIndex = 13;
            this.FathersNameLabel.Text = "Father\'s Name";
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Location = new System.Drawing.Point(96, 261);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(93, 13);
            this.PhoneNumLabel.TabIndex = 14;
            this.PhoneNumLabel.Text = "Phone Number   +";
            // 
            // PassLabel0
            // 
            this.PassLabel0.AutoSize = true;
            this.PassLabel0.Location = new System.Drawing.Point(87, 295);
            this.PassLabel0.Name = "PassLabel0";
            this.PassLabel0.Size = new System.Drawing.Size(100, 13);
            this.PassLabel0.TabIndex = 15;
            this.PassLabel0.Text = "Password (A-Z, 0-9)";
            // 
            // PassLabel1
            // 
            this.PassLabel1.AutoSize = true;
            this.PassLabel1.Location = new System.Drawing.Point(96, 331);
            this.PassLabel1.Name = "PassLabel1";
            this.PassLabel1.Size = new System.Drawing.Size(91, 13);
            this.PassLabel1.TabIndex = 16;
            this.PassLabel1.Text = "Repeat Password";
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(205, 371);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(104, 34);
            this.RegButton.TabIndex = 17;
            this.RegButton.Text = "Sign Up";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // BackToLogButton
            // 
            this.BackToLogButton.Location = new System.Drawing.Point(12, 12);
            this.BackToLogButton.Name = "BackToLogButton";
            this.BackToLogButton.Size = new System.Drawing.Size(107, 25);
            this.BackToLogButton.TabIndex = 18;
            this.BackToLogButton.Text = "Back To login Form";
            this.BackToLogButton.UseVisualStyleBackColor = true;
            this.BackToLogButton.Click += new System.EventHandler(this.BackToLogButton_Click);
            // 
            // VisiblePass
            // 
            this.VisiblePass.AutoSize = true;
            this.VisiblePass.Location = new System.Drawing.Point(345, 295);
            this.VisiblePass.Name = "VisiblePass";
            this.VisiblePass.Size = new System.Drawing.Size(56, 17);
            this.VisiblePass.TabIndex = 19;
            this.VisiblePass.Text = "Visible";
            this.VisiblePass.UseVisualStyleBackColor = true;
            this.VisiblePass.CheckedChanged += new System.EventHandler(this.VisiblePass_CheckedChanged);
            // 
            // VisiblePass1
            // 
            this.VisiblePass1.AutoSize = true;
            this.VisiblePass1.Location = new System.Drawing.Point(345, 331);
            this.VisiblePass1.Name = "VisiblePass1";
            this.VisiblePass1.Size = new System.Drawing.Size(56, 17);
            this.VisiblePass1.TabIndex = 20;
            this.VisiblePass1.Text = "Visible";
            this.VisiblePass1.UseVisualStyleBackColor = true;
            this.VisiblePass1.CheckedChanged += new System.EventHandler(this.VisiblePass1_CheckedChanged);
            // 
            // PassStatus
            // 
            this.PassStatus.BackColor = System.Drawing.Color.Transparent;
            this.PassStatus.Location = new System.Drawing.Point(190, 315);
            this.PassStatus.Name = "PassStatus";
            this.PassStatus.Size = new System.Drawing.Size(149, 3);
            this.PassStatus.TabIndex = 21;
            this.PassStatus.TabStop = false;
            // 
            // PassRepStatus
            // 
            this.PassRepStatus.BackColor = System.Drawing.Color.Transparent;
            this.PassRepStatus.Location = new System.Drawing.Point(190, 351);
            this.PassRepStatus.Name = "PassRepStatus";
            this.PassRepStatus.Size = new System.Drawing.Size(149, 3);
            this.PassRepStatus.TabIndex = 22;
            this.PassRepStatus.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(178, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Registration Form";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassRepStatus);
            this.Controls.Add(this.PassStatus);
            this.Controls.Add(this.VisiblePass1);
            this.Controls.Add(this.VisiblePass);
            this.Controls.Add(this.BackToLogButton);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.PassLabel1);
            this.Controls.Add(this.PassLabel0);
            this.Controls.Add(this.PhoneNumLabel);
            this.Controls.Add(this.FathersNameLabel);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PassInpRepeat);
            this.Controls.Add(this.PassInp);
            this.Controls.Add(this.PhoneNumInp);
            this.Controls.Add(this.FathersNameInp);
            this.Controls.Add(this.SecondNameInp);
            this.Controls.Add(this.FirstNameInp);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.PassStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassRepStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox FirstNameInp;
        private System.Windows.Forms.TextBox SecondNameInp;
        private System.Windows.Forms.TextBox FathersNameInp;
        private System.Windows.Forms.TextBox PhoneNumInp;
        private System.Windows.Forms.TextBox PassInp;
        private System.Windows.Forms.TextBox PassInpRepeat;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label FathersNameLabel;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.Label PassLabel0;
        private System.Windows.Forms.Label PassLabel1;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button BackToLogButton;
        private System.Windows.Forms.CheckBox VisiblePass;
        private System.Windows.Forms.CheckBox VisiblePass1;
        private System.Windows.Forms.PictureBox PassStatus;
        private System.Windows.Forms.PictureBox PassRepStatus;
        private System.Windows.Forms.Label label1;
    }
}