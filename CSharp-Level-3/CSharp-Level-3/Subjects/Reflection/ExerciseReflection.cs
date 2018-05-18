using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CSharp_Level_3.Subjects.Reflection
{
    class ExerciseReflection
    {
        public void Test()
        {           
            Type t = typeof(Island);           
            foreach(PropertyInfo p in t.GetProperties())                            
                Console.WriteLine($"{p.Name} : {p.PropertyType.Name}");            
           
        }
    }

    class Island
    {       
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }

        public int GetLocationX()
        {
            return 555;
        }
    }


   
}
