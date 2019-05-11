using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJAStudio.Windows
{
    public partial class MeasureChanger : Form
    {
        public MeasureChanger()
        {
            InitializeComponent();
        }

        public MeasureChanger(double child, double mother)
            : this()
        {
            Num_Child.Value = Convert.ToDecimal(child);
            Num_Mother.Value = Convert.ToDecimal(mother);
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
