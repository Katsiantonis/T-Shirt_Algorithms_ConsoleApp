using Assignment4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Strategies.ProductVariationStrategy
{
    interface VariationStrategy
    {
        void Cost(Shirt shirt);
    }
}
