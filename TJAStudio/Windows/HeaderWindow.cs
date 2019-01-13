using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TJAStudio
{
    public partial class HeaderWindow : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public HeaderWindow()
        {
            InitializeComponent();
            Resized();
        }

        private void List_Resize(object sender, EventArgs e)
        {
            Resized();
        }

        private void Resized()
        {
            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
