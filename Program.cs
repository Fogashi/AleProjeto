using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string marca;
            int ano;
            double motor;
            Console.WriteLine("digite a marca do carro");
            marca = Console.ReadLine();
            Console.WriteLine("digite o ano do carro");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o motor do carro");
            motor = double.Parse(Console.ReadLine());
            Console.WriteLine("digite 1 para ligar o carro");
            int teste = int.Parse(Console.ReadLine());

            Caro x = new Caro(marca, ano, motor, 0, 5.29, 0,true,0);

            x.Verificar(teste);

            Console.WriteLine("digite a velocidade para acelerar o carro");
            int velocidade1 = int.Parse(Console.ReadLine());
            int velo;
            velo = x.Acelerar(velocidade1);
            Console.WriteLine(velo);
            Console.WriteLine("digite 1 para freiar");
            Console.WriteLine("digite 2 para acelerar mais");
            int codicao2 = int.Parse(Console.ReadLine());


            if (codicao2 == 1)
            {
                x.Freiar();
                Console.WriteLine("velocidade do carro {0}", x.MostrarVelocidade());
            }
            else
            {
                
                Console.WriteLine("digite novamente a velocidade para acelerar");
                int velocidade2 = int.Parse(Console.ReadLine());
                int velo2;
                velo2  = x.Acelerar(velocidade2);
                Console.WriteLine(velo2);
            }

            Console.WriteLine("quantos litros de gasolina você deseja?");
            double ltgasolina = double.Parse(Console.ReadLine());
            double preco = x.gasosa(ltgasolina);
            Console.WriteLine(preco);


        }
    }
}
