using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRenting {
    internal class ManageOrder {
        public List<Cars> rentedCar = new List<Cars>();
        double totalPrice = 0;

        static void Main(string[] args) {
            ManageOrder manageOrder = new ManageOrder();
            manageOrder.getOrder();
        }

        void getOrder() {
            string[] carTypes = { "Hybrid", "Electric", "Diesel", "Other" };
            string[] carBrands = { "Toyota", "Honda", "Mitsubishi", "Ford", "Nissan", "Suzuki" };
            string carType, brand, model;
            string againIn;
            int seatNum = 0, days;
            bool correctSeat = false;

            bool again = true;

            while (again) {
                Console.WriteLine("What type of car would you like to rent?");
                for (int i = 0; i < carTypes.Length; i++) {
                    Console.WriteLine($"{i + 1}. {carTypes[i]}");
                }
                Console.Write("> ");
                carType = Console.ReadLine();

                Console.WriteLine("Choose the brand of car:");
                for (int i = 0; i < carBrands.Length; i++) {
                    Console.WriteLine($"{i + 1}. {carBrands[i]}");
                }
                Console.Write("> ");
                brand = Console.ReadLine();

                Console.Write("What model do you prefer?: ");
                model = Console.ReadLine();
                while (!correctSeat) {
                    Console.Write("Number of Seats (4,5,7,10,15): ");
                    seatNum = Convert.ToInt32(Console.ReadLine());
                    if ((seatNum == 4) || (seatNum == 5) || (seatNum == 7) || (seatNum == 10) || (seatNum == 15)) {
                        correctSeat = true;
                    }
                }


                Console.Write("How many days?: ");
                days = Convert.ToInt32(Console.ReadLine());


                if (carType.Equals(carTypes[0])) {
                    Console.Write("Fuel Economy (mpg): ");
                    double fuelEconomy = Convert.ToDouble(Console.ReadLine());
                    rentedCar.Add(new Hybrid(brand, model, seatNum, days, fuelEconomy));
                } else if (carType.Equals(carTypes[1])) {
                    Console.Write("Battery Range (miles): ");
                    double batteryRange = Convert.ToDouble(Console.ReadLine());
                    rentedCar.Add(new Electric(brand, model, seatNum, days, batteryRange));
                } else if (carType.Equals(carTypes[0])) {
                    Console.Write("Fuel Efficiency (mpg): ");
                    double fuelEfficiency = Convert.ToDouble(Console.ReadLine());
                    rentedCar.Add(new Diesel(brand, model, seatNum, days, fuelEfficiency));
                } else {
                    rentedCar.Add(new Cars(brand, model, seatNum, days));
                }

                Console.Write("Do you want to rent another car? (Y/N): ");
                againIn = Console.ReadLine().ToLower();

                if (againIn.Equals("y")) {
                    again = true;
                    correctSeat = false;
                } else if (againIn.Equals("n")) {
                    displayOrder();

                    again = false;
                }

            }

            void displayOrder() {
                Console.WriteLine("-----------------------------------------------------------\nRENTING SUMMARY\nCar Details:");
                foreach (var cars in rentedCar) {
                    if (cars is Hybrid) {
                        Console.WriteLine("Type of car: Hybrid");
                    } else if (cars is Electric) {
                        Console.WriteLine("Type of car: Electric");
                    } else if (cars is Diesel) {
                        Console.WriteLine("Type of car: Diesel");
                    } else {
                        Console.WriteLine("Type of car: Others");
                    }
                    totalPrice += (cars.getPrice * cars.days);
                    cars.showCarDetails();
                    Console.WriteLine();
                }

                Console.WriteLine($"TOTAL: {totalPrice}");
            }
        }
    }
}