using System;

//ref link:https://www.youtube.com/watch?v=iI9sfsMIZE8&t=114s
//

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "kulpot";
            //string cap = name.Capitalize();
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var average = numbers.Average();

            int[] ints = new[] { 1, 2, 3, };
            var averageInts = ints.Average();
        }
    }
}

public static class IEnumeralbeExtensions
{
    public static double Average(this IEnumerable<int> source)
    {
        if(source == null)
            throw new ArgumentNullException(nameof(source));

        return (double)source.Sum() / source.Count();
    }
}

//public static class StringExtendions
//{
//    public static string Capitalize(this string input) // this -- keyword to turn methods to extension
//    {
//        if (string.IsNullOrEmpty(input))
//        {
//            return input;
//        }
//
//        return char.ToUpper(input[0]) + input.Substring(1);
//    }
//}