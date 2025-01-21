using LKS_Quiz.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Quiz.WinForm
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            Helper.ClearInput(panelInput);
            dtpBirth.Value = DateTime.Now;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!Helper.IsEmptyOrNo(panelInput))
            {
                MessageBox.Show("Fill all information to proceed!");
                return;
            }
            if (!tbRePassword.Text.Equals(tbPassword.Text))
            {
                MessageBox.Show("Confirm your password!");
                return;
            }
            if (MessageBox.Show("Are you sure you want to create a new account?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            try
            {
                QuizinAjaEntities entities = new QuizinAjaEntities();
                var user = entities.Users.FirstOrDefault(x => x.Username.Equals(tbUsername.Text));
                if (user != null)
                {
                    MessageBox.Show("Username already taken, choose another one");
                    return;
                }
                DateTime dateOfBirth = Convert.ToDateTime(dtpBirth.Value.ToShortDateString());
                entities.Users.Add(new User
                {
                    Username = tbUsername.Text,
                    FullName = tbUsername.Text,
                    Password = tbPassword.Text,
                    DateOfBirth = dateOfBirth,
                });
                entities.SaveChanges();
                MessageBox.Show("Successfully created a new accound");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
