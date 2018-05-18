using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.Inheritance
{
    class ExerciseInheritance
    {
        public void Test()
        {
            Beer beer = new Beer();
            beer.Alcohol = 10.5;
            Console.WriteLine($"{beer.GetName()} alc. {beer.Alcohol}");

            Juice juice = new Juice();
            juice.Color = "red";
            Console.WriteLine($"{juice.GetName()} color {juice.Color}");
        }
    }

    class Drink
    {
        string _name;
        public Drink(string name)
        {
            _name = name;
        }

        public string GetName() { return _name; }
    }

    class Beer : Drink
    {
        public double Alcohol { get; set; }

        public Beer() : base("Beer")
        {
        }
    }

    class Juice : Drink
    {
        public string Color { get; set; }

        public Juice() : base("Juice")
        {

        }
    }

}
