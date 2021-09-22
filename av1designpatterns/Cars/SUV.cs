using System;
using System.Collections.Generic;
using System.Text;

namespace av1designpatterns.Cars
{
    class SUV : Car
    {
        public SUV(string model, string color) : base(model, color)
        {
            this.model = model;
            this.CarType = "SUV";
            this.color = color;
        }
    }
}
