using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Objects_HandsOn
{
    class Linq_ObjectsDemo
    {
        public static void Main()
        {
            string[] Languages = { "C", "C++", "JAVA","C#","python",
                    "SmallTalk","Cobol","Ruby","vb.net","C#","C++","C#"};

            var selectResult = from s in Languages
                               select s;

            foreach (var name in selectResult)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-------------------------");
            var query = from l in Languages
                       where l == "Ruby"
                       select l;
            foreach (string s in query)
            {
                Console.WriteLine("The record is"+ "  "+ s.ToString());
            }
            var query1 = from l in Languages
                       orderby l descending
                       select l;
            Console.WriteLine("-------------------------");
            foreach (string s in query1)
            {
                Console.WriteLine("The sorted records are " + "  " + s.ToString());
            }
            Console.WriteLine("-------------------------");
            var query2 = from l in Languages
                                where l.StartsWith("C")
                                select l;
            foreach (string s in query2)
            {
                Console.WriteLine("The  records are " + "  " + s.ToString());
            }
            Console.WriteLine("-------------------------");
            var query3 = Languages.Distinct();

            foreach (var str in query3)
                Console.WriteLine(str);
            Console.WriteLine("-------------------------");
            var newList = Languages.Skip(2);

            foreach (var str in newList)
                Console.WriteLine(str);
            Console.WriteLine("-------------------------");
            var totalLanguages = Languages.Count();

            Console.WriteLine("Total Languages: {0}", totalLanguages);
            Console.WriteLine("-------------------------");
            bool result = Languages.Contains("asp");

            Console.WriteLine(result);
            Console.WriteLine("-------------------------");
            Console.WriteLine("2nd Element in languages: {0}",Languages.ElementAt(1));
            Console.WriteLine("1st Element in languages: {0}", Languages.First());
            Console.WriteLine("last Element in languages: {0}", Languages.Last());
            Console.ReadLine();
        }
    }
}
