using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary2
{
    public struct Customer
    {
        public string m_Name;
        public int m_Age;
        public Customer(string name) {
        m_Name = name ;
            m_Age = 0;
        }
    }
}
