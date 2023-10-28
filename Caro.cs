using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AleProjeto
{
    class Caro
    {
        private string marca;
        private int ano;
        private double motor1;
        private int Velocidade;
        private double gasolina = 5.29;
        private int estado;
        private bool ligado;
        private double Precogasolina;

        public Caro(string marca, int ano, double motor1, int velocidade, double gasolina, int estado, bool ligado, double preogasolina)
        {
            this.marca = marca;
            this.ano = ano;
            this.motor1 = motor1;
            this.Velocidade = velocidade;
            this.gasolina = gasolina;
            this.estado = estado;
            this.ligado = ligado;
            this.Precogasolina = preogasolina;
        }


        public int MostrarVelocidade()
        {
            int mostrarv = this.Velocidade;
            return mostrarv;       
        }


        public void Verificar(int verificacao)
        {
            if (verificacao == 1)
            {
                this.ligado = true;

            }
            else
            {
                 this.ligado = false;

            }

        }


        public int Acelerar(int veloo)
        {
            if(veloo <180 && veloo > 0)
            {
            if(this.ligado == true)
            {
            return this.Velocidade += veloo;

            }
            return 0;

            }
            return 0;
        }


        public double gasosa(double litros)
        {
            this.Precogasolina = this.gasolina * litros;
            return this.Precogasolina;
        }



        public void Freiar()
        {
            this.Velocidade = 0;
        }



    }
}
