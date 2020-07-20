using Assignment4.Entities;
using Assignment4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Strategies.ProductVariationStrategy
{
    class SizeVariation : VariationStrategy
    {
        public void Cost(Shirt shirt)
        {
            switch (shirt.Size)
            {
                case Size.XS: shirt.Price += 1.8m; break;
                case Size.S: shirt.Price += 1.9m; break;
                case Size.M: shirt.Price += 2.1m; break;
                case Size.L: shirt.Price += 2.2m; break;
                case Size.XL: shirt.Price += 2.3m; break;
                case Size.XXL: shirt.Price += 2.4m; break;
                default: break;
            }
        }
    }
}
