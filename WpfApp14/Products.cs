using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum PruductTypes
    {
        Овощи,
        Фрукты
    }

    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public PruductTypes ProductType { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
