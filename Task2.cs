using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task2
    {
        class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Type { get; set; }

            public Animal()
            {
                Name = "Noname";
                Age = 0;
                Type = "Unknown";
            }
            public Animal(string name, int age, string type)
            {
                Name = name;
                Age = age;
                Type = type;
            }
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Animal type: {Type}\n");
            }
            public override int GetHashCode()
            {
                return Name.GetHashCode() ^ Age.GetHashCode() ^ Type.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Animal a = (Animal)obj;
                return base.Equals(obj) && Name == a.Name && Age == a.Age && Type == a.Type;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}, Animal type: {Type}";
            }
        }

        class Tiger : Animal
        {
            public double Weight { get; set; }
            public Tiger(string name, int age, string type, double weight) : base(name, age, type)
            {
                Weight = weight;
            }
            public override void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Animal type: {Type}, Weight: {Weight}\n");
            }
            public void Hunt()
            {
                Console.WriteLine("Tiger is hunting.\n");
            }
            public override int GetHashCode()
            {
                return base.GetHashCode() ^ Weight.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Tiger t = (Tiger)obj;
                return base.Equals(obj) && Weight == t.Weight;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}, Animal type: {Type}, Weight: {Weight}";
            }

        }
        class Crocodile : Animal
        {
            public double Weight { get; set; }
            public Crocodile(string name, int age, string type, double weight) : base(name, age, type)
            {
                Weight = weight;
            }
            public override void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Animal type: {Type}, Weight: {Weight}\n");
            }
            public void Swim()
            {
                Console.WriteLine("Crocodile is swimining.\n");
            }
            public override int GetHashCode()
            {
                return base.GetHashCode() ^ Weight.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Crocodile c = (Crocodile)obj;
                return base.Equals(obj) && Weight == c.Weight;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}, Animal type: {Type}, Weight: {Weight}";
            }
        }
        class Kangaroo : Animal
        {
            public double Weight { get; set; }
            public Kangaroo(string name, int age, string type, double weight) : base(name, age, type)
            {
                Weight = weight;
            }
            public override void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Animal type: {Type}, Weight: {Weight}\n");
            }
            public void Jump()
            {
                Console.WriteLine("Kangaroo is jumping.\n");
            }
            public override int GetHashCode()
            {
                return base.GetHashCode() ^ Weight.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Kangaroo k = (Kangaroo)obj;
                return base.Equals(obj) && Weight == k.Weight;
            }
            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}, Animal type: {Type}, Weight: {Weight}";
            }
        }
    }
}
