namespace LKS_Quiz.WinForm.User
{
    partial class FormQuizReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbQuiz = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAverageTime = new System.Windows.Forms.Label();
            this.lblCorrectPercentage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalParticipant = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvQuizParticipants = new System.Windows.Forms.DataGridView();
            this.clmParticipantNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCorrectPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Quiz Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quiz";
            // 
            // cbQuiz
            // 
            this.cbQuiz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuiz.FormattingEnabled = true;
            this.cbQuiz.Location = new System.Drawing.Point(47, 50);
            this.cbQuiz.Name = "cbQuiz";
            this.cbQuiz.Size = new System.Drawing.Size(329, 21);
            this.cbQuiz.TabIndex = 2;
            this.cbQuiz.SelectedIndexChanged += new System.EventHandler(this.cbQuiz_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average Time Taken :";
            // 
            // lblAverageTime
            // 
            this.lblAverageTime.AutoSize = true;
            this.lblAverageTime.Location = new System.Drawing.Point(635, 53);
            this.lblAverageTime.Name = "lblAverageTime";
            this.lblAverageTime.Size = new System.Drawing.Size(49, 13);
            this.lblAverageTime.TabIndex = 4;
            this.lblAverageTime.Text = "00:00:00";
            // 
            // lblCorrectPercentage
            // 
            this.lblCorrectPercentage.AutoSize = true;
            this.lblCorrectPercentage.Location = new System.Drawing.Point(670, 81);
            this.lblCorrectPercentage.Name = "lblCorrectPercentage";
            this.lblCorrectPercentage.Size = new System.Drawing.Size(27, 13);
            this.lblCorrectPercentage.TabIndex = 6;
            this.lblCorrectPercentage.Text = "00%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Average Correct Percentage :";
            // 
            // lblTotalParticipant
            // 
            this.lblTotalParticipant.AutoSize = true;
            this.lblTotalParticipant.Location = new System.Drawing.Point(611, 106);
            this.lblTotalParticipant.Name = "lblTotalParticipant";
            this.lblTotalParticipant.Size = new System.Drawing.Size(83, 13);
            this.lblTotalParticipant.TabIndex = 8;
            this.lblTotalParticipant.Text = "00 Participant(s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Participant :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgvQuizParticipants
            // 
            this.dgvQuizParticipants.AllowUserToAddRows = false;
            this.dgvQuizParticipants.AllowUserToDeleteRows = false;
            this.dgvQuizParticipants.AllowUserToResizeRows = false;
            this.dgvQuizParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuizParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuizParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmParticipantNickname,
            this.clmTimeTaken,
            this.clmCorrectPercentage});
            this.dgvQuizParticipants.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQuizParticipants.Location = new System.Drawing.Point(0, 144);
            this.dgvQuizParticipants.MultiSelect = false;
            this.dgvQuizParticipants.Name = "dgvQuizParticipants";
            this.dgvQuizParticipants.ReadOnly = true;
            this.dgvQuizParticipants.RowHeadersVisible = false;
            this.dgvQuizParticipants.Size = new System.Drawing.Size(784, 317);
            this.dgvQuizParticipants.TabIndex = 9;
            // 
            // clmParticipantNickname
            // 
            this.clmParticipantNickname.HeaderText = "ParticipantNickname";
            this.clmParticipantNickname.Name = "clmParticipantNickname";
            this.clmParticipantNickname.ReadOnly = true;
            // 
            // clmTimeTaken
            // 
            this.clmTimeTaken.HeaderText = "TimeTaken";
            this.clmTimeTaken.Name = "clmTimeTaken";
            this.clmTimeTaken.ReadOnly = true;
            // 
            // clmCorrectPercentage
            // 
            this.clmCorrectPercentage.HeaderText = "CorretPercentage";
            this.clmCorrectPercentage.Name = "clmCorrectPercentage";
            this.clmCorrectPercentage.ReadOnly = true;
            // 
            // FormQuizReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvQuizParticipants);
            this.Controls.Add(this.lblTotalParticipant);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCorrectPercentage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAverageTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbQuiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQuizReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizinAja - Online Quiz Platform";
            this.Load += new System.EventHandler(this.FormQuizReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbQuiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAverageTime;
        private System.Windows.Forms.Label lblCorrectPercentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalParticipant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvQuizParticipants;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParticipantNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCorrectPercentage;
    }
}