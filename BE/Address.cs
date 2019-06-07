using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    /**
     * The Address struct holds a City, Street name, and street Number of an address.
     */ 
    public struct Address
    {
        public String Street { get; set; }
        public int Number { get; set; }
        public String City { get; set; }

        public override string ToString()
        {
            String result = "";
            result += Number;
            result += " " + Street + ", ";
            result += City;
            return result;
        }
    }
}
