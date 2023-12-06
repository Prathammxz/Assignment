using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Car
    {
        private string brand;
        private int year;
        private float price;

        public Car(string brand, int year, float price) 
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }
        public string Brand { get {  return brand; } }
        public int Year { get { return year; } }
        public float Price { get { return price; } }

        public void DisplayCar()
        {
            Console.WriteLine($"Car Brand: {brand}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Car Price: {price}");
        }

    }
}
