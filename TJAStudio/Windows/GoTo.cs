using System;
using System.Windows.Forms;

namespace TJAStudio
{
    public partial class GoTo : Form
    {
        public GoTo(int maxLine)
        {
            InitializeComponent();
            this.Label_Range.Text = String.Format("({0} - {1})", 1, maxLine);
            this.Num.Minimum = 1;
            this.Num.Maximum = maxLine;
        }

        private void Button_GoTo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void GoTo_Load(object sender, EventArgs e)
        {
            //Num.Focus();
        }

        private void GoTo_Shown(object sender, EventArgs e)
        {
            Num.Focus();
        }
    }
}
