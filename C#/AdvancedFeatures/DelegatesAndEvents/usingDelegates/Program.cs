// See https://aka.ms/new-console-template for more information

using usingDelegates;

List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var helper = new FilterHelper();
//.net 1.1 
//var filtered1 = helper.Filter(numbers, isEven);
// .net 2.0
//var filtered2 = helper.Filter(numbers, delegate (int n) { return n % 2 == 1; });
// .net 3.5
var filtered3 = helper.Filter(numbers, p => p > 5);


alternateShowNumbers(filtered3);

Console.WriteLine("Hello, World!");


void showNumbers(List<int> filtered)
{
    foreach (var item in filtered)
    {
        Console.WriteLine(item);
    }
}

void alternateShowNumbers(List<int> numbers)
{
    numbers.ForEach(n => Console.WriteLine(n));
}

bool isEven(int number)
{
    return number % 2 == 0;
}
