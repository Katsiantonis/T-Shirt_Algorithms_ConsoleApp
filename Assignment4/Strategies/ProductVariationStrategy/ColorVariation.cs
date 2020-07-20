using Assignment4.Entities;
using Assignment4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Strategies.ProductVariationStrategy
{
    class ColorVariation : VariationStrategy
    {
        public void Cost(Shirt shirt)
        {
            switch (shirt.Color)
            {
                case Color.BLUE: shirt.Price += 18.99m; break;
                case Color.GREEN: shirt.Price += 17.99m; break;
                case Color.INDIGO: shirt.Price += 18.99m; break;
                case Color.ORANGE: shirt.Price += 16.99m; break;
                case Color.RED: shirt.Price += 19.99m; break;
                case Color.VIOLET: shirt.Price += 17.99m; break;
                case Color.YELLOW: shirt.Price += 18.99m; break;
                default: break;
            }
        }
    }
}
