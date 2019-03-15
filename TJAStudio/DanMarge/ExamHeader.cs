using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJAStudio.DanMarge
{
    public partial class ExamHeader : UserControl
    {
        public ExamHeader()
        {
            InitializeComponent();
            ComboBox_Condition.SelectedIndex = 0;
            ComboBox_Scope.SelectedIndex = 0;
        }
    }
}
