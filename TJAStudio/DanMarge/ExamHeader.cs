using System;
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

        private void ComboBox_Condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumBoxSuggestion.SuggestConsiderExamCondition(NumBox_Req_Red, (ExamCondition.ExamConditions)ComboBox_Condition.SelectedIndex);
            NumBoxSuggestion.SuggestConsiderExamCondition(NumBox_Req_Gold, (ExamCondition.ExamConditions)ComboBox_Condition.SelectedIndex);
        }

        private void NumBox_Req_Red_ValueChanged(object sender, EventArgs e)
        {
            //NumBoxSuggestion.SuggestConsiderRedRequirement(NumBox_Req_Red, NumBox_Req_Gold, (ExamScope.ExamScopes)ComboBox_Scope.SelectedIndex);
        }

        private void NumBox_Req_Gold_ValueChanged(object sender, EventArgs e)
        {
            //NumBoxSuggestion.SuggestConsiderGoldRequirement(NumBox_Req_Gold, NumBox_Req_Red, (ExamScope.ExamScopes)ComboBox_Scope.SelectedIndex);
        }

        public override string ToString()
        {
            return ComboBox_Condition.SelectedIndex != 0 ? string.Format("{0},{1},{2},{3}",
                ExamCondition.ExamConditionToString((ExamCondition.ExamConditions)ComboBox_Condition.SelectedIndex),
                NumBox_Req_Red.Value,
                NumBox_Req_Gold.Value,
                ExamScope.ExamScopeToString((ExamScope.ExamScopes)ComboBox_Scope.SelectedIndex)
                ) : null;
        }
    }
}
