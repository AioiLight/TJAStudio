namespace TJAStudio.DanMarge
{
    public class ExamCondition
    {
        public enum ExamConditions
        {
            None,
            Gauge,
            Perfect,
            Good,
            Bad,
            Score,
            Drumroll,
            Hits,
            Combo,
        }

        public static string ExamConditionToString(ExamConditions condition)
        {
            switch (condition)
            {
                case ExamConditions.Gauge:
                    return "g";

                case ExamConditions.Perfect:
                    return "jp";

                case ExamConditions.Good:
                    return "jg";

                case ExamConditions.Bad:
                    return "jb";

                case ExamConditions.Score:
                    return "s";

                case ExamConditions.Drumroll:
                    return "r";

                case ExamConditions.Hits:
                    return "h";

                case ExamConditions.Combo:
                    return "c";

                default:
                    return "g";
            }
        }
    }

    public class ExamScope
    {
        public enum ExamScopes
        {
            More,
            Less
        }

        public static string ExamScopeToString(ExamScopes scope)
        {
            switch (scope)
            {
                case ExamScopes.More:
                    return "m";

                case ExamScopes.Less:
                    return "l";

                default:
                    return "m";
            }
        }
    }
}