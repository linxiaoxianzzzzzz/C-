using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    public class FullTime : Employee
    {
        private int m_Salary;
        public FullTime() { 
        m_Salary = 28000;       //基本薪資
        }
        public FullTime(string name, int salary) :base(name) 
            {
            m_Salary = salary;        
        }
        public override int GetPay()
        {
            return m_Salary;
        }
    }
}
