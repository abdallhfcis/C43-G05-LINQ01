using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            #region Restriction Operators
            #region 1.Find all products that are out of stock.
            //var Result = ProductsList.Where(N => N.UnitsInStock == 0);
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductsList.Where(N => N.UnitsInStock > 0 && N.UnitPrice > 3.00M);
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result=Arr.Where((N,I) => N.Length < I ).ToList();
            //foreach (var N in Result) {
            //    Console.WriteLine(N);
            //}

            #endregion
            #endregion

            #region Element Operators
            #region 1. Get first Product out of Stock
            //var Result=ProductsList.FirstOrDefault(N => N.UnitsInStock ==0);
            //Console.WriteLine(Result);
            #endregion
            #region 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductsList.FirstOrDefault(N => N.UnitPrice > 1000);
            //Console.WriteLine(Result != null ?  Result : "Not Found");
            #endregion
            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int [] Result=Arr.Where(x => x > 5).ToArray();
            //Console.WriteLine(Result[1]);

            #endregion

            #endregion

            #region Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result=Arr.Count(X => X%2 == 1);
            //Console.WriteLine(Result);
            #endregion

            #region 2. Return a list of customers and how many orders each has.
            //var Result = CustomersList.Select((N,NumberOfOrders) => new { N.CustomerName,NumberOfOrders= N.Orders.Length });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Return a list of categories and how many products each has
            //var Result = ProductsList.GroupBy(X => X.Category)
            //                        .Select((N, Count) => new{N.Key, Count = N.Count() });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Sum());
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt

            //foreach (var item in DictionaryArray)
            //{
            //    Console.WriteLine(item.Count());
            //}
            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int ShortesttLength=DictionaryArray.Min(x => x.Length);
            //Console.WriteLine($"Short Length ={ShortesttLength}");
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt 
            //int LongestLength =DictionaryArray.Max(x => x.Length);
            //Console.WriteLine($"Longest Length ={LongestLength}");
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt 
            //int AverageLength =(int)DictionaryArray.Average(x => x.Length);
            //Console.WriteLine($"Average Lenght  ={AverageLength}");
            #endregion
            #endregion

            #region Ordering Operators
            #region 1. Sort a list of products by name

            //ProductsList.Sort();

            //foreach (var item in ProductsList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.TOLower(Arr);

            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var Result = ProductsList.OrderByDescending(X => X.UnitsInStock);
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.OrderBy(X => X.Length).ThenBy(X => X).ToArray();
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}
            #endregion
            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Resutlt=Arr.OrderBy(X => X.Length).ThenBy(X => X, StringComparer.OrdinalIgnoreCase).ToArray();

            //foreach (var item in Resutlt)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest

            //var Result = ProductsList.OrderBy(X => X.Category).ThenByDescending(X => X.UnitPrice);

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion
            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(X => X.Length).ThenByDescending(X => X, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var Product in Result)
            //{
            //    Console.WriteLine(Product);
            //}

            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result = Arr.Where(name => name.Length > 1 && name[1] == 'i').Reverse().ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion










        }
    }
}
