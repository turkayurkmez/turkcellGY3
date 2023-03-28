namespace usingDelegates
{

    public class FilterHelper
    {
        //ilan verdiniz.
        //public delegate bool criteria(int item);
        public List<int> Filter(List<int> numbers, Func<int, bool> aday)
        {
            List<int> filtered = new();
            foreach (var number in numbers)
            {
                if (aday(number))
                {
                    filtered.Add(number);
                }
            }
            return filtered;

        }
    }
}
