using System;

namespace Properties
{
    public class InvalidPriceEventArgs : EventArgs
    {
        public InvalidPriceEventArgs() { }
        public InvalidPriceEventArgs(float price) { 
        InvalidPrice=price;
        }

        public float InvalidPrice { get; }
    }
}