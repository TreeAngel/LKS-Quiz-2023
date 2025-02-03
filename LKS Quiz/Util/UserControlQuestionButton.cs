using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_Quiz.Util
{
    public partial class UserControlQuestionButton : UserControl
    {
        public UserControlQuestionButton()
        {
            InitializeComponent();
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {

        }

        public void DoneColor()
        {
            btnQuestion.BackColor = Color.ForestGreen;
        }
    }
}
