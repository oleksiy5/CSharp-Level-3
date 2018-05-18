using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.GenericType
{
    class ExerciseGenericType
    {
        public void Test()
        {
            Console.WriteLine(Comparer<int>.IsEqual(3, 5));
            Console.WriteLine(Comparer<string>.IsEqual("Hi ", "Hi "));
            Console.WriteLine(Comparer<decimal>.IsEqual(112, 112));
        }
    }

    class Adder<T> 
    {
        public static T Add(T value1, T value2)
        {
            dynamic v1 = value1;
            dynamic v2 = value2;
            return v1 + v2;
        }
    }

    class Comparer<T> 
    {
        public static bool IsEqual(T value1,T value2)
        {
            dynamic v1 = value1;
            dynamic v2 = value2;
            return v1 == v2;
        }
    }

}
