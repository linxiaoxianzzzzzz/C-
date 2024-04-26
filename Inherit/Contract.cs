using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    public class Contract :Employee 
    {
        private int m_Rate;
        private int m_Hours;
        public Contract()
        {
            m_Rate = 150;
        }

        public Contract(string name,int rate, int hours):base(name) 
        {
            m_Rate = rate;
            m_Hours = hours;
        }
        public override int GetPay()
        {
            return m_Rate * m_Hours;
        }

    }
}
