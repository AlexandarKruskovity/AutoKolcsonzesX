using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Collections.Generic;

namespace AutoKolcsozesX.model
{
    internal class Kolcsonzes
    {
        public Kolcsonzes(int id, string brand, string model, string color, double year, string vin)
        {
            this.id = id;
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.year = year;
            this.vin = vin;
        }

        public int id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public double year { get; set; }
        public string vin { get; set; }
        
    }
    
  
}
