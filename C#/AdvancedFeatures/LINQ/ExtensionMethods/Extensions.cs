namespace ExtensionMethods
{
    public static class Extensions
    {
        public static double GetSquare(this int value) => Math.Pow(value, 2);

        public static string MergeWords(this string value)
        {
            return value.Replace(" ", "");
        }

        public static string GetPasswordStrength(this string value)
        {
            bool includeLetter = false;
            bool includeDigit = false;
            bool includeSymbol = false;

            value.ToCharArray().ToList().ForEach(c =>
            {
                if (char.IsLetter(c))
                {
                    includeLetter = true;
                }
                else if (char.IsDigit(c))
                {
                    includeDigit = true;
                }
                else
                {
                    includeSymbol = true;
                }
            });


            string result = string.Empty;
            if (includeLetter && includeDigit && includeSymbol)
            {
                result = "Güçlü";
            }
            else if ((includeLetter && includeDigit) && !includeSymbol)
            {
                result = "Orta";
            }
            else
            {
                result = "Zayıf";
            }

            return result;


        }

        public static char NextChar(this Random random, bool isUpper = false)
        {
            return !isUpper ? (char)(new Random().Next(97, 123)) : (char)(new Random().Next(65, 91));
        }

        public static string NextWord(this Random random, int length, bool isUpper = false)
        {
            string output = string.Empty;
            for (int i = 0; i < length; i++)
            {
                output += random.NextChar(isUpper);
            }
            return output;
        }
    }
}
