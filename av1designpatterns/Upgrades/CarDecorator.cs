using av1designpatterns.Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace av1designpatterns.Upgrades
{
    public class CarDecorator : Car
    {
        protected Car carro { get; set; }
        public CarDecorator(string model, string color, Car carro):base(model, color) 
        {
            this.carro = carro;
        }
        public CarDecorator(Car carro)
        {
            this.color = carro.GetColor();
            this.model = carro.GetModel();
            this.CarType = carro.GetCarType();
            this.carro = carro;
        }

        public override string ToString()
        {
            return $"Carro : {carro.GetCarType()}\n" +
               $"modelo: {carro.GetModel()}\n" +
               $"cor: {carro.GetColor()}\n" +
               $"Velocidade Maxima: {this.GetVelMax()} km/h\n" +
               $"Nível de Resistencia: {this.GetResistenceLvl()} N/m²";
        }
    }
}
