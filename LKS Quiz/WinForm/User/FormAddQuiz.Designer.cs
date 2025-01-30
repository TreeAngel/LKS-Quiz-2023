namespace LKS_Quiz.WinForm.User
{
    partial class FormAddQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelQuizInput = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuizDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQuizCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuizName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelQuestionInput = new System.Windows.Forms.Panel();
            this.dgvNewQuizQuestions = new System.Windows.Forms.DataGridView();
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.tbOptD = new System.Windows.Forms.TextBox();
            this.tbOptC = new System.Windows.Forms.TextBox();
            this.tbOptB = new System.Windows.Forms.TextBox();
            this.tbOptA = new System.Windows.Forms.TextBox();
            this.rBtnOptD = new System.Windows.Forms.RadioButton();
            this.rBtnOptC = new System.Windows.Forms.RadioButton();
            this.rBtnOptB = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rBtnOptA = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelQuizInput.SuspendLayout();
            this.panelQuestionInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewQuizQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Fill in the quiz detail below";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "Add New Quiz";
            // 
            // panelQuizInput
            // 
            this.panelQuizInput.Controls.Add(this.label5);
            this.panelQuizInput.Controls.Add(this.tbQuizDesc);
            this.panelQuizInput.Controls.Add(this.label4);
            this.panelQuizInput.Controls.Add(this.tbQuizCode);
            this.panelQuizInput.Controls.Add(this.label3);
            this.panelQuizInput.Controls.Add(this.tbQuizName);
            this.panelQuizInput.Location = new System.Drawing.Point(16, 62);
            this.panelQuizInput.Name = "panelQuizInput";
            this.panelQuizInput.Size = new System.Drawing.Size(756, 98);
            this.panelQuizInput.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Quiz Description";
            // 
            // tbQuizDesc
            // 
            this.tbQuizDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuizDesc.Location = new System.Drawing.Point(385, 16);
            this.tbQuizDesc.Multiline = true;
            this.tbQuizDesc.Name = "tbQuizDesc";
            this.tbQuizDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbQuizDesc.Size = new System.Drawing.Size(350, 73);
            this.tbQuizDesc.TabIndex = 3;
            this.tbQuizDesc.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Quiz Code";
            // 
            // tbQuizCode
            // 
            this.tbQuizCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuizCode.Location = new System.Drawing.Point(6, 65);
            this.tbQuizCode.Name = "tbQuizCode";
            this.tbQuizCode.Size = new System.Drawing.Size(334, 20);
            this.tbQuizCode.TabIndex = 2;
            this.tbQuizCode.TextChanged += new System.EventHandler(this.tbQuizCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Quiz Name";
            // 
            // tbQuizName
            // 
            this.tbQuizName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuizName.Location = new System.Drawing.Point(6, 16);
            this.tbQuizName.Name = "tbQuizName";
            this.tbQuizName.Size = new System.Drawing.Size(334, 20);
            this.tbQuizName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(551, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(665, 476);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelQuestionInput
            // 
            this.panelQuestionInput.Controls.Add(this.dgvNewQuizQuestions);
            this.panelQuestionInput.Controls.Add(this.btnAddQuestion);
            this.panelQuestionInput.Controls.Add(this.tbOptD);
            this.panelQuestionInput.Controls.Add(this.tbOptC);
            this.panelQuestionInput.Controls.Add(this.tbOptB);
            this.panelQuestionInput.Controls.Add(this.tbOptA);
            this.panelQuestionInput.Controls.Add(this.rBtnOptD);
            this.panelQuestionInput.Controls.Add(this.rBtnOptC);
            this.panelQuestionInput.Controls.Add(this.rBtnOptB);
            this.panelQuestionInput.Controls.Add(this.label8);
            this.panelQuestionInput.Controls.Add(this.rBtnOptA);
            this.panelQuestionInput.Controls.Add(this.label7);
            this.panelQuestionInput.Controls.Add(this.tbQuestion);
            this.panelQuestionInput.Controls.Add(this.label6);
            this.panelQuestionInput.Location = new System.Drawing.Point(16, 176);
            this.panelQuestionInput.Name = "panelQuestionInput";
            this.panelQuestionInput.Size = new System.Drawing.Size(756, 294);
            this.panelQuestionInput.TabIndex = 111;
            // 
            // dgvNewQuizQuestions
            // 
            this.dgvNewQuizQuestions.AllowUserToAddRows = false;
            this.dgvNewQuizQuestions.AllowUserToDeleteRows = false;
            this.dgvNewQuizQuestions.AllowUserToResizeColumns = false;
            this.dgvNewQuizQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewQuizQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewQuizQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNo,
            this.clmQuestion,
            this.clmOptionA,
            this.clmOptionB,
            this.clmOptionC,
            this.clmOptionD,
            this.clmCorrectAnswer,
            this.clmDeleteBtn});
            this.dgvNewQuizQuestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNewQuizQuestions.Location = new System.Drawing.Point(0, 148);
            this.dgvNewQuizQuestions.MultiSelect = false;
            this.dgvNewQuizQuestions.Name = "dgvNewQuizQuestions";
            this.dgvNewQuizQuestions.ReadOnly = true;
            this.dgvNewQuizQuestions.RowHeadersVisible = false;
            this.dgvNewQuizQuestions.Size = new System.Drawing.Size(756, 146);
            this.dgvNewQuizQuestions.TabIndex = 221;
            this.dgvNewQuizQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewQuizQuestions_CellContentClick);
            // 
            // clmNo
            // 
            this.clmNo.HeaderText = "No";
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            // 
            // clmQuestion
            // 
            this.clmQuestion.HeaderText = "Question";
            this.clmQuestion.Name = "clmQuestion";
            this.clmQuestion.ReadOnly = true;
            // 
            // clmOptionA
            // 
            this.clmOptionA.HeaderText = "OptionA";
            this.clmOptionA.Name = "clmOptionA";
            this.clmOptionA.ReadOnly = true;
            // 
            // clmOptionB
            // 
            this.clmOptionB.HeaderText = "OptionB";
            this.clmOptionB.Name = "clmOptionB";
            this.clmOptionB.ReadOnly = true;
            // 
            // clmOptionC
            // 
            this.clmOptionC.HeaderText = "OptionC";
            this.clmOptionC.Name = "clmOptionC";
            this.clmOptionC.ReadOnly = true;
            // 
            // clmOptionD
            // 
            this.clmOptionD.HeaderText = "OptionD";
            this.clmOptionD.Name = "clmOptionD";
            this.clmOptionD.ReadOnly = true;
            // 
            // clmCorrectAnswer
            // 
            this.clmCorrectAnswer.HeaderText = "CorrectAnswer";
            this.clmCorrectAnswer.Name = "clmCorrectAnswer";
            this.clmCorrectAnswer.ReadOnly = true;
            // 
            // clmDeleteBtn
            // 
            this.clmDeleteBtn.HeaderText = "Delete";
            this.clmDeleteBtn.Name = "clmDeleteBtn";
            this.clmDeleteBtn.ReadOnly = true;
            this.clmDeleteBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDeleteBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.AutoSize = true;
            this.btnAddQuestion.Location = new System.Drawing.Point(654, 73);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(81, 23);
            this.btnAddQuestion.TabIndex = 13;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // tbOptD
            // 
            this.tbOptD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOptD.Location = new System.Drawing.Point(405, 110);
            this.tbOptD.Name = "tbOptD";
            this.tbOptD.Size = new System.Drawing.Size(210, 20);
            this.tbOptD.TabIndex = 11;
            // 
            // tbOptC
            // 
            this.tbOptC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOptC.Location = new System.Drawing.Point(405, 87);
            this.tbOptC.Name = "tbOptC";
            this.tbOptC.Size = new System.Drawing.Size(210, 20);
            this.tbOptC.TabIndex = 9;
            // 
            // tbOptB
            // 
            this.tbOptB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOptB.Location = new System.Drawing.Point(405, 64);
            this.tbOptB.Name = "tbOptB";
            this.tbOptB.Size = new System.Drawing.Size(210, 20);
            this.tbOptB.TabIndex = 7;
            // 
            // tbOptA
            // 
            this.tbOptA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOptA.Location = new System.Drawing.Point(405, 41);
            this.tbOptA.Name = "tbOptA";
            this.tbOptA.Size = new System.Drawing.Size(210, 20);
            this.tbOptA.TabIndex = 5;
            this.tbOptA.TextChanged += new System.EventHandler(this.tbOptA_TextChanged);
            // 
            // rBtnOptD
            // 
            this.rBtnOptD.AutoSize = true;
            this.rBtnOptD.Location = new System.Drawing.Point(385, 112);
            this.rBtnOptD.Name = "rBtnOptD";
            this.rBtnOptD.Size = new System.Drawing.Size(14, 13);
            this.rBtnOptD.TabIndex = 12;
            this.rBtnOptD.TabStop = true;
            this.rBtnOptD.UseVisualStyleBackColor = true;
            this.rBtnOptD.CheckedChanged += new System.EventHandler(this.rBtnOptD_CheckedChanged);
            // 
            // rBtnOptC
            // 
            this.rBtnOptC.AutoSize = true;
            this.rBtnOptC.Location = new System.Drawing.Point(385, 89);
            this.rBtnOptC.Name = "rBtnOptC";
            this.rBtnOptC.Size = new System.Drawing.Size(14, 13);
            this.rBtnOptC.TabIndex = 10;
            this.rBtnOptC.TabStop = true;
            this.rBtnOptC.UseVisualStyleBackColor = true;
            this.rBtnOptC.CheckedChanged += new System.EventHandler(this.rBtnOptC_CheckedChanged);
            // 
            // rBtnOptB
            // 
            this.rBtnOptB.AutoSize = true;
            this.rBtnOptB.Location = new System.Drawing.Point(385, 66);
            this.rBtnOptB.Name = "rBtnOptB";
            this.rBtnOptB.Size = new System.Drawing.Size(14, 13);
            this.rBtnOptB.TabIndex = 8;
            this.rBtnOptB.TabStop = true;
            this.rBtnOptB.UseVisualStyleBackColor = true;
            this.rBtnOptB.CheckedChanged += new System.EventHandler(this.rBtnOptb_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 141;
            this.label8.Text = "Answer";
            // 
            // rBtnOptA
            // 
            this.rBtnOptA.AutoSize = true;
            this.rBtnOptA.Location = new System.Drawing.Point(385, 43);
            this.rBtnOptA.Name = "rBtnOptA";
            this.rBtnOptA.Size = new System.Drawing.Size(14, 13);
            this.rBtnOptA.TabIndex = 6;
            this.rBtnOptA.TabStop = true;
            this.rBtnOptA.UseVisualStyleBackColor = true;
            this.rBtnOptA.CheckedChanged += new System.EventHandler(this.rBtnOptA_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Question";
            // 
            // tbQuestion
            // 
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuestion.Location = new System.Drawing.Point(6, 39);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbQuestion.Size = new System.Drawing.Size(350, 90);
            this.tbQuestion.TabIndex = 4;
            this.tbQuestion.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 121;
            this.label6.Text = "Question Data";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // FormAddQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.panelQuestionInput);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelQuizInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAddQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizinAja - Online Quiz Platform";
            this.Load += new System.EventHandler(this.FormAddQuiz_Load);
            this.panelQuizInput.ResumeLayout(false);
            this.panelQuizInput.PerformLayout();
            this.panelQuestionInput.ResumeLayout(false);
            this.panelQuestionInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewQuizQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelQuizInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQuizDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQuizCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuizName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelQuestionInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rBtnOptA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNewQuizQuestions;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox tbOptD;
        private System.Windows.Forms.TextBox tbOptC;
        private System.Windows.Forms.TextBox tbOptB;
        private System.Windows.Forms.TextBox tbOptA;
        private System.Windows.Forms.RadioButton rBtnOptD;
        private System.Windows.Forms.RadioButton rBtnOptC;
        private System.Windows.Forms.RadioButton rBtnOptB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOptionA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOptionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOptionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOptionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorrectAnswer;
        private System.Windows.Forms.DataGridViewButtonColumn clmDeleteBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}