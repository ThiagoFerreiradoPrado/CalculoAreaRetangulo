using Cours;
using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Retangulo ret = new Retangulo();
           
            Console.WriteLine("Entre a largura e a altura do retangulo:");

            ret.Largura = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ret.Altura = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Area: "+ ret.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: "+ret.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal:"+ ret.Diagonal().ToString("F2",CultureInfo.InvariantCulture));








        }

    }
}


