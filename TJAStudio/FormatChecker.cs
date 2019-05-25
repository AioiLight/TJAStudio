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
    public partial class FormatChecker : Form
    {
        public FormatChecker()
        {
            InitializeComponent();
            Check(null);
        }

        private void Check(Simulator? sim)
        {
            List.Items.Clear();
            #region 共通ヘッダ
            var result = new ChartAnalyzer(Program.Project.CommonHeader).ToList();
            foreach (var item in result)
            {
                foreach (var checker in Charts.Headers.GetHeaders())
                {
                    if (item.Text.StartsWith(checker.Name))
                    {
                        try
                        {
                            checker.CheckFormat(item.Text);
                        }
                        catch (InvalidTJAFormatException e)
                        {
                            List.Items.Add(new ListViewItem(new string[] { Properties.SystemMessage.CommonHeader, e.Message }));
                        }
                        if (sim != null && !checker.IsAvailable(GetSingleSimulator(sim)))
                        {
                            List.Items.Add(new ListViewItem(new string[] { Properties.SystemMessage.CommonHeader, String.Format(Properties.SystemMessage.SimulatorDoesNotSupportHeader, checker.Name, ToStringSimulator(GetSingleSimulator(sim))) }));
                        }
                        break;
                    }
                }
            }
            #endregion
            #region 各コース
            foreach (var courses in Program.Project.Courses)
            {
                foreach (var item in new ChartAnalyzer(courses.Header).SelectByType(LineType.Header).ToList())
                {
                    foreach (var checker in Charts.Headers.GetHeaders())
                    {
                        if (item.Text.StartsWith(checker.Name))
                        {
                            try
                            {
                                checker.CheckFormat(item.Text);
                            }
                            catch (InvalidTJAFormatException e)
                            {
                                List.Items.Add(new ListViewItem(new string[] { courses.Name, e.Message }));
                            }
                            if (sim != null && !checker.IsAvailable(GetSingleSimulator(sim)))
                            {
                                List.Items.Add(new ListViewItem(new string[] { courses.Name, String.Format(Properties.SystemMessage.SimulatorDoesNotSupportHeader, checker.Name, ToStringSimulator(GetSingleSimulator(sim))) }));
                            }
                            break;
                        }
                    }
                }
                var courseText = new ChartAnalyzer(courses.Text).ToList(); // 行数を出したいため、SelectByTypeが使えない...!
                for (var i = 0; i < courseText.Count; i++) // 行数をどうしても出したいため、foreachが使えない...!
                {
                    if (courseText[i].Type == LineType.Command)
                    {
                        foreach (var checker in Charts.Commands.GetCommands())
                        {
                            if (courseText[i].Text.StartsWith("#" + checker.Name))
                            {
                                try
                                {
                                    checker.CheckFormat(courseText[i].Text);
                                }
                                catch (InvalidTJAFormatException e)
                                {
                                    List.Items.Add(new ListViewItem(new string[] { courses.Name + " : " + (i + 1), e.Message }));
                                }
                                if (sim != null && !checker.IsAvailable(GetSingleSimulator(sim)))
                                {
                                    List.Items.Add(new ListViewItem(new string[] { courses.Name + " : " + (i + 1), String.Format(Properties.SystemMessage.SimulatorDoesNotSupportCommand, checker.Name, ToStringSimulator(GetSingleSimulator(sim))) }));
                                }
                                break;
                            }
                        }
                    }
                }
                if (List.Items.Count == 0)
                {
                    List.Items.Add(new ListViewItem(new string[] { "-", Properties.SystemMessage.AllClear }));
                }
            }
            #endregion
        }

        private void FormatChecker_Resize(object sender, EventArgs e)
        {
            List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void FormatChecker_Load(object sender, EventArgs e)
        {
            Tool_Sims.SelectedIndex = 0;
        }

        private void Tool_Run_Click(object sender, EventArgs e)
        {
            Simulator? sim = null;
            switch (Tool_Sims.SelectedIndex)
            {
                case 0:
                    sim = null;
                    break;
                case 1:
                    sim = Simulator.Taikojiro;
                    break;
                case 2:
                    sim = Simulator.Taikojiro2;
                    break;
                case 3:
                    sim = Simulator.TJAPlayer2fPC;
                    break;
                case 4:
                    sim = Simulator.TJAPlayer3;
                    break;
                case 5:
                    sim = Simulator.TaikoDaijiro2;
                    break;
                case 6:
                    sim = Simulator.TaikoWeb_Bui;
                    break;
                default:
                    sim = null;
                    break;
            }
            Check(sim);
        }

        private Simulator GetSingleSimulator(Simulator? sim)
        {
            switch (sim)
            {
                case Simulator.Taikojiro:
                    return Simulator.Taikojiro;
                case Simulator.Taikojiro2:
                    return Simulator.Taikojiro2;
                case Simulator.TJAPlayer2fPC:
                    return Simulator.TJAPlayer2fPC;
                case Simulator.TJAPlayer3:
                    return Simulator.TJAPlayer3;
                case Simulator.TaikoDaijiro2:
                    return Simulator.TaikoDaijiro2;
                case Simulator.TaikoWeb_Bui:
                    return Simulator.TaikoWeb_Bui;
                default:
                    return Simulator.Taikojiro;
            }
        }
        private string ToStringSimulator(Simulator sim)
        {
            switch (sim)
            {
                case Simulator.Taikojiro:
                    return Properties.Simulator.Taikojiro;
                case Simulator.Taikojiro2:
                    return Properties.Simulator.Taikojiro2;
                case Simulator.TJAPlayer2fPC:
                    return Properties.Simulator.TJAPlayer2fPC;
                case Simulator.TJAPlayer3:
                    return Properties.Simulator.TJAPlayer3;
                case Simulator.TaikoDaijiro2:
                    return Properties.Simulator.TaikoDaijiro2;
                case Simulator.TaikoWeb_Bui:
                    return Properties.Simulator.TaikoWeb_Bui;
                default:
                    return Properties.Simulator.Taikojiro;
            }
        }
    }
}
