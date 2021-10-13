using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicFactory 
{
    class GlassTable : IGetTable
    {
        public int Glass { get; set; }

        Material material = new Material();

        public int GetTable()
        {
            material.GlassMaterial--;
            material.MetalMaterial--;
            Glass++;
            return Glass;
        }
    }
}
