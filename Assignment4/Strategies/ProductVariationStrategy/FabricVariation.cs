using Assignment4.Entities;
using Assignment4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Strategies.ProductVariationStrategy
{
    class FabricVariation : VariationStrategy
    {
        public void Cost(Shirt shirt)
        {
            switch (shirt.Fabric)
            {
                case Fabric.CASHMERE: shirt.Price += 8.40m; break;
                case Fabric.COTTON: shirt.Price += 9.80m; break;
                case Fabric.LINEN: shirt.Price += 5.60m; break;
                case Fabric.POLYESTER: shirt.Price += 4.90m; break;
                case Fabric.RAYON: shirt.Price += 3.50m; break;
                case Fabric.SILK: shirt.Price += 5.40m; break;
                case Fabric.WOOL: shirt.Price += 6.80m; break;
                default: break;
            }
        }
    }
}
