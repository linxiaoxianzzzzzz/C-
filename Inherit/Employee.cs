using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    public abstract class Employee :IComparable<Employee>
    {
        private string m_name;
        public virtual string GetName() { return m_name; }

        public abstract int GetPay();

        public int CompareTo(Employee other)
        {
            return other.GetPay().CompareTo(this.GetPay());

        }

        public Employee() { 
        m_name = "待填寫";
        }
        public Employee(string name)
        {
            m_name = name;
        }

    }
}
