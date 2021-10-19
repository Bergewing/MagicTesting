using System;
using TheMagicFactory;
using System.Collections.Generic;
using System.Collections.ObjectModel;


Factory factory = new Factory();


while (true)
{
    factory.GränsSnitt();
    Console.WriteLine();
    factory.AddWood();
    Console.WriteLine();
    factory.DoATable();
    Console.WriteLine();
    factory.GränsSnitt();
    Console.ReadLine();



}


