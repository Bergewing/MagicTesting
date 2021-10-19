using System;
using TheMagicFactory;
using System.Collections.Generic;

Purchase purchase = new Purchase();
Inventory inventory = new Inventory();

while (true)
{
    //inventory.MetalCount();
    inventory.ProductCount();
    inventory.MetalCount();
    inventory.AddTreeTable();

    purchase.PurchaseMetal();
    purchase.PurchaseWood();

    inventory.AddTreeTable();
    inventory.MetalCount();
    inventory.ProductCount();
}


