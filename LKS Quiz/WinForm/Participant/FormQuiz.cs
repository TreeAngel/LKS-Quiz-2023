﻿using LKS_Quiz.Util;
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
        int questionIndex, selectedIndex;
        string participantAnswer;

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
            startTime = DateTime.Now;
        }

        private void timerElapsed_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - startTime;
            lblTimeElapsed.Text = elapsedTime.ToString();
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
                    userControl.btnQuestion.Text = index.ToString();
                    userControl.btnQuestion.Name = index.ToString();
                    userControl.btnQuestion.Click += btnQuestion_Click;
                    fpanelQuestionsBtn.Controls.Add(userControl);
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            NavigateQuestion(Convert.ToInt32(button.Name));
        }

        private void NavigateQuestion(int index)
        {
            foreach (Control control in panelQuestion.Controls)
            {
                if (control is RadioButton rb)
                {
                    if (!rb.Checked)
                    {
                        return;
                    }
                    AddAnswer();
                    rb.Checked = false;
                    UserControlQuestionButton userControl = (UserControlQuestionButton)fpanelQuestionsBtn.Controls[index];
                    userControl.DoneColor();
                }
            }
            selectedIndex = index;
            questionIndex = selectedIndex;
            if (index == questions.Count - 1)
            {
                btnNext.Text = "Finish";
            }
            else
            {
                btnNext.Text = "Next";
            }
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            Question question = questions[questionIndex];
            ParticipantAnswer answer = answers.FirstOrDefault(x => x.QuestionID.Equals(question.ID));

            lblQuestion.Text = question.Question1.Trim();
            rbOptionA.Text = question.OptionA.Trim();
            rbOptionB.Text = question.OptionB.Trim();
            rbOptionC.Text = question.OptionC.Trim();
            rbOptionD.Text = question.OptionD.Trim();

            if (answer == null)
            {
                return;
            }
            if (answer.Answer.Trim() == question.OptionA.Trim())
            {
                rbOptionA.Checked = true;
            }
            if (answer.Answer.Trim() == question.OptionB.Trim())
            {
                rbOptionB.Checked = true;
            }
            if (answer.Answer.Trim() == question.OptionC.Trim())
            {
                rbOptionC.Checked = true;
            }
            if (answer.Answer.Trim() == question.OptionD.Trim())
            {
                rbOptionD.Checked = true;
            }
            if (selectedIndex == 0)
            {
                btnPrev.Visible = false;
            }
            else
            {
                btnPrev.Visible = true;
            }
        }

        private void AddAnswer()
        {
            participantAnswer = GetAnswer();
            ParticipantAnswer answer = answers.FirstOrDefault(x => x.QuestionID == questions[selectedIndex].ID);
            if (answer != null)
            {
                answers.Remove(answer);
            }
            answers.Add(new ParticipantAnswer
            {
                QuestionID = questions[selectedIndex].ID,
                Answer = participantAnswer,
            });
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnNext.Text.Trim() == "Next")
            {
                if (questionIndex == questions.Count - 1)
                {
                    return;
                }
                questionIndex++;
                NavigateQuestion(questionIndex);
            }
            if (btnNext.Text.Trim() == "Finish")
            {
                foreach (Control control in panelQuestion.Controls)
                {
                    if (control is RadioButton rb)
                    {
                        if (!rb.Checked) { return; }
                        participantAnswer = GetAnswer();
                        rb.Checked = false;
                    }
                }
                AddAnswer();
                if (answers.Count != questions.Count)
                {
                    MessageBox.Show("All questions must be answered");
                    return;
                }
                if (MessageBox.Show("Finish and submit this quiz?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                try
                {
                    int participantId = SaveParticipant();
                    QuizinAjaEntities entities = new QuizinAjaEntities();
                    foreach (var item in answers)
                    {
                        item.ParticipantID = participantId;
                        entities.ParticipantAnswers.Add(item);
                    }
                    entities.SaveChanges();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
        }

        private int SaveParticipant()
        {
            QuizinAjaEntities entities = new QuizinAjaEntities();
            Util.Participant participant = entities.Participants.Add(new Util.Participant
            {
                QuizID = quiz.ID,
                ParticipantNickname = nickname,
                ParticipationDate = DateTime.Now,
                TimeTaken = (int)elapsedTime.TotalSeconds,
            });
            entities.SaveChanges();
            return participant.ID;
        }

        private string GetAnswer()
        {
            if (rbOptionA.Checked)
            {
                return rbOptionA.Text.Trim();
            }
            if (rbOptionB.Checked)
            {
                return rbOptionB.Text.Trim();
            }
            if (rbOptionC.Checked)
            {
                return rbOptionC.Text.Trim();
            }
            if (rbOptionD.Checked)
            {
                return rbOptionD.Text.Trim();
            }
            MessageBox.Show("Pick one choice");
            throw new Exception();
        }
    }
}
