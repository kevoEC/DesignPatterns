using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilders
{
    public class CarBuilder
    {
        public string Brand = "Ford";
        public string Model = "Mustang";
        public string Color = "Red";
        public int Year = DateTime.Now.Year;
        public CarBuilder SetBrand(string brand) 
        { 
            Brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model) 
        { 
            
            Model = model;
            return this;

        }
        public CarBuilder SetColor(string color) 
        { 
        
            Color = color;
            return this;

        }

        public CarBuilder SetYear(int year)
        {
            
            Year = year;
            return this;
       
        }

        public Car Build()
        {
            return new Car(Color, Brand, Model, Year);
        }
    }
}
