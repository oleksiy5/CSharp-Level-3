using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.Diagnostic
{
    class ExerciseDiagnostic
    {
        public void Test()
        {
            ConsoleTraceListener writer = new ConsoleTraceListener();
            Debug.Listeners.Add(writer);

            Random rn = new Random();
            for (int i = 1; i <= 30; i++)
            {
                int number = rn.Next(0, 1000);
                Debug.WriteLine($"i({i}) : {number}");
            }

            Debug.Flush();
        }
    }
}
