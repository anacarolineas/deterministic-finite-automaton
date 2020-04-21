using System;
using System.Collections.Generic;
using System.Text;

namespace DeterministicFiniteAutomaton
{
    public class AutomatoDeterministico
    {
        private Dictionary<int, Estado> estados;

        public AutomatoDeterministico()
        {
            estados = new Dictionary<int, Estado>();

            Estado q0 = new Estado(false);
            q0.addTransicao('f', 1);
            q0.addTransicao('s', 4);
            estados.Add(0, q0);

            Estado q1 = new Estado(false);
            q1.addTransicao('t', 2);
            estados.Add(0, q0);

            Estado q2 = new Estado(false);
            q2.addTransicao('p', 3);
            estados.Add(0, q0);
        }

        private string formatEstado(int estado)
        {
            if ((estados.Count < 100) && (estados.Count < 10))
            {
                return "\nq" + estado + "  - ";
            }

            return "\nq" + estado + " - ";
        }

        public bool Verificar(string sentence)
        {
            string input = sentence + "$";

            Console.WriteLine("Observação: \"$\" representa o fim da sentença");

            int state = 0;

            int length = input.Length;

            for (int symbol = 0; symbol < length; symbol++)
            {
                Console.WriteLine(formatEstado(state));

                for (int index = 0; index < length; index++)
                {
                    if (index != symbol)
                    {
                        Console.WriteLine(" " + input.Substring(index) + " ");
                    }
                    else
                    {
                        Console.WriteLine("[" + input.Substring(index) + "]");
                    }
                }

                state = estados.get(state).getTransition(input.Substring(symbol));

                if (estados == null)
                {
                    Console.WriteLine(" - REJEITA");

                    return false;
                }
            }

            if (estados.get(estados).ehAceito())
            {
                Console.WriteLine(" - ACEITA");
            }
            else
            {
                Console.WriteLine(" - REJEITA");
            }

            return estados.get(state).isAccept();
        }
    }
}












