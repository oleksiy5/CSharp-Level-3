using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.Enumerable
{
    class ExerciseEnumerable
    {
        public void Test()
        {
            var beers = new BeerCollection();
            beers.Add("Beer 1");
            beers.Add("Beer 2");
            beers.Add("Beer 3");
            beers.Add("Beer 4");
            beers.Add("Beer 5");

            foreach (var b in beers)
            {
                Console.WriteLine(b);
            }
        }
    }

    class BeerCollection : IEnumerable
    {
        private BeerEnumerator enumerator;

        public BeerCollection()
        {
            enumerator = new BeerEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return enumerator;
        }

        public void Add(string beerName)
        {
            enumerator.Add(beerName);
        }
    }

    public class BeerEnumerator : IEnumerator
    {
        List<string> beers = new List<string>();
        public void Add(string beerName)
        {
            beers.Add(beerName);
        }
        int currentIndex = -1;
        object IEnumerator.Current => beers[currentIndex];
        bool IEnumerator.MoveNext()
        {
            currentIndex++;
            if (currentIndex < beers.Count)
            {
                return true;
            }
            return false;
        }
        void IEnumerator.Reset()
        {
            currentIndex = 0;
        }
    }

    //class BeerCollection : IEnumerable
    //{
    //    private BeerEnumerator enumerator;

    //    public BeerCollection()
    //    {
    //        enumerator = new BeerEnumerator();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return enumerator;
    //    }

    //    public class BeerEnumerator : IEnumerator
    //    {
    //        string[] beers = new string[3] { "beer1", "beer2", "beer3" };
    //        int currentIndex = -1;
    //        object IEnumerator.Current => beers[currentIndex];
    //        bool IEnumerator.MoveNext()
    //        {
    //            currentIndex++;
    //            if (currentIndex < beers.Length)
    //            {
    //                return true;
    //            }
    //            return false;
    //        }
    //        void IEnumerator.Reset()
    //        {
    //            currentIndex = 0;
    //        }
    //    }
    //}
}
