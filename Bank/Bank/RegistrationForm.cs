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
    public partial class RegistrationForm : Form
    {
        public int RandInt()
        {
            var Rand = new Random();
            int value = Rand.Next(1, 50);
            return value;
        }
        public bool PassVal(string pass, string passRep)
        {
            bool boolpass = false;
            bool boolpassrep = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] >= 'A' && pass[i] <= 'Z' || pass[i] >= 'a' && pass[i] <= 'z'
                    || pass[i] >= '0' && pass[i] <= '9')
                    boolpass = true;
                else { boolpass = false; return boolpass; }
            }

            for (int i = 0; i < passRep.Length; i++)
            {
                if (passRep[i] >= 'A' && passRep[i] <= 'Z' || passRep[i] >= 'a' && passRep[i] <= 'z'
                    || passRep[i] >= '0' && passRep[i] <= '9')
                    boolpassrep = true;
                else { boolpassrep = false; return boolpassrep; }
            }

            if(boolpass == true && boolpassrep == true)
            {
                if (passRep == pass)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public void PushToDB(string sName,string fName,string fathName,string phoneN,string pass)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`CardNum`, `SecondName`, " +
            "`FirstName`, `FathersName`, `PhoneNum`, `Password`, `PIN`, `Balance`) VALUES (@bal," +
            "@sname,@firname,@fathname,@phon,@pass,0,0);", db.GetConnection());

            command.Parameters.Add("@bal", MySqlDbType.VarChar).Value = RandInt();
            command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = sName;
            command.Parameters.Add("@firname", MySqlDbType.VarChar).Value = fName;
            command.Parameters.Add("@fathname", MySqlDbType.VarChar).Value = fathName;
            command.Parameters.Add("@phon", MySqlDbType.VarChar).Value = phoneN;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                LoginForm lf = new LoginForm();
                lf.Show();
            }
            db.closeConnection();
        }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BackToLogButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string fName = FirstNameInp.Text;
            string sName = SecondNameInp.Text;
            string fathName = FathersNameInp.Text;
            string phoneN = PhoneNumInp.Text;
            string pass = PassInp.Text;
            string repPass = PassInpRepeat.Text;

            if(PassVal(pass, repPass)==true)
            {
                PushToDB(sName,fName,fathName,phoneN,pass);
            }
        }

        private void VisiblePass_CheckedChanged(object sender, EventArgs e)
        {
            if (VisiblePass.Checked == true)
                PassInp.UseSystemPasswordChar = false;
            else
                PassInp.UseSystemPasswordChar = true;
        }

        private void VisiblePass1_CheckedChanged(object sender, EventArgs e)
        {
            if(VisiblePass1.Checked == true)
                PassInpRepeat.UseSystemPasswordChar = false;
            else
                PassInpRepeat.UseSystemPasswordChar = true;
        }
    }
}
