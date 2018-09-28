using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employees
    {
        private int id, salary;
        private string name, design;

        public void setEmployees(int id,string name,string design,int salary)
        {
            this.id = id;
            this.name = name;
            this.design = design;
            this.salary = salary;
        }

        public void getEmployees()
        {
            Console.WriteLine("{0} - {1} - {2} - {3} ",id,name,design,salary);
        }
    }
}
