using Assignment4.Entities;
using Assignment4.Enums;
using Assignment4.Strategies.PaymentStrategy;
using Assignment4.Strategies.ProductVariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Eshop
    {
        private IPaymentMethodStrategy paymentMethod;
        private IEnumerable<VariationStrategy> variations;


        public Eshop(IEnumerable<VariationStrategy> variations)
        {
            this.variations = variations;
        }
        public void SetVariationStrategy(IEnumerable<VariationStrategy> variations)
        {
            this.variations = variations;
        }

        public void SelectPaymentMethod(PaymentMethods p)
        {
            switch (p)
            {
                case PaymentMethods.DebitCard: paymentMethod = new CreditCard(); break;
                case PaymentMethods.BankTransfer: paymentMethod = new BankTransfer(); break;
                case PaymentMethods.Cash: paymentMethod = new Cash(); break;
                default: paymentMethod = new Cash(); break;
            }
        }

        public void TotalCostTShirt(Shirt shirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(shirt);
                Console.WriteLine($"The cost of T-Shirt after applying {variation.GetType().Name} is: {shirt.Price}");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The total price of T-Shirt is : {0}", shirt.Price);
            paymentMethod.Pay(shirt.Price);
        }
    }
}

