using LKS_Quiz.Util;
using LKS_Quiz.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Quiz
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Helper.ClearInput(panelInput);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Helper.IsEmptyOrNo(panelInput))
            {
                MessageBox.Show("Insert your username and password");
                return;
            }
            try
            {
                QuizinAjaEntities entities = new QuizinAjaEntities();
                var user = entities.Users.FirstOrDefault(x => x.Username.Equals(tbUsername.Text.Trim()) && x.Password.Equals(tbPassword.Text.Trim()));
                if (user == null)
                {
                    MessageBox.Show("Invalid credentials!");
                    return;
                }
                Helper.userSession = user;
                Hide();
                new FormMainUser().ShowDialog();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRegister().ShowDialog();
            Show();
        }

        private void linkJoinQuiz_Click(object sender, EventArgs e)
        {
            Hide();
            new FormJoinQuiz().ShowDialog();
            Show();
        }
    }
}
