using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsozesX.model
{
    public class Kolcsonzes
    {
        public int id;
        public string brand;
        public string model;
        public string color;
        public int year;
        public string vin;

        public Kolcsonzes(int id, string brand, string model, string color, int year, string vin)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.year = year;
            this.vin = vin;
        }

        public Kolcsonzes()
        {
        }

    }
}
