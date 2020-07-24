using Hands_On_Insert_Record_EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            lambdademoEntities db = new lambdademoEntities();

            var product = new Product()
            {
                Name = "Tivi 3",
                Price = 12,
                Quantity = 3,
                CreationDate = DateTime.Now,
                Status = true,
                CategoryId = 3
            };

            db.Products.Add(product);

            Console.WriteLine("Result: " + db.SaveChanges());

            Console.ReadLine();
        }
    }
}