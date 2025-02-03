namespace LKS_Quiz.WinForm
{
    partial class FormJoinQuiz
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuizCode = new System.Windows.Forms.TextBox();
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(83, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Quiz Code:";
            // 
            // tbQuizCode
            // 
            this.tbQuizCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuizCode.Location = new System.Drawing.Point(74, 90);
            this.tbQuizCode.Name = "tbQuizCode";
            this.tbQuizCode.Size = new System.Drawing.Size(241, 20);
            this.tbQuizCode.TabIndex = 1;
            // 
            // tbNickname
            // 
            this.tbNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNickname.Location = new System.Drawing.Point(74, 200);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(241, 20);
            this.tbNickname.TabIndex = 2;
            this.tbNickname.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(91, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Nickname:";
            // 
            // btnJoin
            // 
            this.btnJoin.AutoSize = true;
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnJoin.Location = new System.Drawing.Point(124, 315);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(241, 27);
            this.btnJoin.TabIndex = 503;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.label3);
            this.panelInput.Controls.Add(this.tbQuizCode);
            this.panelInput.Controls.Add(this.tbNickname);
            this.panelInput.Controls.Add(this.label4);
            this.panelInput.Location = new System.Drawing.Point(50, 45);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(395, 264);
            this.panelInput.TabIndex = 507;
            // 
            // FormJoinQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.panelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormJoinQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJoinQuiz";
            this.Load += new System.EventHandler(this.FormJoinQuiz_Load);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuizCode;
        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Panel panelInput;
    }
}