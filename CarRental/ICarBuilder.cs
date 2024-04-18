using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarRentalSystem
{
    public interface ICarBuilder
    {
        ICarBuilder SetMake(string make);
        ICarBuilder SetModel(string model);
        ICarBuilder SetYear(int year);
        ICarBuilder SetColor(string color);
        ICarBuilder SetMileage(float mileage);
        ICarBuilder SetPrice(float price);
        ICarBuilder SetStatus(int status);
        Car Build();
    }
}
