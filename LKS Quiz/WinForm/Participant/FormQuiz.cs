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

namespace LKS_Quiz.WinForm.Participant
{
    public partial class FormQuiz : Form
    {
        private readonly string nickname;
        private readonly Quiz quiz;

        DateTime startTime;
        TimeSpan elapsedTime;
        List<Question> questions;
        List<ParticipantAnswer> answers;
        //int ; 

        public FormQuiz(string nickname, Quiz quiz)
        {
            InitializeComponent();
            this.nickname = nickname;
            this.quiz = quiz;
            timerElapsed.Start();
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            lblNickname.Text = nickname;
            questions = quiz.Questions.ToList();
            loadQuestionButton();
        }

        private void timerElapsed_Tick(object sender, EventArgs e)
        {
            lblTimeElapsed.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void loadQuestionButton()
        {
            try
            {
                fpanelQuestionsBtn.Controls.Clear();
                int index = 1;
                foreach (var item in questions)
                {
                    var userControl = new UserControlQuestionButton();
                    var button = userControl.Controls.OfType<Button>().FirstOrDefault();
                    button.Text = index.ToString();

                    //fpanelQuestionsBtn.Controls.Add();
                    index++;
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
