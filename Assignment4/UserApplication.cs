using Assignment4.Entities;
using Assignment4.Enums;
using Assignment4.Strategies.ProductVariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class UserApplication
    {
        public static void BuyShirt()
        {
            List<VariationStrategy> variations = new List<VariationStrategy>()
            {
                new ColorVariation(),
                new SizeVariation(),
                new FabricVariation()
            };

            Color color = ChooseColor();
            Fabric fabric = ChooseFabric();
            Size size = ChooseSize();

            Shirt shirt = new Shirt(color, size, fabric);
            Eshop eshop = new Eshop(variations);

            PaymentMethods paymentMethods = ChoosePaymentMethod();
            eshop.SelectPaymentMethod(paymentMethods);
            eshop.TotalCostTShirt(shirt);

        }

        private static PaymentMethods ChoosePaymentMethod()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Choose payment");
            var paymentMethods = Enum.GetValues(typeof(PaymentMethods));
            int counter = 0;
            foreach (var paymentMethod in paymentMethods)
            {
                Console.WriteLine("{0} --{1}", ++counter, paymentMethod);
            }

            return (PaymentMethods)Convert.ToInt32(Console.ReadLine());
        }


        private static Color ChooseColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose color");
            var colors = Enum.GetValues(typeof(Color));
            int counter = 0;
            foreach (var color in colors)
            {
                Console.WriteLine("{0} --{1}", ++counter, color);
            }

            return (Color)Convert.ToInt32(Console.ReadLine());
        }

        private static Fabric ChooseFabric()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose fabric");
            var fabrics = Enum.GetValues(typeof(Fabric));
            int counter = 0;
            foreach (var fabric in fabrics)
            {
                Console.WriteLine("{0} --{1}", ++counter, fabric);
            }

            return (Fabric)Convert.ToInt32(Console.ReadLine());
        }

        private static Size ChooseSize()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Choose size");
            var sizes = Enum.GetValues(typeof(Size));
            int counter = 0;
            foreach (var size in sizes)
            {
                Console.WriteLine("{0} --{1}", ++counter, size);
            }

            return (Size)Convert.ToInt32(Console.ReadLine());
        }
    }
}

