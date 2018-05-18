using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.Override
{
    class ExerciseOverride
    {
        public void Test()
        {
            var f = new Fruit();
            var s = new Strawberry();
            var l = new Lemon();

            Console.WriteLine(f.GetName());
            Console.WriteLine(s.GetName());
            Console.WriteLine(l.GetName());
        }
    }

    class Fruit
    {
        public virtual string GetName()
        {
            return "lemon";
        }
    }

    class Strawberry : Fruit
    {
        public override string GetName()
        {
            return "strawberry";
        }
    }

    class Lemon : Fruit
    {
    }
}
