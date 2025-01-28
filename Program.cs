using System.Linq;
using C43_G02_LINQ0;
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
    }
}