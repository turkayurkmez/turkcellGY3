namespace ExtensionMethods
{
    public static class Extensions
    {
        public static double GetSquare(this int value) => Math.Pow(value, 2);

        public static string MergeWords(this string value)
        {
            return value.Replace(" ", "");
        }
    }
}
