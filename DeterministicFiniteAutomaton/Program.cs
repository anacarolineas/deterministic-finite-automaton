using System;
using System.Collections.Generic;

namespace DeterministicFiniteAutomaton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analise a sentença: ");
            string sentence = Console.ReadLine();

            if (sentence.IndexOf("$") >= 0)
            {
                Console.WriteLine("A sentença \"" + sentence + "\" é inválida");

                return;
            }

            AutomatoDeterministico afd = new AutomatoDeterministico();
            afd.Verificar(sentence);

            Console.ReadKey();
        }
    }

}
