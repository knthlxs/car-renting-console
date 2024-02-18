using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRenting {
    internal class Diesel : Cars {
        double fuelEfficiency;
        public  Diesel(string brand, string model, int seatNum, int days, double fuelEfficiency) : base(brand, model, seatNum, days) {
            this.fuelEfficiency = fuelEfficiency;
        }

        public override void showCarDetails() {
            base.showCarDetails();
            Console.WriteLine($"Fuel Efficiency (mpg): {fuelEfficiency} mpg");
        }
    }
}
