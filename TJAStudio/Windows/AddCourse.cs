using System;
using System.Windows.Forms;

namespace TJAStudio
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        public AddCourse(string name)
        {
            InitializeComponent();
            TextBox_Name.Text = name;
            TextBox_Name.ReadOnly = true;
        }


        private void Add_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
