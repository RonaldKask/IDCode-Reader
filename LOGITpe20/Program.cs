using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayLOGIT();
        }

        public static void DisplayLOGIT()
        {
            string klass = "LOGITpe20";
            string first = klass.Substring(0, 5);
            string second = klass.Substring(5, 2);
            string third = klass.Substring(7, 2);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
