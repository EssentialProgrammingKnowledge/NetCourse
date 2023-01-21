namespace ExtensionsInUse
{
    public static class Extensions
    {
        public static string AddExtraLine(this string text)
        {
            text += "\n------------------------------\n";
            return text;
        }

        public static string AddExtraLineWithText(this string str, string text)
        {
            str += $"\n---------------{text}---------------\n";
            return str;
        }
    }
}
