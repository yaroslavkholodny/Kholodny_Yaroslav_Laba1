using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace Lab1
{

    class Drib
    {
        public double Chisel { get; set; }
        public double Znamen { get; set ; }
        private double drib { get; set; }

        public Drib(double Chisel , double Znamen)
        {
            this.Chisel = Chisel;
            if (Znamen != 0)
            {
                this.Znamen = Znamen;
                drib = this.Chisel / this.Znamen;
            }
            else { this.Znamen = 1; Console.WriteLine("Знаменник не можe дорiвнювати нулю"); };
        }

        
        public void PrintDrib()
        {
            Console.WriteLine(" Дрiб дорiвнює " + drib);
        }

        public double SumOfDribs(double chisel , double znamen)
        {

            double y = (znamen != 0) ? drib + (chisel / znamen) : (drib + chisel);
            return y;
        }

        public double MultipleDrib(double a)
        {
           return drib * a; 
        }

        public double DivideDrib(double a)
        {
            double y = (a != 0) ? drib/a : drib;
            return y;
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Json.Serializer("Drib.json",  new Drib(5, 10));
            Drib drib = Json.Deserializer("Drib.json");

            //drib.PrintDrib();
            //Console.WriteLine("Сума дробiв = " + drib.SumOfDribs(chisel: 16, znamen: 48));
            //Console.WriteLine("Добуток дробy на число double = " + drib.MultipleDrib(5.5));
            //Console.WriteLine("Частка дробy на число double = " + drib.DivideDrib(6)); 
            Console.WriteLine();

        }
    }
}
