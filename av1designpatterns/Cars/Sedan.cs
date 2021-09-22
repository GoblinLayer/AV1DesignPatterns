using System;
using System.Collections.Generic;
using System.Text;

namespace av1designpatterns.Cars
{
    class Sedan : Car
    {
        public Sedan(string model, string color) : base(model, color)
        {
            this.model = model;
            this.CarType = "Sedan";
            this.color = color;
        }
    }
}
