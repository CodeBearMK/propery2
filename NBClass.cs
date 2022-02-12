using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propery2
{
    internal class NBClass
    {
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0) value = 0;
                price = value;
            }
        }
    }
}
