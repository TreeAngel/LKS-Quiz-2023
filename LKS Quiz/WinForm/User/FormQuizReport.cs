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
            LoadData(cbQuiz.SelectedItem.ToString());
        }

        private void LoadData(String quizName)
        {
            try
            {
                QuizinAjaEntities entities = new QuizinAjaEntities();
                var participants = entities.Participants.Where(x => x.Quiz.Name.Equals(quizName));
                var questions = entities.Questions.Where(x => x.Quiz.Name.Equals(quizName));
                if (participants.Any() && questions.Any())
                {
                    var avgTimeTaken = TimeSpan.FromSeconds(participants.Average(x => x.TimeTaken));
                    lblAverageTime.Text = avgTimeTaken.ToString();

                    var avgCorrectPercentage = participants.Average(x => x.ParticipantAnswers.Count(
                                y => y.Answer == y.Question.CorrectAnswer) / questions.Count() * 100);
                    lblCorrectPercentage.Text = $"{avgCorrectPercentage}%";

                    lblTotalParticipant.Text = $"{participants.Count()} Participant(s)";

                    dgvQuizParticipants.Rows.Clear();
                    foreach (var item in participants)
                    {
                        double correctAnswer = item.ParticipantAnswers.Count(x => x.Answer.Equals(x.Question.CorrectAnswer));
                        double correctPercentage = correctAnswer / questions.Count() * 100;
                        correctPercentage = Math.Round(correctPercentage, 2);
                        dgvQuizParticipants.Rows.Add(new object[]
                        {
                            item.ParticipantNickname,
                            TimeSpan.FromSeconds(item.TimeTaken),
                            $"{correctPercentage}%",
                        });
                    }
                }
                else
                {
                    lblAverageTime.Text = "00:00:00";
                    lblCorrectPercentage.Text = "00%";
                    lblTotalParticipant.Text = "0 Participant(s)";
                    dgvQuizParticipants.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void cbQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(cbQuiz.SelectedItem.ToString());
        }
    }
}
