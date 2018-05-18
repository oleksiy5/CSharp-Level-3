using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.Lambda
{
    class ExerciseLambda
    {
        public void Test()
        {
            string myStr = "Hi, everybody";

            var eCount = myStr.Where(s => s == 'e').Count();
            var yCount = myStr.Where(s => s == 'y').Count();

            Console.WriteLine(eCount);
            Console.WriteLine(yCount);

        }
    }
}
