namespace LKS_Quiz.Util
{
    partial class UserControlQuestionButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackColor = System.Drawing.Color.LightGray;
            this.btnQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnQuestion.Location = new System.Drawing.Point(0, 0);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(150, 150);
            this.btnQuestion.TabIndex = 0;
            this.btnQuestion.Text = "Question Number";
            this.btnQuestion.UseVisualStyleBackColor = false;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // UserControlQuestionButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuestion);
            this.Name = "UserControlQuestionButton";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnQuestion;
    }
}
