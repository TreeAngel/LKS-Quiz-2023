using LKS_Quiz.Util;
using LKS_Quiz.WinForm.User;
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
    public partial class FormMainUser : Form
    {
        public FormMainUser()
        {
            InitializeComponent();
        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {
            lblFullname.Text = Helper.userSession.FullName;
            GetData();
        }

        private void GetData()
        {
            try
            {
                QuizinAjaEntities entities = new QuizinAjaEntities();
                var data = entities.Quizs.Where(x => x.UserID.Equals(Helper.userSession.ID));
                if (data == null)
                {
                    MessageBox.Show("You don't have any quiz now!");
                    return;
                }
                dgvUserQuiz.Rows.Clear();
                foreach (var item in data)
                {
                    dgvUserQuiz.Rows.Add(new object[]
                    {
                        item.ID,
                        item.Name,
                        item.Code,
                        item.Description,
                        item.Questions.Count,
                        "Delete",
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Helper.userSession = null;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            new FormAddQuiz().ShowDialog();
            Show();
        }
    }
}
