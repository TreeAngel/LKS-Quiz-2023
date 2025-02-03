using LKS_Quiz.Util;
using LKS_Quiz.WinForm.Participant;
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
    public partial class FormJoinQuiz : Form
    {
        public FormJoinQuiz()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Helper.IsEmptyOrNo(panelInput))
            {
                MessageBox.Show("Enter the quiz code and you nickname");
                return;
            }
            QuizinAjaEntities entities = new QuizinAjaEntities();
            var quiz = entities.Quizs.FirstOrDefault(x => x.Code.Equals(tbQuizCode.Text.Trim()));
            if (quiz == null)
            {
                MessageBox.Show("Quiz code not valid");
                return;
            }
            this.Hide();
            new FormQuiz(tbNickname.Text.Trim(), quiz).ShowDialog();
            Show();
        }

        private void FormJoinQuiz_Load(object sender, EventArgs e)
        {
            tbQuizCode.KeyPress += Helper.tbQuizCode_KeyPress;
        }
    }
}
