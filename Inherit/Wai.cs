using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    public class Wai :Contract
    {
        private string m_HomeMame;
        public Wai() { }
        public Wai( string name,  string homeMame,int hour ,int rate):base( name,rate,hour)
        {
            m_HomeMame = homeMame;
        }
        public override int GetPay()
        {
            return base.GetPay() / 2;
        }
        public override string GetName()
        {
            return $"{base.GetName()}({m_HomeMame})";
        }
    }
}
