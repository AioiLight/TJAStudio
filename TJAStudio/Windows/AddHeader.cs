using System;
using System.Windows.Forms;

namespace TJAStudio
{
    public partial class AddHeader : Form
    {
        public AddHeader()
        {
            InitializeComponent();
        }

        public AddHeader(string name)
        {
            InitializeComponent();
            TextBox_Name.Text = name;
            TextBox_Name.ReadOnly = true;
        }

        public AddHeader(string name, string parameter)
        {
            InitializeComponent();
            TextBox_Name.Text = name;
            TextBox_Parameter.Text = parameter;
            TextBox_Name.ReadOnly = true;
            TextBox_Parameter.ReadOnly = true;
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