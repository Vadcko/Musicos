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
            Console.WriteLine("{0} Toca su Bateria\n", nombre);
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
            Console.WriteLine("{0} Toca su guitarra\n", nombre);
        }
        public override void Saluda()
        {
            Console.WriteLine("Soy {0} y soy guitarrista", nombre);
        }
    }
    class Bajista : Musico
    {
        private string bajo;
        public Bajista(string no, string bajo) : base(no)
        {
            this.bajo = bajo;
        }
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando su Bajo {1}", nombre, bajo);
        }
        public override void Tocar()
        {
            Console.WriteLine("{0} Toca su Bajo\n", nombre);
        }
        public override void Saluda()
        {
            Console.WriteLine("Soy {0} y soy Bajista", nombre);
        }
    }
    class Tecladista : Musico
    {
        private string teclado;
        public Tecladista(string no, string teclado) : base(no)
        {
            this.teclado = teclado;
        }
        public override void Afina()
        {
            Console.WriteLine("{0} Afinando el teclado {1}", nombre, teclado);
        }
        public override void Tocar()
        {
            Console.WriteLine("{0} Toca su teclado\n", nombre);
        }
        public override void Saluda()
        {
            Console.WriteLine("Soy {0} y soy Tecladista", nombre);
        }
    }
    class Program
    {
        static void Main()
        {
            //Constructor
            List<Musico> grupo = new List<Musico>();

            Bajista Roger = new Bajista("Roger Waters", "Fender P-Bass");
            Tecladista Rick = new Tecladista("Rick Wright", "Yamaha");
            Guitarrista David = new Guitarrista("David Gilmour ", "Fender Stratocaster");
            Baterista Nick  = new Baterista("Nick Mason", "Pearl");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Y con ustedes Pink Floyd tocando sus mejores exitos\n");

            //Metodo
            grupo.Add(David);
            grupo.Add(Nick);
            grupo.Add(Roger);
            grupo.Add(Rick);

            
            foreach (Musico b in grupo)
            {
                b.Afina();
                b.Saluda();
                b.Tocar();
            }
        }
    }
}

