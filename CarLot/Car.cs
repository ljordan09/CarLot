using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Car
    {

        private string _make;
        private string _model;
        private int _year;
        private double _price;
       
        /////////////////////////////////////////////////

        //public static int numCars = 0;
        public Car()
        {
            _make = " ";
            _model = " ";
            _year = 0;
            _price = 0;
           
        }
        public Car(string _make, string _model, int _year, double _price)
        {
            this._make = _make;
            this._model = _model;
            this._year = _year;
            this._price = _price;
           
        }
        public override string ToString()
        {
            return $"{_make, 1} \t{_model, 10} \t{_year, 10} \t{_price, 10:C}  ";
        }

        ////////////////////////////////////////////////////////////////

        public string Make { get { return _make; } set { _make = value; } }

        public string Model { get { return _model; } set { _model = value; } }

        public int Year { get { return _year; } set { _year = value; } }

        public double Price { get { return _price; } set { _price = value; } }


    }







}
