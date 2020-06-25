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
using System.Data.Common;

namespace Bank
{
    public partial class MainWin : Form
    {
        DB db = new DB();
        private string phone;
        private string pass;
        public MainWin(string phone, string pass)
        {
            this.phone = phone;
            this.pass  = pass;
            db.openConnection();
            InitializeComponent();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `PhoneNum` = @phone"+
                " AND Password = @pass", db.GetConnection());
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                UserLabel.Text = "User: "+reader.GetString(1)+' '+reader.GetString(2)+' '
                   +reader.GetString(3)+"\nPhone number: +"+ reader.GetString(4);

                if (reader.GetString(0) == "0")
                {
                    UserLabel.Visible = false;
                    CardLabel.Text = "Seems like you stiil don't have any bank card :(";
                    CardLabel.Left = (this.Width / 2) - (CardLabel.Width / 2);
                    PlusImage.Left = (this.Width / 2) - (PlusImage.Width / 2);
                }
                else
                {
                    PlusImage.Visible = false;
                    string numb = reader.GetString(0).Insert(4," ");
                    numb = numb.Insert(9, " ");
                    numb = numb.Insert(14, " ");
                    CardLabel.Text = "Your Card Number: "+numb;
                }
            }

            db.closeConnection();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainWin_Load(object sender, EventArgs e)
        {
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
    }
}
