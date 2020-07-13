using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_StoredProcedure
{
    class BookInfo
    {
        public static void Main()
        {
            int choice;
            Console.WriteLine("Enter the appropriate choice");
            choice = Convert.ToInt32(Console.ReadLine());
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-H48CAD4\SQLEXPRESS;Initial Catalog=vinit_shop;Integrated Security=True");
            switch (choice)
            {
                case 1:
                    
                    SqlCommand cmd = new SqlCommand("Insert_Book_Procedure", con);
                    try
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        int bookid;
                        Console.WriteLine("Enter Book id");
                        bookid = Convert.ToInt32(Console.ReadLine());
                        cmd.Parameters.Add(new SqlParameter("@bookid", bookid));
                        string book_name;
                        Console.WriteLine("Enter Book name");
                        book_name = Console.ReadLine();
                        cmd.Parameters.Add(new SqlParameter("@book_name", book_name));
                        string book_price;
                        Console.WriteLine("Enter Book price");
                        book_price = Console.ReadLine();
                        cmd.Parameters.Add(new SqlParameter("@price", book_price));
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            Console.WriteLine("Records Inserted Successfully.");
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.WriteLine("Error Generated. Details: " + e.ToString());
                    }
                    break;
                case 2:
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmdobj = new SqlCommand("Retrieve_Book_Procedure", con);
                            cmdobj.CommandType = CommandType.StoredProcedure;
                            int bookid;
                            Console.WriteLine("Enter Book id");
                            bookid = Convert.ToInt32(Console.ReadLine());
                            cmdobj.Parameters.Add(new SqlParameter("@bookid", bookid));
                            SqlDataReader dr = cmdobj.ExecuteReader();
                            while (dr.Read())
                            {
                                Console.WriteLine("Bookid : " + dr[0].ToString());
                                Console.WriteLine("Book name : " + dr[1].ToString());
                                Console.WriteLine("Price: " + dr[2].ToString());
                            }
                        }
                        catch (SqlException e)
                        {
                            Console.WriteLine("Error Generated. Details: " + e.ToString());
                        }
                        break;
                    }
            default:
                    Console.WriteLine("Incorrect option");
                    break;
            }

            Console.ReadLine();
        }
    }
}
