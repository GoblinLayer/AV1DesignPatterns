using av1designpatterns.Cars;
using av1designpatterns.Upgrades;
using System;
/*
 * Escolhemos utilizar o padrão decorator pois esse padrão anexo responsabilidades adicionais a
 * um objeto dinamicamente fornecendo uma alternativa flexível de subclasses para estender a funcionalidade do objeto inicial.
 * Estendendo o objeto carro com suas funções padrão conseguimos implementar diferentes ações a serem tomadas para cada tipo 
 * diferente de veiculo e subsequentemente modificar o acréscimo de recursos com base no tipo de veículo usado
 *
 */


namespace av1designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simulando o jogo 
            Console.WriteLine("Carro jogin");
            /*
             * Na criação dos carros os jogadores irao escolher o tipo de carro, modelo ,cor
             * e em outra seção, no uso do decorator, eles iriam modificar o carro a vontade
             * as funções drift e drive simulam apenas o jogo
             */

            //Gol 2001 vermelho hatch com motor turbo e freio abs
            Car carro1 = new Hatch("gol 2001", "vermelho");
            carro1 = new MotorTurbo(carro1);
            carro1 = new FreioABS(carro1);
            carro1.Drift();
            //Civic 2001 branco sedan com capotaconversivel e motor turbo
            Car carro2 = new Sedan("Civic 2001", "branco");
            carro2 = new CapotaConversivel(carro2);
            carro2 = new MotorTurbo(carro2);
            carro2.Drive();
            //Compass Dark Eagle SUV com motor turbo , freio abs, e capota conversivel
            Car carro3 = new SUV("Compass", "Dark Eagle");
            carro3 = new MotorTurbo(carro3);
            carro3 = new FreioABS(carro3);
            carro3 = new CapotaConversivel(carro3);
            Console.WriteLine(carro1.ToString() +"\n\n"+ carro2.ToString() + "\n\n" + carro3.ToString());
        }
    }
}
