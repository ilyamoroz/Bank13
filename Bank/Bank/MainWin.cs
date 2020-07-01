using System;
using System.Timers;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Threading;

namespace Bank
{
    public partial class MainWin : Form
    {
        DB db = new DB();
        private string phone;
        private string pass;
        
        public MainWin()
        {
        }
        public MainWin(string phone, string pass)
        {
            InitializeComponent();

            this.phone = phone;
            this.pass  = pass;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            timer1.Stop();
        }
        private void RefreshBalance(object sender, EventArgs e)
        {
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `PhoneNum` = @phone" +
                " AND Password = @pass", db.GetConnection());
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            MySqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                BalanceLabel.Text = "| Balance: " + reader.GetString(7) + "₿";
            }
            reader.Close();
            db.closeConnection();
        }
        private void MainWin_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(RefreshBalance);
            timer1.Interval = 5000;
            timer1.Start();

            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `PhoneNum` = @phone" +
                " AND Password = @pass", db.GetConnection());
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                UserLabel.Text = "User: " + reader.GetString(1) + ' ' + reader.GetString(2) + ' '
                   + reader.GetString(3) + "\nPhone number: +" + reader.GetString(4);

                if (reader.GetString(0) == "0")
                {
                    UserLabel.Visible = true;
                    BalanceLabel.Visible = false;
                    TransferButton.Visible = false;
                    CardLabel.Text = "Seems like you still don't have any bank card :(";
                    CardLabel.Top = (this.Height / 2) - 100;
                    CardLabel.Left = (this.Width / 2) - (CardLabel.Width / 2);
                    PlusImage.Left = (this.Width / 2) - (PlusImage.Width / 2);
                }
                else
                {
                    BalanceLabel.Visible = true;
                    TransferButton.Visible = true;
                    PlusImage.Visible = false;
                    BalanceLabel.Visible = true;
                    BalanceLabel.Left = CardLabel.Left + CardLabel.Width;
                    BalanceLabel.Top = CardLabel.Top;
                    string numb = reader.GetString(0).Insert(4, " ");
                    numb = numb.Insert(9, " ");
                    numb = numb.Insert(14, " ");
                    CardLabel.Text = "Your Card Number: " + numb;
                    BalanceLabel.Text = "| Balance: " + reader.GetString(7) + "₿";
                }
                reader.Close();
            }
            db.closeConnection();
            Refresh();
        }
        private void PlusImage_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateCardForm ccf = new CreateCardForm(phone, pass);
            ccf.Show();
        }
        private void CardLabel_Click(object sender, EventArgs e)
        {
        }
        private void TransferButton_Click(object sender, EventArgs e)
        {
            TranferMoney TM = new TranferMoney(phone, pass);
            TM.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            SavePassword SP = new SavePassword();
            SP.ClearData();
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
    }
}
