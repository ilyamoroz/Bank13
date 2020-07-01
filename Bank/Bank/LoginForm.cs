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
    public partial class LoginForm : Form
    {
        string userPhone;
        string userPass;
        

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            SavePassword SP = new SavePassword();
            if (SP.CheckedFile())
            { 
                ConnectionToDB(SP.GetData(0), SP.GetData(1));
            }
        }
        private void ConnectionToDB(string userPhone, string userPass)
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `PhoneNum` = @uL" +
                                                        " AND `Password` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userPhone;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainWin mw = new MainWin(userPhone, userPass);
                SavePassword(userPhone, userPass);
                mw.Show();
                

            }
        }
        private void enterButton_Click_1(object sender, EventArgs e)
        {
            ConnectionToDB(PhoneInp.Text, PassInp.Text);
        }
        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm register = new RegistrationForm();
            register.Show();
        }
        private void VisiblePass_CheckedChanged(object sender, EventArgs e)
        {
            if (VisiblePass.Checked == true)
                PassInp.UseSystemPasswordChar = false;
            else
                PassInp.UseSystemPasswordChar = true;
        }

        private void PhoneInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') 
                || PhoneInp.TextLength > 12)
            {
                e.Handled = true;
                if (e.KeyChar == (char)8)
                    e.Handled = false;
            }
        }
        public void SavePassword(string login, string pass)
        {
            if (SavePass.Checked == true)
            {
                SavePassword SP = new SavePassword(login, pass);
            }
        }
    }
}