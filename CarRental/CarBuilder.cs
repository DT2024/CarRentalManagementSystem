using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarRentalSystem
{
    internal class CarBuilder : ICarBuilder
    {
        private int carId;
        private string make;
        private string model;
        private int year;
        private string color;
        private float mileage;
        private float price;
        private int status;

        public ICarBuilder SetID(int carId)
        {
            this.carId = carId;
            return this;
        }

        public ICarBuilder SetMake(string make)
        {
            this.make = make;
            return this;
        }
       

        public ICarBuilder SetModel(string model)
        {
            this.model = model;
            return this;
        }

        public ICarBuilder SetYear(int year)
        {
            this.year = year;
            return this;
        }

        public ICarBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }
        public ICarBuilder SetMileage(float mileage)
        {
            this.mileage = mileage;
            return this;
        }

        public ICarBuilder SetPrice(float price)
        {
            this.price = price;
            return this;
        }

        public ICarBuilder SetStatus(int status)
        {
            this.status = status;
            return this;
        }

        public Car Build()
        {
            return new Car(carId, make, model, year, color, mileage, price, status);
        }

    }
}
