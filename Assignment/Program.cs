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







        }
    }
}
