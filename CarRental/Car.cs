using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarRentalSystem
{
    public class Car
    {
        public int CarID { get; }
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }
        public float Mileage { get; }
        public float Price { get; }
        public int Status { get; }

        public Car(int carId, string make, string model, int year, string color, float mileage, float price, int status)
        {
            CarID = carId;
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
            Price = price;
            Status = status;
        }
    }

}
