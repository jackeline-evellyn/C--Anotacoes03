using System;

namespace Anotacao11_EscopoInicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
            if(preco > 100.0)
            {
                //double desconto = preco * 0.1;
                desconto = preco * 0.10;
            }
            Console.WriteLine(desconto);
            //Uma variavel declarada fora do escopo nao pode ser inicializada fora
        }
    }
}
