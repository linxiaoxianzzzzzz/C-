using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inherit
{
    public class Sales :Employee
    {
        private int m_bonus;
        private int m_Commi;

        public Sales() { }
        public Sales(string name, int bonus, int commi) : base(name)
        {
            m_bonus = bonus;
            m_Commi = commi;    
        }
        public override int GetPay()
        {
            return m_bonus+m_Commi;
        }


    }
   
    
}
