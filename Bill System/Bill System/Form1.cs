using Functions;
using System;
using System.Windows.Forms;

namespace Bill_System
{
    public partial class Login : Form
    {
        Functions.Class1 dllfile = new Class1();
        public Login()
        {
            InitializeComponent();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (dllfile.userN[i] == UserNameTB.Text)
                {
                    if (dllfile.password[i] == dllfile.Decrypt(PasswordTB.Text))
                    {
                        MessageBox.Show("Login Successfull");
                        Purchase pur = new Purchase();
                        pur.Show();
                        UserNameTB.Clear();
                        PasswordTB.Clear();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                        break;
                    }
                }
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (PasswordSU_TB.Text == CnfrmPassSU_TB.Text)
            {
                dllfile.Encrypt(PasswordSU_TB.Text, UNameSU_TB.Text);
                MessageBox.Show("Register Successfull");
                UNameSU_TB.Clear();
                PasswordSU_TB.Clear();
                CnfrmPassSU_TB.Clear();
            }
            else
            {
                MessageBox.Show("Password doesn't match");
            }
        }

        private void SULogin_Btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }
    }
}
