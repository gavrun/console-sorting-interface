using System;
using System.Collections.Generic;

namespace console_sorting_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the sorted list of things:\n");

            Thing th1 = new Thing(100);
            Thing th2 = new Thing(95);
            Thing th3 = new Thing(5);

            List<Thing> things = new List<Thing>();

            things.Add(th1);
            things.Add(th2);
            things.Add(th3);

            things.Sort();

            foreach (var thing in things)
            {
                thing.ShowThing();
            }

            Console.WriteLine("\n");
        }
    }

    public class Thing : IComparable
    {
        public int thingValue;

        public int ThingValue { get { return thingValue; } set { thingValue = value; } }

        public Thing(int thingValue)
        {
            ThingValue = thingValue;
        }

        public void ShowThing()
        {
            Console.WriteLine($"Thing {ThingValue}");
        }

        public int CompareTo(object obj)
        {
            var otherThing = (Thing)obj;
            if (thingValue > otherThing.thingValue)
                return 1;
            else if (thingValue < otherThing.thingValue)
                return -1;
            else
                return 0;
        }
    }
}
