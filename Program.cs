using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp7
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Toy obj = new Toy("Lego toy", "Legoland", 500, 6, "Denmark");
            obj.Print();
            Console.WriteLine(obj.GetHashCode());


            Tiger tiger = new Tiger("Tiger", 5, "Predator", 200);
            Crocodile crocodile = new Crocodile("Crocodile", 4, "Predator", 100);
            Kangaroo kangaroo = new Kangaroo("Kangaroo", 10, "Herbivore", 190);

            tiger.DisplayInfo();
            tiger.Hunt();
            Console.WriteLine(tiger.GetHashCode());

            crocodile.DisplayInfo();
            crocodile.Swim();
            Console.WriteLine(crocodile.GetHashCode());

            kangaroo.DisplayInfo();
            kangaroo.Jump();
            Console.WriteLine(kangaroo.GetHashCode());




            Figura[] figure = new Figura[]
            {
               new Rectangle(5, 7),
               new Circle(3),
               new RightTriangle(6, 8),
               new Trapezoid(3, 5, 4)
            };
            foreach (Figura f in figure)
            {
                Console.WriteLine($"Area: {f.CalculateArea()}, HashCode: {f.GetHashCode()}");
            }

        }
    }
}
