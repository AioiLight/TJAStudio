﻿using System;
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
    public partial class Editor : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public Editor(Sgry.Azuki.Document doc, Course course)
        {
            InitializeComponent();
            TextEditor.Document = doc;
            Text = course.Name;
        }
    }
}
