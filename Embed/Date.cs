using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embed
{
 


    public class Date
    {
        private int m_year;
        private int m_month;
        private int m_day;
        public Date()
        {
           
        }
        public Date(int year, int month, int day)
        {
           m_year = year;
            m_month = month;    
            m_day = day;
        }
        public override string ToString()
        {
            return $"{m_year}年{m_month}月{m_day}日";
        }


    }
}
