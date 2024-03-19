using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConstructorsMethodsOverloading
{
    public class Car
    {
        string _make;
        string _model;
        int _year;
        int _mileage;

        public Car()
        {
            _make = "unassigned";
            _model = "unassigned";
            _year = 0;
            _mileage = 0;
        }


        //Constructor car (2 arguments)
        public Car(string make, string model)
        {
            _make = make;
            _model = model;

        }

        //Constructor 
        public Car (string make, string model, int year, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _mileage = mileage;
        }


        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public override string ToString()
        {
            return $"{_year} {_make} {_model} - {_mileage}";
        }

    }
}
