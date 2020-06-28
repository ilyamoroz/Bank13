using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank
{
    public partial class TranferMoney : Form
    {
        private string phone;
        private string pass;
        public TranferMoney()
        {
            InitializeComponent();
        }
        public TranferMoney(string phone, string pass)
        {
            InitializeComponent();
            this.pass  = pass;
            this.phone = phone;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string recipient = CardNumberInp.Text;
            string amount    = AmountInp.Text;

            DB db = new DB();
            db.openConnection();

            //recipient
            MySqlCommand selectCmdRecipient = new MySqlCommand("SELECT * FROM `users` WHERE `CardNum` = @card", db.GetConnection());
            selectCmdRecipient.Parameters.Add("@card", MySqlDbType.VarChar).Value = recipient;
            selectCmdRecipient.ExecuteNonQuery();

            MySqlDataReader readerRecipient = selectCmdRecipient.ExecuteReader();
            string balance = "";

            if (readerRecipient.Read())
            {
                balance = readerRecipient.GetString(7);
                balance = (Convert.ToInt16(balance) + Convert.ToInt16(amount)).ToString();
                db.closeConnection();

                db.openConnection();
                MySqlCommand updateCmdRecipient = new MySqlCommand("UPDATE `users` SET `Balance` = @bal" +
                    " WHERE `CardNum` = @card", db.GetConnection());
                updateCmdRecipient.Parameters.Add("@card", MySqlDbType.VarChar).Value = recipient;
                updateCmdRecipient.Parameters.Add("@bal", MySqlDbType.Int16).Value = balance;
                updateCmdRecipient.ExecuteNonQuery();
                db.closeConnection();
            }
            //end recipient

            //sender
            balance = "";
            string PIN = "";
            db.openConnection();
            MySqlCommand selectCmdSender = new MySqlCommand("SELECT `Balance`, `PIN` FROM `users`"+
                " WHERE `PhoneNum` = @phone AND `Password` = @pass", db.GetConnection());
            selectCmdSender.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            selectCmdSender.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
            selectCmdSender.ExecuteNonQuery();
            MySqlDataReader readerSender = selectCmdSender.ExecuteReader();

            if(readerSender.Read())
            {
                balance = readerSender.GetString(0);
                PIN = readerSender.GetString(1);
                if (PIN == pinInp.Text)
                {
                    balance = (Convert.ToInt16(balance) - Convert.ToInt16(amount)).ToString();
                    db.closeConnection();

                    db.openConnection();
                    MySqlCommand updateCmdSender = new MySqlCommand("UPDATE `users` SET `Balance` = @bal" +
                        " WHERE `PhoneNum` = @phone AND `Password` = @pass", db.GetConnection());
                    updateCmdSender.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                    updateCmdSender.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
                    updateCmdSender.Parameters.Add("@bal", MySqlDbType.VarChar).Value = balance;
                    updateCmdSender.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Your PIN doesn't match to a registered!");
                db.closeConnection();
            }
            //end sender
            this.Close();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
