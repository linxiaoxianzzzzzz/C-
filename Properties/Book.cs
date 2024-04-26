using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Book
    {
        public event 委派 InvalidPrice;


        private float m_price;

        public float Price {  
            get { return m_price; } 
            set {
                if (value > 0)
                    m_price = value;
                else 
                {
                    //事件
                    //InvalidPrice($"書籍價錢:{value}\t不合理!");
                    InvalidPrice(this,new InvalidPriceEventArgs(value));
                }
            }
        }
        private string m_name;

        public string Name
        {
            get { return m_name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                { m_name = value; }
            }
        }
        public string Author { get; set; }
        public string publisher { get; private set; }
        public string ISBN { get => iSBN; set => iSBN = value; }

        private string iSBN;
    }
}
