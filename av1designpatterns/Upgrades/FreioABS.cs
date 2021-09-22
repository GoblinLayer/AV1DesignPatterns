using av1designpatterns.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace av1designpatterns.Upgrades
{
    class FreioABS : CarDecorator
    {
        public FreioABS(string model, string color, Car carro) : base(model, color, carro)
        { }
        public FreioABS(Car carro) : base(carro)
        { }
        public override int GetVelMax()
        {
            return this.carro.GetVelMax() - 20;
        }
        public override int GetResistenceLvl()
        {
            return this.carro.GetResistenceLvl() + 40;
        }
    }
}
