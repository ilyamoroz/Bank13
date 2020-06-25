using System;
using System.Threading;
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

            if(boolpass == true && boolpassrep == true && pass.Length >= 8 && pass.Length <= 16)
            {
                if (passRep == pass)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public bool phoneVal(string phone)
        {
            for (int i=0; i < phone.Length;i++)
            {
                if (!(phone[i] >= '0' && phone[i] <= '9' && phone.Length <= 12))
                {
                    MessageBox.Show("Blya");
                    return false;
                }
            }
            return true;
        }
        public string CreateCardNmber()
        {
            var Rand = new Random();
            string cardNumber = "";
            for (int counter = 0; counter < 4; counter++)
            {
                int cardNumberPart = Rand.Next(1000, 9999);
                cardNumber += Convert.ToString(cardNumberPart);
            }
            return cardNumber;
        }
        public int CreatePIN()
        {
            var Rand = new Random();
            int pin = Rand.Next(1000, 9999);
            return pin;

        }
        public void PushToDB(string sName,string fName,string fathName,string phoneN,string pass)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`CardNum`, `SecondName`, " +
            "`FirstName`, `FathersName`, `PhoneNum`, `Password`, `PIN`, `Balance`) VALUES (@cardn," +
            "@sname,@firname,@fathname,@phon,@pass,@pin,0);", db.GetConnection());

            command.Parameters.Add("@cardn", MySqlDbType.VarChar).Value = CreateCardNmber();
            command.Parameters.Add("@pin", MySqlDbType.VarChar).Value = CreatePIN();
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

            if(PassVal(pass, repPass)==true && phoneVal(phoneN) == true)
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

        private void PhoneNumInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')
                || PhoneNumInp.TextLength > 12)
            {
                e.Handled = true;
                if (e.KeyChar == (char)8)
                    e.Handled = false;
            }
        }

        private void FirstNameInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void SecondNameInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void FathersNameInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public bool Status(string text)
        {
            bool check = false;
            if (text.Length < 8 || text.Length > 16)
                return false;
            else
                check = true;
            for (int i=0;i<text.Length;i++)
            {
                if (!(text[i] >= 'A' && text[i] <= 'Z' || text[i] >= 'a' && text[i] <= 'z'
                    || text[i] >= '0' && text[i] <= '9'))
                    return false;
                else
                    check = true;
                Console.WriteLine(text[i]);
            }
            return check;
        }
        private void PassInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PassInp.TextLength == 16)
            {
                e.Handled = true;
                if (e.KeyChar == (char)8)
                    e.Handled = false;
            }
        }

        private void PassInpRepeat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PassInpRepeat.TextLength == 16)
            {
                e.Handled = true;
                if (e.KeyChar == (char)8)
                    e.Handled = false;
            }
        }
        private void PassInp_TextChanged(object sender, EventArgs e)
        {
            if (Status(PassInp.Text) == true)
                PassStatus.BackColor = Color.LimeGreen;
            else if(PassInp.Text == "")
                PassStatus.BackColor = Color.Transparent;
            else
                PassStatus.BackColor = Color.Red;
        }

        private void PassInpRepeat_TextChanged(object sender, EventArgs e)
        {
            if (PassInp.Text == PassInpRepeat.Text)
                PassRepStatus.BackColor = Color.LimeGreen;
            else if(PassInpRepeat.Text == "")
                PassRepStatus.BackColor = Color.Transparent;
            else
                PassRepStatus.BackColor = Color.Red;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}