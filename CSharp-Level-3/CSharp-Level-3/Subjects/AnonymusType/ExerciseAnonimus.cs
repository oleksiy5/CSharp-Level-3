using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.AnonymusType
{
    class ExerciseAnonimus
    {
        public void Test()
        {
            var book = new { Title = "Olo How", Pages = 100 };
        }
    }

    class Book
    {
        private string _title = "Olo How";
        private int _pages = 100;
        public string Title { get { return _title; } set { _title = value; } }
        public int Pages { get { return _pages; } set { _pages = value; } }
    }
}
