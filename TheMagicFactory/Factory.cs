using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicFactory
{
    public class Factory
    {
        Inventory inventory = new Inventory();
        Purchase purchase = new Purchase();

        public void AddWood()
        {
            inventory.Wood = purchase.PurchaseWood();
        }

        public void DoATable()
        {
            if (inventory.Wood >= 2)
            {
                inventory.Wood -= 2;
                inventory.WoodTable++;
            }
            else Console.WriteLine("Not enough material.");
        }

        public void GränsSnitt()
        {
            inventory.MetalCount();
            inventory.ProductCount();
        }
    }
}
