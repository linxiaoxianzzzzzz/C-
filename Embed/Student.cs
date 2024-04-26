using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embed
{
    public class Student :IDisposable
    {
        private string m_name;
        private Date m_BirthDay;
        public Student() { 
        m_name = "John";
            m_BirthDay = new Date();
        }
        public Student(string name, int y,int m,int d )
        {
            m_name = name;
          m_BirthDay= new Date(y,m,d);
        }

        public void Dispose()
        {
           //回收
        }

        public override string ToString()
        {
            return $"姓名:{m_name}生日:{m_BirthDay}";
        }
      

    }
}
