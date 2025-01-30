namespace LKS_Quiz.WinForm
{
    partial class FormMainUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.dgvUserQuiz = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuizName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuestionNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActionBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome";
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblFullname.Location = new System.Drawing.Point(14, 26);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(124, 26);
            this.lblFullname.TabIndex = 4;
            this.lblFullname.Text = "[Fullname]";
            // 
            // dgvUserQuiz
            // 
            this.dgvUserQuiz.AllowUserToAddRows = false;
            this.dgvUserQuiz.AllowUserToDeleteRows = false;
            this.dgvUserQuiz.AllowUserToResizeRows = false;
            this.dgvUserQuiz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserQuiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserQuiz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmQuizName,
            this.clmCode,
            this.clmDesc,
            this.clmQuestionNum,
            this.clmActionBtn});
            this.dgvUserQuiz.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvUserQuiz.Location = new System.Drawing.Point(254, 0);
            this.dgvUserQuiz.MultiSelect = false;
            this.dgvUserQuiz.Name = "dgvUserQuiz";
            this.dgvUserQuiz.ReadOnly = true;
            this.dgvUserQuiz.RowHeadersVisible = false;
            this.dgvUserQuiz.Size = new System.Drawing.Size(530, 461);
            this.dgvUserQuiz.TabIndex = 6;
            this.dgvUserQuiz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserQuiz_CellContentClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmQuizName
            // 
            this.clmQuizName.HeaderText = "Quiz Name";
            this.clmQuizName.Name = "clmQuizName";
            this.clmQuizName.ReadOnly = true;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Code";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmDesc
            // 
            this.clmDesc.HeaderText = "Description";
            this.clmDesc.Name = "clmDesc";
            this.clmDesc.ReadOnly = true;
            // 
            // clmQuestionNum
            // 
            this.clmQuestionNum.HeaderText = "NumberOfQuestion";
            this.clmQuestionNum.Name = "clmQuestionNum";
            this.clmQuestionNum.ReadOnly = true;
            // 
            // clmActionBtn
            // 
            this.clmActionBtn.HeaderText = "";
            this.clmActionBtn.Name = "clmActionBtn";
            this.clmActionBtn.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(19, 163);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Quiz";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.Location = new System.Drawing.Point(19, 204);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 35);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "View Quiz Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(19, 412);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 28);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUserQuiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizinAja - Online Quiz Platform";
            this.Load += new System.EventHandler(this.FormMainUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserQuiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.DataGridView dgvUserQuiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuizName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuestionNum;
        private System.Windows.Forms.DataGridViewButtonColumn clmActionBtn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLogout;
    }
}