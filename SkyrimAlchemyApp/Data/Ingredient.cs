using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimAlchemyApp.Data
{
    public class Ingredient
    {
        public string Name { get; set; }

        public string Effect1 { get; set; }
        public string Effect2 { get; set; }
        public string Effect3 { get; set; }
        public string Effect4 { get; set; }

        public int Value { get; set; }
        public double Weight { get; set; }


        public override string ToString() { return Name; }
    }
}
