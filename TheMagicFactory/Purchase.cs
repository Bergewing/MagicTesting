using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicFactory
{
    public class Purchase
    {

        public int PurchaseMetal(int price)
        {
            Console.Write("How much metal do you want to add? ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public int PurchaseWood()
        {
            Console.Write("How much wood do you want to add? ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }
}
