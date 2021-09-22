using System;
using System.Collections.Generic;
using System.Text;

namespace av1designpatterns.Cars
{
    public class Car 
    {
        protected string model { get; set; }
        protected string CarType { get; set; }
        protected string color { get; set; }
        public int ResistenceLvl { get; set; }
        public int VelMax { get;set; }

        public Car()
        {
            CarType = "";
            VelMax = 100;
            ResistenceLvl = 50;
        }
        public Car(string model, string color)
        {
            this.model = model;
            this.CarType = "";
            this.color = color;
            VelMax = 100;
            ResistenceLvl = 50;
        }

        public virtual void Drive()
        {
            Console.WriteLine("Vrum Vrum ... VRUMMMMMMMMM");
        }

        public virtual void Drift()
        {
            Console.WriteLine("GAS GAS GAS... - Tokyo Drift");
        }

        public virtual int GetVelMax()
        {
            return VelMax;
        }

        public virtual int GetResistenceLvl()
        {
            return ResistenceLvl;
        }
        public virtual string GetModel()
        {
            return model;
        }
        public virtual string GetCarType()
        {
            return CarType;
        }
        public virtual string GetColor()
        {
            return color;
        }
        public override string ToString()
        {
            return $"Carro : {this.CarType}\n" +
                $"modelo: {this.model}\n" +
                $"cor: {this.color}\n" +
                $"Velocidade Maxima: {this.GetVelMax()} km/h\n" +
                $"Nível de Resistencia: {this.GetResistenceLvl()} N/m²";
        }
    }
}
