using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarRenting {
    internal class Cars {
        private string brand;
        private string model;
        public int seatNum;
        public int days;
        private const double PRICE = 3000;


        public Cars(string brand, string model, int seatNum, int days) {
            this.brand = brand;
            this.model = model;
            this.seatNum = seatNum;
            this.days = days;
        }

        public double getPrice {
            get { return PRICE; }
        }

        public string Brand {
            get; set;
        }

        public string Model {
            get; set;
        }

        public virtual void showCarDetails() {
            Console.WriteLine($"Brand: {brand}\nModel: {model}\nNo. of Seats: {seatNum}\nNo. of Days: {days}");
        }
    }
}
