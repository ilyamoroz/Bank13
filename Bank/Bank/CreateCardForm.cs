using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class CreateCardForm : Form
    {
        private string phone;
        private string pass;
        public CreateCardForm(string phone, string pass)
        {
            this.phone = phone;
            this.pass = pass;
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string CardNumGenenerate(string type)
        {
            string res = "";

            var Rand = new Random();

            for (int counter = 0; counter < 4; counter++)
            {
                int cardNumberPart = 0;
                
                if (counter == 0)
                { 
                    if (type == "MasterCard")
                        cardNumberPart = Rand.Next(5000, 5999);
                    else
                        cardNumberPart = Rand.Next(4000, 4999);
                    res += Convert.ToString(cardNumberPart);
                }
                else
                {
                    cardNumberPart = Rand.Next(1000, 9999);
                    res += Convert.ToString(cardNumberPart);
                }
            }
            return res;
        }
        public void CreateCard(string type,string age,string pin,string phone, string pass)
        {
            if (Int16.Parse(age) >= 18)
            {
                DB db = new DB();
                db.openConnection();

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("UPDATE `users` SET `CardNum` = @card, `PIN` = @pin WHERE `PhoneNum` = @phone AND Password = @pass", db.GetConnection());
                command.Parameters.Add("@card", MySqlDbType.VarChar).Value = CardNumGenenerate(type);
                command.Parameters.Add("@pin", MySqlDbType.VarChar).Value = pin;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

                if (command.ExecuteNonQuery() == 1)
                {
                    this.Close();
                    MainWin mw = new MainWin(phone,pass);
                    mw.Show();
                }
                db.closeConnection();
            }
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            string type = comboBox1.SelectedItem.ToString();
            string age = BrthInp.Text;
            string pin = PinInp.Text;

            CreateCard(type,age,pin,phone,pass);
        }
    }
}