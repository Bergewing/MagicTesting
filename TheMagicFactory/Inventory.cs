using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicFactory
{
    public class Inventory
    {
        //Material
        public int Metal { get; set; }
        public int Wood { get; set; }
        public int Glass { get; set; }

        //Products
        public int RegularTable { get; set; }
        public int WoodTable { get; set; }
        public int GlassTable { get; set; }

        public int Plånbok { get; set; }

        //public int PurchaseMetal()
        //{
        //    Console.Write("How much metal do you want to add? ");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //    return Metal += input;
        //}

        //public int PurchaseWood()
        //{
        //    Console.Write("How much wood do you want to add? ");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //    return Wood += input;
        //}

        public void MetalCount()
        {
            Console.WriteLine($"Metal: {Metal} " + "\n" + $"Wood : {Wood}");
        }
        public void ProductCount()
        {
            Console.WriteLine($"Regular table: {RegularTable}" + "\n" + $"Wood table: {WoodTable}" + "\n" + $"Glass table: {GlassTable}");
        }

        //public void AddTreeTable()
        //{
        //    if (Wood >= 2)
        //    {
        //        Wood -= 2;

        //        WoodTable++;

        //    }
        //    else Console.WriteLine("Not enough wood material to build a table.");
        //}

    }
}
