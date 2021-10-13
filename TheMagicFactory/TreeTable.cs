using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicFactory
{
    class TreeTable
    {
        public int Tree { get; set; }

        Material material = new Material();

        public int GetTable()
        {
            material.TreeMaterial = material.TreeMaterial - 2;
            Tree++;
            return Tree;
        }
    }
}
