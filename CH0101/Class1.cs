using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0101
{
    internal class Employee
    {
       public  decimal Salary;
       public  String Ename;
      public void  PrintData() {
        Console.WriteLine("姓名"+this.Ename+"薪水:"+this.Salary);
        }
        public void ShowError() {
            if (this.Salary > 40000 || this.Salary < 20000) {
                Console.WriteLine("ERROR");
            }
        }

    }
}
