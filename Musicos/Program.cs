

using System;
using System.Collections.Generic;


namespace MusicosAbstractos
{
    abstract class Musico
    {
        protected string nombre;

        public Musico(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract void Afina();

        public abstract void Saluda();

        public abstract void Tocar();

    }
    class Baterista : Musico
    {
        private string baquetas;
        public Baterista(string no, string baquetas) : base(no)
        {
            this.baquetas = baquetas;
        }
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su Bateria {1}", nombre, baquetas);
        }
        public override void Tocar()
        {
            Console.WriteLine("{0} Toca su Bateria", nombre);
        }
        public override void Saluda()
        {
            Console.WriteLine("Soy {0} y soy baterista", nombre);
        }
    }
    class Guitarrista : Musico
    {
        private string guitarra;
        public Guitarrista(string no, string guitarra) : base(no)
        {
            this.guitarra = guitarra;
        }
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su Guitarra {1}", nombre, guitarra);
        }
        public override void Tocar()
        {
            Console.WriteLine("{0} Toca su guitarra {1}", nombre);
        }
        public override void Saluda()
        {
            Console.WriteLine("Soy {0} y soy guitarrista", nombre);
        }
    }

    class Program
    {
        static void Main()
        {

        }
    }
}
