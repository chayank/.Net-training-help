using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
   class calc
    {
        public static int big(int a,int b)
        {
            if (a > b) return a;
            else return b;
        }
    }
    class Program
    {

        public delegate void delcal(string a);
        static void Main()
        {

            /*      

            Employeex e1 = new Employeex { id = 1, ename = "kiran", job = "trainer", salary = 12333 };
           
            Employeex e2 = new Employeex { id = 2, ename = "chayank", job = "cme dir", salary = 6000 };
            Employeex e3 = new Employeex { id = 3, ename = "arihant", job = "cme dir", salary = 5000 };
            
            Employeex e4 = new Employeex { id = 16, ename = "paraj", job = "crc", salary = 30000 };
            
            
            
             employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
          
            //annonymous insertion
            
            Employeex dt = new Employeex();
            dt.setemp();


            //obtain data src


            var query = from item in dt.employees orderby item.ename  where item.ename.Length==5 select item;

            foreach(Employeex item in query)
            {
                Console.WriteLine(item.id + " " +item.ename+" "+ item.job + " " + item.salary);
            }
            */
            Employeex dt = new Employeex();
            dt.setemp();

          










            Console.ReadKey();


        }
      
    }

    
}


//debug refers to step by step execution
//run the project