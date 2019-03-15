using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            //Para fazer uma pergunta ao utilizador
            Console.WriteLine("Qual é a sua pergunta?");
            question = Console.ReadLine();

            //Escrever as perguntas que podem ser respondidas
            switch(question)
            {
                case "Como estás?":
                    response = "Estou bem obrigada";
                    break;

                default:
                    response = "Não entendo por favor faça outra pergunta! :)";
                    break;              

            }


            //Respostas
            Console.WriteLine(response);



        }
    }
}
