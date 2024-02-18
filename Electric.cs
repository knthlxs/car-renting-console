using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRenting {
    internal class Electric : Cars {
        private double batteryRange;
         public Electric(string brand, string model, int seatNum, int days, double batteryRange) : base(brand, model, seatNum, days) {
            this.batteryRange = batteryRange;
         }
        public double BatteryRange {
            get; set;
        }

        public override void showCarDetails() {
            base.showCarDetails();
            Console.WriteLine($"Battery Range (miles): {batteryRange} miles");
        }
    }
}
