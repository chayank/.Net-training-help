using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employeex
    {
        public int id { get; set; }
        public string ename { get; set; }
        public string job { get; set; }
        public int salary { get; set; }
        public List<Employeex> employees;
        public void setemp()
        {
            this.employees = new List<Employeex>() {
                new Employeex { id = 1, ename = "chayank", job = "cme dir", salary = 6000 },
                new Employeex { id = 2, ename = "kiran", job = "trainer", salary = 12333 },
                new Employeex { id = 3, ename = "arihant", job = "cme dir", salary = 5000 },
                new Employeex { id = 4, ename = "paraj", job = "crc", salary = 30000 },
                new Employeex { id = 5, ename = "manju", job = "trainer", salary = 12333 },
                new Employeex { id = 6, ename = "sohan", job = "cme dir", salary = 5000 },
                new Employeex { id = 7, ename = "suresh", job = "crc", salary = 30000 },
                new Employeex { id = 8, ename = "surabhi", job = "trainer", salary = 12333 },
                new Employeex { id = 9, ename = "yogish", job = "cme dir", salary = 5000 },
                new Employeex { id = 10, ename = "shwetha", job = "crc", salary = 30000 },
                new Employeex { id = 11, ename = "nikhik", job = "trainer", salary = 12333 },
                new Employeex { id = 12, ename = "sachin", job = "cme dir", salary = 5000 },
                new Employeex { id = 13, ename = "sathish", job = "crc", salary = 30000 },
                new Employeex { id = 14, ename = "shobhan", job = "trainer", salary = 12333 },
                new Employeex { id = 15, ename = "ulsoor", job = "cme dir", salary = 5000 },
               


                };

            
        }

        public void addemp(Employeex e)
        {
            this.employees.Add(e);
        }

        public Employeex searchbyid(int n)
        {
           
            foreach(Employeex x in this.employees)
            {
                if (n == x.id) return x;
            }

            return null;
        }

        public void delete(int n)
        {
            try{
                foreach (Employeex x in this.employees)
                {
                    if (n == x.id) this.employees.Remove(x);
                }
            }catch(Exception e)
            {

            }
            

        }

        public void update(int n,Employeex e)
        {
            
            for(int i=0; i < employees.Count(); i++)
            {
                if (employees[i].id == n)
                {
                    employees[i] = e;
                }
            }
       
        }
        
    }
}
