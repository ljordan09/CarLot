using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class UsedCars : Car
    {
        private int Miles { get; set; }

        public UsedCars()
        {
            Miles = 0;
        }

        public UsedCars(string _make, string _model, int _year, double _price, int miles) :base(_make, _model, _year, _price) 
        {
            this.Miles = miles;
            
        }

        public override string ToString()
        {
            return base.ToString() + $"(used) {Miles,-20}  ";
        }

        public int getMiles()
        {
            return Miles;
        }
        
    }

}









        

       
        
    
    
         


    

