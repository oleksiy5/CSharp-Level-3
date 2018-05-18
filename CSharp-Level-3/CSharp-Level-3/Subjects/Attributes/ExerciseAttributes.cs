using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.Attributes
{
    class ExerciseAttributes
    {
        public void Test()
        {
            var list = new List<Flower>();
            list.Add(new Flower() { Name = "Rose", Color = "red", TimeOfLife = 3 });
            list.Add(new Flower() { Name = "Cactus", Color = "green", TimeOfLife = 12 });
            list.Add(new Flower() { Name = "Violet", Color = "white", TimeOfLife = 5 });

            foreach (Flower f in list)
            {
                var typeFlower = typeof(Flower);
                var props = typeFlower.GetProperties();
                var sb = new StringBuilder();
                foreach (var propInf in props)
                {
                    var atrr = propInf.GetCustomAttributes(true);

                    foreach (var item in atrr.OfType<Log>())
                    {
                        if (item.IsLog)
                        {
                            object value = f.GetType().GetProperty(propInf.Name).GetValue(f, null);
                            sb.Append($"{value} ");
                        }
                    }
                }
                Console.WriteLine(sb.ToString());

            }

        }
    }

    public class Log : Attribute
    {
        public bool IsLog { get; set; }
    }

    class Flower
    {
        [Log(IsLog = true)]
        public string Name { get; set; }

        [Log(IsLog = false)]
        public string Color { get; set; }

        [Log(IsLog = true)]
        public int TimeOfLife { get; set; }
    }


}
