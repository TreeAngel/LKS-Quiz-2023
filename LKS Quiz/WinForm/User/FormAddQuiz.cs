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
    public partial class FormAddQuiz : Form
    {
        Quiz newQuiz;
        List<Question> questions = new List<Question>();
        bool codeValid;
        String correctAnswer;

        public FormAddQuiz()
        {
            InitializeComponent();
        }

        private void FormAddQuiz_Load(object sender, EventArgs e)
        {
            Helper.ClearInput(this);
            tbQuizCode.KeyPress += tbQuizCode_KeyPress;
        }

        private void tbQuizCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!tbQuizCode.Text.Any(char.IsUpper) || !tbQuizCode.Text.Any(char.IsNumber))
                {
                    errorProvider.SetError(tbQuizCode, "Quiz must contain both uppercase character and number");
                    codeValid = true;
                    return;
                }
                QuizinAjaEntities entities = new QuizinAjaEntities();
                Quiz quiz = entities.Quizs.FirstOrDefault(x => x.Code.Equals(tbQuizCode.Text));
                if (quiz != null)
                {
                    //MessageBox.Show($"Quiz with {tbQuizCode} code already exist");
                    errorProvider.SetError(tbQuizCode, "Quiz code not unique");
                    codeValid = false;
                    return;
                }
                errorProvider.Clear();
                codeValid = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        public static void tbQuizCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsUpper(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rBtnOptA_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer = tbOptA.Text.Trim();
        }

        private void rBtnOptb_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer = tbOptB.Text.Trim();
        }

        private void rBtnOptC_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer = tbOptC.Text.Trim();
        }

        private void rBtnOptD_CheckedChanged(object sender, EventArgs e)
        {
            correctAnswer = tbOptD.Text.Trim();
        }

        private void tbOptA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {

                if (!Helper.IsEmptyOrNo(panelQuizInput))
                {
                    MessageBox.Show("Fill the quiz detail before add question");
                    return;
                }
                if (!codeValid)
                {
                    MessageBox.Show("Quiz code not unique");
                    return;
                }

                newQuiz = new Quiz
                {
                    UserID = Helper.userSession.ID,
                    Name = tbQuizName.Text.Trim(),
                    Code = tbQuizCode.Text.Trim(),
                    Description = tbQuizDesc.Text.Trim(),
                };

                if (!Helper.IsEmptyOrNo(panelQuestionInput))
                {
                    MessageBox.Show("Fill all question data to proceed");
                    return;
                }
                if (String.IsNullOrEmpty(correctAnswer) || !panelQuestionInput.Controls.OfType<RadioButton>().Any(x => x.Checked))
                {
                    MessageBox.Show("Select the correct answer");
                    return;
                }

                var checkedRBTN = panelQuestionInput.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
                if (checkedRBTN.Equals(rBtnOptA))
                {
                    correctAnswer = tbOptA.Text.Trim();
                }
                if (checkedRBTN.Equals(rBtnOptB))
                {
                    correctAnswer = tbOptB.Text.Trim();
                }
                if (checkedRBTN.Equals(rBtnOptC))
                {
                    correctAnswer = tbOptC.Text.Trim();
                }
                if (checkedRBTN.Equals(rBtnOptD))
                {
                    correctAnswer = tbOptD.Text.Trim();
                }

                Question newQuestion = new Question
                {
                    QuizID = newQuiz.ID,
                    Question1 = tbQuestion.Text.Trim(),
                    OptionA = tbOptA.Text.Trim(),
                    OptionB = tbOptB.Text.Trim(),
                    OptionC = tbOptC.Text.Trim(),
                    OptionD = tbOptD.Text.Trim(),
                    CorrectAnswer = correctAnswer,
                };
                int existQuestion = questions.FindIndex(x => x.Question1.Equals(newQuestion.Question1));
                if (existQuestion != -1)
                {
                    questions[existQuestion] = newQuestion;
                }
                else
                {
                    questions.Add(newQuestion);
                }
                LoadQuestions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void LoadQuestions()
        {
            if (questions.Count <= 0)
            {
                return;
            }
            dgvNewQuizQuestions.Rows.Clear();
            int no = 1;
            foreach (var item in questions)
            {
                dgvNewQuizQuestions.Rows.Add(new object[]
                {
                    no,
                    item.Question1,
                    item.OptionA,
                    item.OptionB,
                    item.OptionC,
                    item.OptionD,
                    item.CorrectAnswer,
                    "Delete",
                });
                no++;
            }
            dgvNewQuizQuestions.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel all the procedure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            Helper.ClearInput(this);
            if (MessageBox.Show("Close this window?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
