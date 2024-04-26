using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Bank
    {
        public Account CreateAccount(string id)
        {
            //檢查ID
            return new Account();
        }
    }
}
