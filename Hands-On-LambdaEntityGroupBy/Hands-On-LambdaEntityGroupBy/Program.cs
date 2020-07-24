using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On_LambdaEntityGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            lambdademoEntities db = new lambdademoEntities();

            var groups = db.Products
                            .GroupBy(p => p.CategoryId)
                            .Select(g => new {
                                g.Key,
                                CountProduct = g.Count(),
                                SumQuantities = g.Sum(p => p.Quantity),
                                MinPrice = g.Min(p => p.Price),
                                MaxPrice = g.Max(p => p.Price),
                                AvgPrice = g.Average(p => p.Price)
                            })
                            .ToList();
            foreach (var group in groups)
            {
                Console.WriteLine("Category Id: " + group.Key);
                Console.WriteLine("Count Product: " + group.CountProduct);
                Console.WriteLine("Sum Quantities: " + group.SumQuantities);
                Console.WriteLine("Min Price: " + group.MinPrice);
                Console.WriteLine("Max Price: " + group.MaxPrice);
                Console.WriteLine("Avg Price: " + group.AvgPrice);
                Console.WriteLine("==========================");
            }
            Console.ReadLine();
        }
    }
}