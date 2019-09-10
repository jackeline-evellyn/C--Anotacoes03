using System;

namespace Anotação06_EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine();
            //string[] v = Console.ReadLine().Split(' ');

            Console.WriteLine("Você Digitou ");
            Console.WriteLine( frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);


        }
    }
}
