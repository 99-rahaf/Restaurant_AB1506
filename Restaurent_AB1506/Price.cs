using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AB1506
{
    class Price
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
