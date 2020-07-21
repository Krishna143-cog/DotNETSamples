using Hands_ON_DATABASEFIRST;
using System;
using System.Linq;

namespace DatabaseFirstDemo
{

    class Program
    {

        static void Main(string[] args)
        {

            using (var db = new BookStoreEntities())
            {

                var query = from b in db.Books
                            orderby b.Title
                            select b;

                Console.WriteLine("All books in the database:");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Title);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}