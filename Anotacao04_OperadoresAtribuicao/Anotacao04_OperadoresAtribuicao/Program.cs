using System;

namespace Anotacao04_OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
         int a = 10;
            Console.WriteLine(a);
            //Operadores de atribuiç~~ao são o = 
            a += 2;
            Console.WriteLine(a);
            a *= 3;
            Console.WriteLine(a);

            //O Operador de Atribuicao += tambem funciona com strings
            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
        }
    }
}
