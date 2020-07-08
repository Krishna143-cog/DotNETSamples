using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraylistDemo
{
    class Courses
    {
        static void Main(string[] args)
        {
            ArrayList Courselist = new ArrayList();
            string course;
            int position;
            Console.WriteLine("Enter courses to Arraylist");
            Courselist.Insert(0, "BA");
            Courselist.Insert(1, "BArch");
            Courselist.Insert(2, "BTech");
            Courselist.Insert(3, "BSC");
            foreach (object obj in Courselist)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the position to add course in the list:");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the course to be added in list:");
            course = Console.ReadLine();
            Courselist.Insert(position, course);
            foreach (object obj in Courselist)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Enter the course to be deleted:");
            int coursedelete = Convert.ToInt32(Console.ReadLine());
            Courselist.RemoveAt(coursedelete);
            foreach (object obj in Courselist)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine("----------------------------");

            Console.WriteLine("After reversing elements");
            Courselist.Reverse();
            foreach (object obj in Courselist)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("After sorting");
            Courselist.Sort();
            foreach (object obj in Courselist)
            {
                Console.WriteLine("{0}", obj);
            }
            Console.WriteLine("----------------------------");
            //Displaying elements in ArrayList after deletion
          
            Console.ReadKey();

        }

     }
       
    }

   



                



