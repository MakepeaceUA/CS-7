using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task1
    {
        class Product
        {
            public string Name { get; set; }
            public string NamePlace { get; set; }
            public int Price { get; set; }

            public Product(string name, string nPlace, int price)
            {
                Name = name;
                NamePlace = nPlace;
                Price = price;
            }

            public virtual void Print()
            {
                Console.WriteLine($"Product Name: {Name}, Place of sale: {NamePlace}, Price: {Price}");
            }
            public string PrintName()
            {
                return Name;
            }
            public string Print_NamePlace()
            {
                return NamePlace;
            }
            public int PrintPrice()
            {
                return Price;
            }
            public override int GetHashCode()
            {
                return Name.GetHashCode() ^ NamePlace.GetHashCode() ^ Price.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Product t = (Product)obj;
                return base.Equals(obj) && Name == t.Name && NamePlace == t.NamePlace && Price == t.Price;
            }

            public override string ToString()
            {
                return $"Product Name: {Name}, Place of sale: {NamePlace}, Price: {Price}";
            }

        }

        class Toy : Product
        {
            public int AgeCategory { get; set; }
            public string Developer { get; set; }
            public Toy(string name, string nPlace, int price, int aCategory, string developer) : base(name, nPlace, price)
            {
                AgeCategory = aCategory;
                Developer = developer;
            }
            public override void Print()
            {
                Console.WriteLine($"Product Name: {Name}, Place of sale: {NamePlace}, Price: {Price}, Age Category: {AgeCategory}, Development place: {Developer}");
            }
            public void ShortPrint()
            {
                Console.WriteLine($"Age Category: {AgeCategory}, Development place: {Developer}");
            }
            public int PrintAge()
            {
                return AgeCategory;
            }
            public string PrintDeveloper()
            {
                return Developer;
            }
            public override int GetHashCode()
            {
                return Name.GetHashCode() ^ NamePlace.GetHashCode() ^ Price.GetHashCode() ^ AgeCategory.GetHashCode() ^ Developer.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Toy t = (Toy)obj;
                return base.Equals(obj) && Name == t.Name && NamePlace == t.NamePlace && Price == t.Price && AgeCategory == t.AgeCategory && Developer == t.Developer;
            }
            public override string ToString()
            {
                return $"Product Name: {Name}, Place of sale: {NamePlace}, Price: {Price}, Age Category: {AgeCategory}, Development place: {Developer}";
            }
        }
    }
}
