using System;
using System.Windows.Forms;

namespace TJAStudio.Windows
{
    public partial class BPMChanger : Form
    {
        public BPMChanger()
        {
            InitializeComponent();
        }

        public BPMChanger(double defaultAmount)
            : this()
        {
            Num_Amount.Value = Convert.ToDecimal(defaultAmount);
        }

        private void Button_Insert_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
            Close();
        }
    }
}