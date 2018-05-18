using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.Compable
{
    class ExerciseComparable
    {
        public void Test()
        {
            var list = new List<Beer>();
            list.Add(new Beer() { Name = "Beer 1", Alcohol =12.3 });
            list.Add(new Beer() { Name = "Beer 2", Alcohol = 4.4 });
            list.Add(new Beer() { Name = "Beer 3", Alcohol = 5.4 });
            list.Add(new Beer() { Name = "Beer 4", Alcohol = 4.4 });
            list.Add(new Beer() { Name = "Beer 5", Alcohol = 15.2 });
            list.Add(new Beer() { Name = "Beer 6", Alcohol = 0 });
            list.Add(new Beer() { Name = "Beer 7", Alcohol = 0 });

            list.Sort();

            foreach(Beer b in list)            
                Console.WriteLine(b);            

        }
    }


    class Beer : IComparable<Beer>
    {
        public string Name { get; set; }

        public double Alcohol { get; set; }
       
        public int CompareTo(Beer other)
        {
            if (Alcohol == 0)
                return -1;
            if (Alcohol == other.Alcohol)
            {
                return Name.CompareTo(other.Name);
            }
            return other.Alcohol.CompareTo(Alcohol);
        }

        public override string ToString()
        {
            return $"{Name}: (alc.{Alcohol})";
        }
    }
}
