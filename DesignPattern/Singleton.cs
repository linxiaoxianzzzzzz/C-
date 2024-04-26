using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Singleton
    {
        static Singleton s=null;
        private Singleton() { }
        public static Singleton CreateObject() {
            if (s == null) {
            s=new Singleton();
            }
            return s;
        }
    }
}
