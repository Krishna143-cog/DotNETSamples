using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Hashtable_Hands_ON
{
    class Emp
    {
        public int empno { get; set; }
        public string ename { get; set; }
    }
    public class EmpDemo
    {
        public static void Main()
        {
           var eobj = new Emp { empno = 10, ename = "Rishi" };
           var eobj1 = new Emp { empno = 20, ename = "Krishna" };
           var  eobj2 = new Emp { empno = 30, ename = "Mithila" };
           
            Hashtable hobj = new Hashtable();
            hobj.Add(eobj, "Record1");
            hobj.Add(eobj1, "Record2");
            hobj.Add(eobj2, "Record2");
                     
            var records = new Dictionary<string,  Emp>();
            records.Add("1", eobj);
           records.Add("2",eobj1);
            records.Add("3", eobj2);

            foreach (string key in records.Keys)
            {
                Console.WriteLine("{0}, {1},{2}", key, records[key].empno, records[key].ename);
            }
            Console.ReadLine();
        }
      }
    }
