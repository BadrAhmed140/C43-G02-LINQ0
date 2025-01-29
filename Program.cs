using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using C43_G02_LINQ0;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static C43_G02_LINQ0.ListGenerator;
internal class Program
{
    private static void Main(string[] args)
    {
        #region demo

        //List<int> Numbers = new List<int> {1,2,3,4,5,6,7,9};
        //List<int> OddNumbers=Numbers.Where((N)=>N%2 !=0).ToList();
        //foreach (int n in OddNumbers)
        //{
        //    Console.WriteLine(n);
        //}

        #region fluent syntax
        //static 
        //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 9 };
        //List<int> OddNumbers = Enumerable.Where(Numbers, (N) => N % 2 != 0).ToList();
        //foreach (int n in OddNumbers)
        //{
        //    Console.WriteLine(n);
        //}
        //extentio method 
        //List<int> Numbers = new List<int> {1,2,3,4,5,6,7,9};
        //List<int> OddNumbers=Numbers.Where((N)=>N%2 !=0).ToList();
        //foreach (int n in OddNumbers)
        //{
        //    Console.WriteLine(n);}

        #endregion
        #region Query syntex
        //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 9 };
        //var OddNumbers = from N in Numbers where N%2 != 0 select N;
        //foreach (int n in OddNumbers)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region Execution ways
        //deferred
        //List<int> Numbers = new List<int> (10){ 1, 2, 3, 4, 5, 6, 7, 9 };
        //var OddNumbers = Numbers.Where((N) => N % 2 != 0);
        //Numbers.AddRange(new int[] {10,11,12,13,14});
        //foreach (int n in OddNumbers)
        //{
        //    Console.WriteLine(n);
        //}

        //immediate
        //  List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 9 };
        //List<int> OddNumbers = Numbers.Where((N) => N % 2 != 0).ToList();
        //  Numbers.AddRange(new int[] { 10, 11, 12, 13, 14 });
        //  foreach (int n in OddNumbers)
        //  {
        //      Console.WriteLine(n);
        //  }
        #endregion
        #region filtration [Restrication] operators - where 
        #region get products out of stock 
        //var Result = ProductList.Where(p => p.UnitsInStock == 0);
        //var Result = from p in ProductList
        //         where p.UnitsInStock == 0 
        //         select p;
        //foreach (var n in Result)

        //{   Console.WriteLine(n);
        //}
        #endregion
        #region  Get products in stock and in category of Meat/Poultry
        //var Result = ProductList.Where(p => p.UnitsInStock == 0 && p.Category=="Meat/Poultry");
        //var Result = from p in ProductList
        //             where p.UnitsInStock == 0 && p.Category == "Meat/Poultry"
        //             select p;
        //foreach (var n in Result)

        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region  Get products out of stock in first 10 elements
        //var Result = ProductList.Where((p,I) => I<10 && p.UnitsInStock == 0);
        ////no found in query 

        //foreach (var n in Result)

        //{
        //    Console.WriteLine(n);
        //}
        #endregion

        #endregion
        #region Transformation operators[select - select many]
        #region select product name 
        //var Result = ProductList.Select(p=>p.ProductName);
        ////Query syntex
        //var Result =from p in ProductList 
        //            select p.ProductName;
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region select custumer name 
        // var Result = CustomerList.Select(c => c.CustomerName);
        //Query syntex
        //var Result = from p in CustomerList
        //             select p.CustomerName;
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region  3 ] Select customer orders
        //var Result = CustomerList.SelectMany(c => c.Orders);
        //var Result=from c in CustomerList
        //           from o in c.Orders
        //           select o;
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region select product id and product name 
        // var Result = ProductList.Select(p => new Product() { ProductID = p.ProductID, ProductName = p.ProductName });
        //var Result = from p in ProductList
        //             select new 
        //             {
        //                 productid = p.ProductID,
        //                 productname = p.ProductName,
        //             };
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region Select product in stock and apply discount 10 % on its price
        //var Result = ProductList.Where(p => p.UnitsInStock > 0)
        //    .Select(p => new { productid = p.ProductID, productname = p.ProductName,
        //    oldPrice = p.UnitPrice,
        //        newPrice = p.UnitPrice - (p.UnitPrice * 0.1M)
        //    });
        //query 
        //var Result = from p in ProductList
        //             where p.UnitsInStock > 0
        //             select new
        //             {
        //                 productid = p.ProductID,
        //                 productname = p.ProductName,
        //                    oldPrice = p.UnitPrice,
        //                         newPrice = p.UnitPrice - (p.UnitPrice * 0.1M)
        //             };
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region indexed select 
        //var Result = ProductList.Where(p => p.UnitsInStock > 0)
        //    .Select((p,i) => new
        //    {
        //        Index = i,
        //        productid = p.ProductID,
        //        productname = p.ProductName,
        //        oldPrice = p.UnitPrice,
        //        newPrice = p.UnitPrice - (p.UnitPrice * 0.1M)
        //    });
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #endregion
        #region Ording operators[Ascending ,Desending ,Reverse ,then by , thenByDescending ]
        #region  Get Products Ordered By Price Asc
        //var Result = ProductList.OrderBy(p => p.UnitPrice);
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}

        //comperable 
        //var Result = ProductList.Order();
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region 2 ] Get Products Ordered By Price Desc
        //var Result = ProductList.OrderByDescending(p => p.UnitPrice);
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        //query 
        //var Result = from p in ProductList
        //             orderby p.UnitPrice descending
        //             select p;
        //         foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region 3 ] Get Products Ordered By Price Asc and Number Of Items In Stock
        //var Result = ProductList.OrderBy(p => p.UnitPrice).ThenBy(p=>p.UnitsInStock);
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #region reverse
        //var Result = ProductList.Where(p => p.UnitsInStock == 0).Reverse();
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion
        #endregion
        #endregion
        #region assignment 
        #region LINQ - Restriction Operators
        ////1. Find all products that are out of stock.
        // var Result = ProductList.Where(p => p.UnitsInStock == 0);
        ////2.Find all products that are in stock and cost more than 3.00 per unit
        // var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
        ////3. Returns digits whose name is shorter than their value
        //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //var Result = arr.Where((name, index) => name.Length < index);
        #endregion
        #region LINQ - Ordering Operators

        // 1. Sort a list of products by name
        ////var Result = ProductList.OrderBy(p => p.ProductName);
        //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
        ////          string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        ////var Result = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
        //3. Sort a list of products by units in stock from highest to lowest.
        //// var Result = ProductList.OrderByDescending(p => p.UnitsInStock);
        //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
        ////string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        ////var Result = Arr.OrderBy(d => d.Length).ThenBy(d => d);
        //5. Sort first by word length and then by a case-insensitive sort of the words in an array.
        ////string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        ////var Result = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
        //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
        ////var Result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
        //7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
        ////string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        ////var Result = Arr.OrderBy(p => p.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
        // 8. Create a list of all digits whose second letter is 'i', reversed from original order
        ////string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        ////var Result = Arr.Where(d => d[1] == 'i').Reverse();

        #endregion
        #region LINQ – Transformation Operators
        //1. Return a sequence of just the names of a list of products.
        ////var Result = ProductList.Select(p => p.ProductName);
        //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
        ////string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        ////var Result = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
        //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
        ////var Result = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice });
        //4. Determine if the value of ints in an array match their position in the array.
        ////int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        ////var Result = Arr.Select((p, i) => new { p, match = p == i });
        //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
        ////int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        ////int[] numbersB = { 1, 3, 5, 7, 8 };

        ////var Result = from a in numbersA
        ////                  from b in numbersB
        ////                  where a < b
        ////                  select new { A = a, B = b };

        #endregion
        #region Use ListGenerators.cs & Customers.xml
        //6. Select all orders where the order total is less than 500.00.
        ////var Result = ListGenerator.CustomerList.Where(p => p.Orders.Any(o => o.Total < 500.00m));
        // 7. Select all orders made in 1998 or later
        ////    var Result = CustomerList
        ////.SelectMany(p => p.Orders) 
        ////.Where(o => o.OrderDate >= new DateTime(1998, 1, 1)); 


        #endregion
        //foreach (var n in Result)
        //{
        //    Console.WriteLine(n);
        //}
        #endregion

    }
}