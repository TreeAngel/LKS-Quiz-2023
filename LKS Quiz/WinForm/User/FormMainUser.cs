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
        List<Quiz> quizzes = new List<Quiz>();

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
                    quizzes.Add(item);
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
            Helper.userSession = new Util.User();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            new FormAddQuiz().ShowDialog();
            Show();
            GetData();
        }

        private void dgvUserQuiz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvUserQuiz.Columns["clmActionBtn"].Index)
            {
                if (MessageBox.Show("Delete this quiz?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                try
                {
                    QuizinAjaEntities entities = new QuizinAjaEntities();
                    Console.WriteLine(quizzes[e.RowIndex].ID);
                    Quiz delete = entities.Quizs.Find(quizzes[e.RowIndex].ID);
                    if (delete == null)
                    {
                        MessageBox.Show("Quiz not found or not exist in the actual database");
                        return;
                    }
                    else
                    {
                        var questions = entities.Questions.Where(x => x.QuizID == delete.ID);
                        var participants = entities.Participants.Where(x => x.QuizID == delete.ID);
                        var answer = entities.ParticipantAnswers.Where(x => x.Question.QuizID == delete.ID && x.Participant.QuizID == delete.ID);

                        entities.ParticipantAnswers.RemoveRange(answer);
                        entities.Questions.RemoveRange(questions);
                        entities.Participants.RemoveRange(participants);

                        entities.Quizs.Remove(delete);
                        entities.SaveChanges();
                        GetData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Hide();
            new FormQuizReport(quizzes).ShowDialog();
            Show();
        }
    }
}
