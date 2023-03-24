namespace ExtensionMethods
{
    public static class ExtensionSamples
    {
        public static double GetSquare(this int value) => Math.Pow(value, 2);

        public static int TotalWorkDays(this DateTime dateTime)
        {
            var startDate = new DateTime(dateTime.Year, 1, 1);
            var endDate = new DateTime(dateTime.Year, 12, 31);
            var totalWorkDays = 0;
            for (DateTime current = startDate; current <= endDate; current = current.AddDays(1))
            {
                if (!(current.DayOfWeek == DayOfWeek.Saturday || current.DayOfWeek == DayOfWeek.Sunday))
                {
                    totalWorkDays++;
                }
            }

            return totalWorkDays;
        }


        public static char NextChar(this Random random, bool isUpper = false)
        {
            var value = isUpper ? random.Next(65, 91) : random.Next(97, 123);
            return (char)value;
        }

        public static string NextString(this Random random, int length, bool isUpper = false)
        {
            string randomWord = string.Empty;
            for (int i = 0; i < length; i++)
            {
                randomWord += random.NextChar(isUpper);
            }
            return randomWord;
        }

    }
}
