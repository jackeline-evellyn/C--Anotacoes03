using System;

namespace Anotacao05_ConversaoImplicitaEClasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;
            int c;

            a = 5.1;
            //Casting
            b = (float)a;
            c = (int)a;

            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
