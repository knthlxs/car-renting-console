using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRenting {
    internal class Hybrid : Cars {
        double fuelEconomy;
         public Hybrid(string brand, string model, int seatNum, int days, double fuelEconomy) : base(brand, model, seatNum, days) {
            this.fuelEconomy = fuelEconomy;
        }

        public override void showCarDetails() {
            base.showCarDetails();
            Console.WriteLine($"Fuel Economy (mpg): {fuelEconomy} mpg");
        }
    }
}
