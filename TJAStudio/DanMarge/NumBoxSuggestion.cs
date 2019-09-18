using System.Windows.Forms;

namespace TJAStudio.DanMarge
{
    public static class NumBoxSuggestion
    {
        public static void SuggestConsiderExamCondition(NumericUpDown numericUpDown, ExamCondition.ExamConditions examCondition)
        {
            void Set(int min, int max)
            {
                numericUpDown.Minimum = min;
                numericUpDown.Maximum = max;
            }
            switch (examCondition)
            {
                case ExamCondition.ExamConditions.Gauge:
                    Set(1, 100);
                    break;
                case ExamCondition.ExamConditions.Perfect:
                case ExamCondition.ExamConditions.Good:
                case ExamCondition.ExamConditions.Bad:
                case ExamCondition.ExamConditions.Score:
                case ExamCondition.ExamConditions.Drumroll:
                case ExamCondition.ExamConditions.Hits:
                case ExamCondition.ExamConditions.Combo:
                    Set(1, int.MaxValue);
                    break;
                default:
                    Set(1, 100);
                    break;
            }
        }
        
        public static void SuggestConsiderRedRequirement(NumericUpDown red, NumericUpDown gold, ExamScope.ExamScopes examScopes)
        {
            switch (examScopes)
            {
                case ExamScope.ExamScopes.More:
                    if(red.Value > gold.Value)
                    {
                        // ターゲットの数値が考慮するやつより大きかったら
                        red.Value = gold.Value;
                    }
                    break;
                case ExamScope.ExamScopes.Less:
                    if(red.Value < gold.Value)
                    {
                        gold.Value = red.Value;
                    }
                    break;
                default:
                    break;
            }
        }

        public static void SuggestConsiderGoldRequirement(NumericUpDown gold, NumericUpDown red, ExamScope.ExamScopes examScopes)
        {
            switch (examScopes)
            {
                case ExamScope.ExamScopes.More:
                    if (gold.Value < red.Value)
                    {
                        // ターゲットの数値が考慮するやつより大きかったら
                        gold.Value = red.Value;
                    }
                    break;
                case ExamScope.ExamScopes.Less:
                    if (gold.Value > red.Value)
                    {
                        red.Value = gold.Value;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
