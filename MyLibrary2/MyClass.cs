using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary2
{
    public static class MyClass
    {
       

        public static  T Abs<T>(T value)
        {
            dynamic v = value;
            return v>= 0 ? value : -v;

        }
    }
}
