using System;
using System.Collections.Generic;
using System.Text;

namespace av1designpatterns.Cars
{
    class Hatch : Car
    {
        public Hatch(string model, string color) : base(model,color)
        {
            this.model = model;
            this.CarType = "Hatch";
            this.color = color;
        }
    }
}
