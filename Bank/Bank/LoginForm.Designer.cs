namespace Bank
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PhoneInp = new System.Windows.Forms.TextBox();
            this.PassInp = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAccLabel = new System.Windows.Forms.LinkLabel();
            this.VisiblePass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // PhoneInp
            // 
            this.PhoneInp.Location = new System.Drawing.Point(154, 150);
            this.PhoneInp.Name = "PhoneInp";
            this.PhoneInp.Size = new System.Drawing.Size(150, 20);
            this.PhoneInp.TabIndex = 0;
            this.PhoneInp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneInp_KeyPress);
            // 
            // PassInp
            // 
            this.PassInp.Location = new System.Drawing.Point(154, 205);
            this.PassInp.Name = "PassInp";
            this.PassInp.Size = new System.Drawing.Size(150, 20);
            this.PassInp.TabIndex = 1;
            this.PassInp.UseSystemPasswordChar = true;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(145, 255);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(104, 39);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Login";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click_1);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(363, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Location = new System.Drawing.Point(60, 153);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(94, 13);
            this.phoneNumLabel.TabIndex = 4;
            this.phoneNumLabel.Text = "Phone number    +";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(83, 208);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(53, 13);
            this.PassLabel.TabIndex = 5;
            this.PassLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login Form";
            // 
            // CreateAccLabel
            // 
            this.CreateAccLabel.AutoSize = true;
            this.CreateAccLabel.Location = new System.Drawing.Point(154, 317);
            this.CreateAccLabel.Name = "CreateAccLabel";
            this.CreateAccLabel.Size = new System.Drawing.Size(95, 13);
            this.CreateAccLabel.TabIndex = 7;
            this.CreateAccLabel.TabStop = true;
            this.CreateAccLabel.Text = "Create an account";
            this.CreateAccLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // VisiblePass
            // 
            this.VisiblePass.AutoSize = true;
            this.VisiblePass.Location = new System.Drawing.Point(310, 205);
            this.VisiblePass.Name = "VisiblePass";
            this.VisiblePass.Size = new System.Drawing.Size(56, 17);
            this.VisiblePass.TabIndex = 8;
            this.VisiblePass.Text = "Visible";
            this.VisiblePass.UseVisualStyleBackColor = true;
            this.VisiblePass.CheckedChanged += new System.EventHandler(this.VisiblePass_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.VisiblePass);
            this.Controls.Add(this.CreateAccLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.PassInp);
            this.Controls.Add(this.PhoneInp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneInp;
        private System.Windows.Forms.TextBox PassInp;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel CreateAccLabel;
        private System.Windows.Forms.CheckBox VisiblePass;
    }
}

