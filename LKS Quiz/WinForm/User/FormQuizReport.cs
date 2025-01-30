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

namespace LKS_Quiz.WinForm.User
{
    public partial class FormQuizReport : Form
    {
        private readonly List<Quiz> userQuizzes = new List<Quiz>();

        public FormQuizReport(List<Quiz> userQuizzes)
        {
            InitializeComponent();
            this.userQuizzes = userQuizzes;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormQuizReport_Load(object sender, EventArgs e)
        {
            if (userQuizzes.Count <= 0)
            {
                MessageBox.Show("You don't have quiz");
                return;
            }
            cbQuiz.Items.Clear();
            foreach (var item in userQuizzes)
            {
                cbQuiz.Items.Add(item.Name);
            }
            cbQuiz.SelectedIndex = 0;
            LoadData(userQuizzes.First(x => x.Name.Equals(cbQuiz.SelectedItem.ToString())));
        }

        private void LoadData(Quiz quiz)
        {
            try
            {
                QuizinAjaEntities entities = new QuizinAjaEntities();
                var participants = entities.Participants.Where(x => x.QuizID == quiz.ID);
                if (!participants.Any())
                {
                    MessageBox.Show("This quiz doesn't have any participant at the time");
                    return;
                }
                dgvQuizParticipants.Rows.Clear();
                foreach (var item in participants)
                {
                    dgvQuizParticipants.Rows.Add(new object[]
                    {
                        item.ParticipantNickname,
                        Convert.ToDateTime(item.ParticipationDate.ToString("HH:mm:ss")),
                        (item.ParticipantAnswers.Count()),
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
