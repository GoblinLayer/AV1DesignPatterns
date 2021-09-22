using av1designpatterns.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace av1designpatterns.Upgrades
{
    public class MotorTurbo : CarDecorator
    {
        public MotorTurbo(string model, string color, Car carro) : base(model, color,carro)
        { }
        public MotorTurbo(Car carro) :base(carro)
        { }
        public override int GetVelMax()
        {
            return this.carro.GetVelMax() + 100;
        }
        public override int GetResistenceLvl()
        {
            return this.carro.GetResistenceLvl() - 10;
        }
    }
}
