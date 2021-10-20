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

        public void ProduceAGlassTable()
        {
            if(inventory.Glass >= 1 && inventory.Metal >= 1)
            {
                inventory.Glass--;
                inventory.Metal--;
                inventory.GlassTable++;
            }
            else Console.WriteLine("Not enough material.");
        }

        public void ProduceARegularTable()
        {
            if(inventory.Metal >=1 && inventory.Wood >= 1)
            {

            }
        }

        public void GränsSnitt()
        {
            inventory.MetalCount();
            inventory.ProductCount();
        }
    }
}
