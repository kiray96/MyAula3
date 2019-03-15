using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            string nlinhas;
            int n;


            //Pedir nr de linhas ao utilizador 
            Console.WriteLine("Quantas linhas?");
            nlinhas = Console.ReadLine();
            n = Convert.ToInt32(nlinhas);


            for(int i=0; i < n; ++i)
            {
                //Declarar variaveis
                int esp, ast;

                //Determinar quantos espaços vão ser utilizados 
                esp = n - i - 1;


                //Determinar nr de asteriscos 
                ast = i * 2 + 1;


                //Imprimir os espaços 
                for (int j = 0; j < esp; j++)
                {
                    Console.Write(" ");
                }


                //Imprimir os asteriscos 
                for (int j = 0; j < ast; j++)
                {
                    Console.Write("*");
                }

                //Nova linha
                Console.Write("\n");
            }


        }
    }
}
