using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Tarif
    {
        string destination;
        int price;
        public Tarif(string a, int b)
        {
            destination = a;
            price = b;
        }
        public string Destination()
        {
            return destination;
        }
        public int Price()
        {
            return price;
        }
    }
}
