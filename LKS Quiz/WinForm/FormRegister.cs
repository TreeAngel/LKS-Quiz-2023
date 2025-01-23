using LKS_Quiz.Util;
using System;
using System.Linq;
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
            if (tbPassword.Text.Length <4)
            {
                MessageBox.Show("Password must be at 4 characters long");
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
                entities.Users.Add(new Util.User // Untuk ini entah kenapa harus pake Util.User kalau bisa usahakan langsung aja refer to User yang dari database
                {
                    Username = tbUsername.Text.Trim(),
                    FullName = tbFullName.Text.Trim(),
                    Password = tbPassword.Text.Trim(),
                    DateOfBirth = dateOfBirth,
                });
                entities.SaveChanges();
                MessageBox.Show("Successfully created a new accound");
                Helper.ClearInput(panelInput);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
