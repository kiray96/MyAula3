using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            string s, cStr;
            char c;

            //Pedir ao utilizador a string 
            Console.WriteLine("Insira a string que pretende:");
            s = Console.ReadLine();

            //Pedir ao utilizador o caracter
            Console.WriteLine("Insira o char:");
            cStr = Console.ReadLine();

            //Converter uma string num char
            c = cStr[0];
                       
            //Imprimir string
            //Precorrer a string
            foreach(char cInString in s)
                //char actual da string diferentes ao char do user?
                if (cInString != c)
                {
                    //imprimir char actual da string
                    Console.Write(cInString);

                }

            Console.Write("\n");


        }
    }
}
