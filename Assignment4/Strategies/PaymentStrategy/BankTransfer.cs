using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.Strategies.PaymentStrategy
{
  
        class BankTransfer : IPaymentMethodStrategy
        {
            public void Pay(decimal amount)
            {
                Console.WriteLine($"Dear user you have to pay {amount} via bank tranfer");
            }
        }
}
