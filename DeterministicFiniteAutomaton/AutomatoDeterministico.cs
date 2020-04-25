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
            q0.addTransicao('s', 3);
            this.estados.Add(0, q0);

            Estado q1 = new Estado(false);
            q1.addTransicao('t', 2);
            this.estados.Add(1, q1);

            Estado q2 = new Estado(false);
            q2.addTransicao('p', 5);
            this.estados.Add(2, q2);

            Estado q3 = new Estado(false);
            q3.addTransicao('s', 4);
            this.estados.Add(3, q3);

            Estado q4 = new Estado(false);
            q4.addTransicao('h', 5);
            this.estados.Add(4, q4);




            Estado q5 = new Estado(false);
            q5.addTransicao('a', 5);
            q5.addTransicao('b', 5);
            q5.addTransicao('c', 6);
            q5.addTransicao('d', 5);
            q5.addTransicao('e', 5);
            q5.addTransicao('f', 5);
            q5.addTransicao('g', 9);
            q5.addTransicao('h', 5);
            q5.addTransicao('i', 5);
            q5.addTransicao('j', 5);
            q5.addTransicao('k', 5);
            q5.addTransicao('l', 5);
            q5.addTransicao('m', 13);
            q5.addTransicao('n', 5);
            q5.addTransicao('o', 5);
            q5.addTransicao('p', 5);
            q5.addTransicao('q', 5);
            q5.addTransicao('r', 5);
            q5.addTransicao('s', 5);
            q5.addTransicao('t', 5);
            q5.addTransicao('u', 5);
            q5.addTransicao('v', 5);
            q5.addTransicao('w', 5);
            q5.addTransicao('x', 5);
            q5.addTransicao('y', 5);
            q5.addTransicao('z', 5);
            this.estados.Add(5, q5);

            Estado q6 = new Estado(false);
            q6.addTransicao('a', 7);
            q6.addTransicao('b', 5);
            q6.addTransicao('c', 6);
            q6.addTransicao('d', 5);
            q6.addTransicao('e', 5);
            q6.addTransicao('f', 5);
            q6.addTransicao('g', 9);
            q6.addTransicao('h', 5);
            q6.addTransicao('i', 5);
            q6.addTransicao('j', 5);
            q6.addTransicao('k', 5);
            q6.addTransicao('l', 5);
            q6.addTransicao('m', 13);
            q6.addTransicao('n', 5);
            q6.addTransicao('o', 5);
            q6.addTransicao('p', 5);
            q6.addTransicao('q', 5);
            q6.addTransicao('r', 5);
            q6.addTransicao('s', 5);
            q6.addTransicao('t', 5);
            q6.addTransicao('u', 5);
            q6.addTransicao('v', 5);
            q6.addTransicao('w', 5);
            q6.addTransicao('x', 5);
            q6.addTransicao('y', 5);
            q6.addTransicao('z', 5);
            this.estados.Add(6, q6);

            Estado q7 = new Estado(false);
            q7.addTransicao('a', 5);
            q7.addTransicao('b', 5);
            q7.addTransicao('c', 6);
            q7.addTransicao('d', 5);
            q7.addTransicao('e', 5);
            q7.addTransicao('f', 5);
            q7.addTransicao('g', 9);
            q7.addTransicao('h', 5);
            q7.addTransicao('i', 5);
            q7.addTransicao('j', 5);
            q7.addTransicao('k', 5);
            q7.addTransicao('l', 5);
            q7.addTransicao('m', 13);
            q7.addTransicao('n', 5);
            q7.addTransicao('o', 5);
            q7.addTransicao('p', 5);
            q7.addTransicao('q', 5);
            q7.addTransicao('r', 8);
            q7.addTransicao('s', 5);
            q7.addTransicao('t', 5);
            q7.addTransicao('u', 5);
            q7.addTransicao('v', 5);
            q7.addTransicao('w', 5);
            q7.addTransicao('x', 5);
            q7.addTransicao('y', 5);
            q7.addTransicao('z', 5);
            this.estados.Add(7, q7);

            Estado q8 = new Estado(false);
            q8.addTransicao('a', 5);
            q8.addTransicao('b', 5);
            q8.addTransicao('c', 6);
            q8.addTransicao('d', 5);
            q8.addTransicao('e', 5);
            q8.addTransicao('f', 5);
            q8.addTransicao('g', 9);
            q8.addTransicao('h', 5);
            q8.addTransicao('i', 5);
            q8.addTransicao('j', 5);
            q8.addTransicao('k', 5);
            q8.addTransicao('l', 5);
            q8.addTransicao('m', 13);
            q8.addTransicao('n', 5);
            q8.addTransicao('o', 5);
            q8.addTransicao('p', 5);
            q8.addTransicao('q', 5);
            q8.addTransicao('r', 5);
            q8.addTransicao('s', 17);
            q8.addTransicao('t', 5);
            q8.addTransicao('u', 5);
            q8.addTransicao('v', 5);
            q8.addTransicao('w', 5);
            q8.addTransicao('x', 5);
            q8.addTransicao('y', 5);
            q8.addTransicao('z', 5);
            this.estados.Add(8, q8);

            Estado q9 = new Estado(false);
            q9.addTransicao('a', 10);
            q9.addTransicao('b', 5);
            q9.addTransicao('c', 6);
            q9.addTransicao('d', 5);
            q9.addTransicao('e', 5);
            q9.addTransicao('f', 5);
            q9.addTransicao('g', 9);
            q9.addTransicao('h', 5);
            q9.addTransicao('i', 5);
            q9.addTransicao('j', 5);
            q9.addTransicao('k', 5);
            q9.addTransicao('l', 5);
            q9.addTransicao('m', 13);
            q9.addTransicao('n', 5);
            q9.addTransicao('o', 5);
            q9.addTransicao('p', 5);
            q9.addTransicao('q', 5);
            q9.addTransicao('r', 5);
            q9.addTransicao('s', 5);
            q9.addTransicao('t', 5);
            q9.addTransicao('u', 5);
            q9.addTransicao('v', 5);
            q9.addTransicao('w', 5);
            q9.addTransicao('x', 5);
            q9.addTransicao('y', 5);
            q9.addTransicao('z', 5);
            this.estados.Add(9, q9);

            Estado q10 = new Estado(false);
            q10.addTransicao('a', 5);
            q10.addTransicao('b', 5);
            q10.addTransicao('c', 6);
            q10.addTransicao('d', 5);
            q10.addTransicao('e', 5);
            q10.addTransicao('f', 5);
            q10.addTransicao('g', 9);
            q10.addTransicao('h', 5);
            q10.addTransicao('i', 5);
            q10.addTransicao('j', 5);
            q10.addTransicao('k', 5);
            q10.addTransicao('l', 5);
            q10.addTransicao('m', 11);
            q10.addTransicao('n', 5);
            q10.addTransicao('o', 5);
            q10.addTransicao('p', 5);
            q10.addTransicao('q', 5);
            q10.addTransicao('r', 5);
            q10.addTransicao('s', 5);
            q10.addTransicao('t', 5);
            q10.addTransicao('u', 5);
            q10.addTransicao('v', 5);
            q10.addTransicao('w', 5);
            q10.addTransicao('x', 5);
            q10.addTransicao('y', 5);
            q10.addTransicao('z', 5);
            this.estados.Add(10, q10);

            Estado q11 = new Estado(false);
            q11.addTransicao('a', 5);
            q11.addTransicao('b', 5);
            q11.addTransicao('c', 6);
            q11.addTransicao('d', 5);
            q11.addTransicao('e', 12);
            q11.addTransicao('f', 5);
            q11.addTransicao('g', 9);
            q11.addTransicao('h', 5);
            q11.addTransicao('i', 5);
            q11.addTransicao('j', 5);
            q11.addTransicao('k', 5);
            q11.addTransicao('l', 5);
            q11.addTransicao('m', 13);
            q11.addTransicao('n', 5);
            q11.addTransicao('o', 14);
            q11.addTransicao('p', 5);
            q11.addTransicao('q', 5);
            q11.addTransicao('r', 5);
            q11.addTransicao('s', 5);
            q11.addTransicao('t', 5);
            q11.addTransicao('u', 5);
            q11.addTransicao('v', 5);
            q11.addTransicao('w', 5);
            q11.addTransicao('x', 5);
            q11.addTransicao('y', 5);
            q11.addTransicao('z', 5);
            this.estados.Add(11, q11);

            Estado q12 = new Estado(false);
            q12.addTransicao('a', 5);
            q12.addTransicao('b', 5);
            q12.addTransicao('c', 6);
            q12.addTransicao('d', 5);
            q12.addTransicao('e', 5);
            q12.addTransicao('f', 5);
            q12.addTransicao('g', 9);
            q12.addTransicao('h', 5);
            q12.addTransicao('i', 5);
            q12.addTransicao('j', 5);
            q12.addTransicao('k', 5);
            q12.addTransicao('l', 5);
            q12.addTransicao('m', 13);
            q12.addTransicao('n', 5);
            q12.addTransicao('o', 5);
            q12.addTransicao('p', 5);
            q12.addTransicao('q', 5);
            q12.addTransicao('r', 5);
            q12.addTransicao('s', 17);
            q12.addTransicao('t', 5);
            q12.addTransicao('u', 5);
            q12.addTransicao('v', 5);
            q12.addTransicao('w', 5);
            q12.addTransicao('x', 5);
            q12.addTransicao('y', 5);
            q12.addTransicao('z', 5);
            this.estados.Add(12, q12);

            Estado q13 = new Estado(false);
            q13.addTransicao('a', 5);
            q13.addTransicao('b', 5);
            q13.addTransicao('c', 6);
            q13.addTransicao('d', 5);
            q13.addTransicao('e', 5);
            q13.addTransicao('f', 5);
            q13.addTransicao('g', 9);
            q13.addTransicao('h', 5);
            q13.addTransicao('i', 5);
            q13.addTransicao('j', 5);
            q13.addTransicao('k', 5);
            q13.addTransicao('l', 5);
            q13.addTransicao('m', 13);
            q13.addTransicao('n', 5);
            q13.addTransicao('o', 14);
            q13.addTransicao('p', 5);
            q13.addTransicao('q', 5);
            q13.addTransicao('r', 5);
            q13.addTransicao('s', 5);
            q13.addTransicao('t', 5);
            q13.addTransicao('u', 5);
            q13.addTransicao('v', 5);
            q13.addTransicao('w', 5);
            q13.addTransicao('x', 5);
            q13.addTransicao('y', 5);
            q13.addTransicao('z', 5);
            this.estados.Add(13, q13);

            Estado q14 = new Estado(false);
            q14.addTransicao('a', 5);
            q14.addTransicao('b', 5);
            q14.addTransicao('c', 6);
            q14.addTransicao('d', 5);
            q14.addTransicao('e', 5);
            q14.addTransicao('f', 5);
            q14.addTransicao('g', 9);
            q14.addTransicao('h', 5);
            q14.addTransicao('i', 5);
            q14.addTransicao('j', 5);
            q14.addTransicao('k', 5);
            q14.addTransicao('l', 5);
            q14.addTransicao('m', 13);
            q14.addTransicao('n', 15);
            q14.addTransicao('o', 5);
            q14.addTransicao('p', 5);
            q14.addTransicao('q', 5);
            q14.addTransicao('r', 5);
            q14.addTransicao('s', 5);
            q14.addTransicao('t', 5);
            q14.addTransicao('u', 5);
            q14.addTransicao('v', 5);
            q14.addTransicao('w', 5);
            q14.addTransicao('x', 5);
            q14.addTransicao('y', 5);
            q14.addTransicao('z', 5);
            this.estados.Add(14, q14);

            Estado q15 = new Estado(false);
            q15.addTransicao('a', 5);
            q15.addTransicao('b', 5);
            q15.addTransicao('c', 6);
            q15.addTransicao('d', 5);
            q15.addTransicao('e', 16);
            q15.addTransicao('f', 5);
            q15.addTransicao('g', 9);
            q15.addTransicao('h', 5);
            q15.addTransicao('i', 5);
            q15.addTransicao('j', 5);
            q15.addTransicao('k', 5);
            q15.addTransicao('l', 5);
            q15.addTransicao('m', 13);
            q15.addTransicao('n', 5);
            q15.addTransicao('o', 5);
            q15.addTransicao('p', 5);
            q15.addTransicao('q', 5);
            q15.addTransicao('r', 5);
            q15.addTransicao('s', 5);
            q15.addTransicao('t', 5);
            q15.addTransicao('u', 5);
            q15.addTransicao('v', 5);
            q15.addTransicao('w', 5);
            q15.addTransicao('x', 5);
            q15.addTransicao('y', 5);
            q15.addTransicao('z', 5);
            this.estados.Add(15, q15);

            Estado q16 = new Estado(false);
            q16.addTransicao('a', 5);
            q16.addTransicao('b', 5);
            q16.addTransicao('c', 6);
            q16.addTransicao('d', 5);
            q16.addTransicao('e', 5);
            q16.addTransicao('f', 5);
            q16.addTransicao('g', 9);
            q16.addTransicao('h', 5);
            q16.addTransicao('i', 5);
            q16.addTransicao('j', 5);
            q16.addTransicao('k', 5);
            q16.addTransicao('l', 5);
            q16.addTransicao('m', 13);
            q16.addTransicao('n', 5);
            q16.addTransicao('o', 5);
            q16.addTransicao('p', 5);
            q16.addTransicao('q', 5);
            q16.addTransicao('r', 5);
            q16.addTransicao('s', 5);
            q16.addTransicao('t', 5);
            q16.addTransicao('u', 5);
            q16.addTransicao('v', 5);
            q16.addTransicao('w', 5);
            q16.addTransicao('x', 5);
            q16.addTransicao('y', 17);
            q16.addTransicao('z', 5);
            this.estados.Add(16, q16);

            Estado q17 = new Estado(false);
            q17.addTransicao('a', 17);
            q17.addTransicao('b', 17);
            q17.addTransicao('c', 18);
            q17.addTransicao('d', 17);
            q17.addTransicao('e', 17);
            q17.addTransicao('f', 17);
            q17.addTransicao('g', 17);
            q17.addTransicao('h', 17);
            q17.addTransicao('i', 17);
            q17.addTransicao('j', 17);
            q17.addTransicao('k', 17);
            q17.addTransicao('l', 17);
            q17.addTransicao('m', 17);
            q17.addTransicao('n', 20);
            q17.addTransicao('o', 17);
            q17.addTransicao('p', 17);
            q17.addTransicao('q', 17);
            q17.addTransicao('r', 17);
            q17.addTransicao('s', 17);
            q17.addTransicao('t', 17);
            q17.addTransicao('u', 17);
            q17.addTransicao('v', 17);
            q17.addTransicao('w', 17);
            q17.addTransicao('x', 17);
            q17.addTransicao('y', 17);
            q17.addTransicao('z', 17);
            this.estados.Add(17, q17);

            Estado q18 = new Estado(false);
            q18.addTransicao('a', 17);
            q18.addTransicao('b', 17);
            q18.addTransicao('c', 18);
            q18.addTransicao('d', 17);
            q18.addTransicao('e', 17);
            q18.addTransicao('f', 17);
            q18.addTransicao('g', 17);
            q18.addTransicao('h', 17);
            q18.addTransicao('i', 17);
            q18.addTransicao('j', 17);
            q18.addTransicao('k', 17);
            q18.addTransicao('l', 17);
            q18.addTransicao('m', 17);
            q18.addTransicao('n', 20);
            q18.addTransicao('o', 19);
            q18.addTransicao('p', 17);
            q18.addTransicao('q', 17);
            q18.addTransicao('r', 17);
            q18.addTransicao('s', 17);
            q18.addTransicao('t', 17);
            q18.addTransicao('u', 17);
            q18.addTransicao('v', 17);
            q18.addTransicao('w', 17);
            q18.addTransicao('x', 17);
            q18.addTransicao('y', 17);
            q18.addTransicao('z', 17);
            this.estados.Add(18, q18);

            Estado q19 = new Estado(false);
            q19.addTransicao('a', 17);
            q19.addTransicao('b', 17);
            q19.addTransicao('c', 18);
            q19.addTransicao('d', 17);
            q19.addTransicao('e', 17);
            q19.addTransicao('f', 17);
            q19.addTransicao('g', 17);
            q19.addTransicao('h', 17);
            q19.addTransicao('i', 17);
            q19.addTransicao('j', 17);
            q19.addTransicao('k', 17);
            q19.addTransicao('l', 17);
            q19.addTransicao('m', 22);
            q19.addTransicao('n', 20);
            q19.addTransicao('o', 17);
            q19.addTransicao('p', 17);
            q19.addTransicao('q', 17);
            q19.addTransicao('r', 17);
            q19.addTransicao('s', 17);
            q19.addTransicao('t', 17);
            q19.addTransicao('u', 17);
            q19.addTransicao('v', 17);
            q19.addTransicao('w', 17);
            q19.addTransicao('x', 17);
            q19.addTransicao('y', 17);
            q19.addTransicao('z', 17);
            this.estados.Add(19, q19);

            Estado q20 = new Estado(false);
            q20.addTransicao('a', 17);
            q20.addTransicao('b', 17);
            q20.addTransicao('c', 18);
            q20.addTransicao('d', 17);
            q20.addTransicao('e', 21);
            q20.addTransicao('f', 17);
            q20.addTransicao('g', 17);
            q20.addTransicao('h', 17);
            q20.addTransicao('i', 17);
            q20.addTransicao('j', 17);
            q20.addTransicao('k', 17);
            q20.addTransicao('l', 17);
            q20.addTransicao('m', 17);
            q20.addTransicao('n', 20);
            q20.addTransicao('o', 17);
            q20.addTransicao('p', 17);
            q20.addTransicao('q', 17);
            q20.addTransicao('r', 17);
            q20.addTransicao('s', 17);
            q20.addTransicao('t', 17);
            q20.addTransicao('u', 17);
            q20.addTransicao('v', 17);
            q20.addTransicao('w', 17);
            q20.addTransicao('x', 17);
            q20.addTransicao('y', 17);
            q20.addTransicao('z', 17);
            this.estados.Add(20, q20);

            Estado q21 = new Estado(false);
            q21.addTransicao('a', 17);
            q21.addTransicao('b', 17);
            q21.addTransicao('c', 18);
            q21.addTransicao('d', 17);
            q21.addTransicao('e', 17);
            q21.addTransicao('f', 17);
            q21.addTransicao('g', 17);
            q21.addTransicao('h', 17);
            q21.addTransicao('i', 17);
            q21.addTransicao('j', 17);
            q21.addTransicao('k', 17);
            q21.addTransicao('l', 17);
            q21.addTransicao('m', 17);
            q21.addTransicao('n', 20);
            q21.addTransicao('o', 17);
            q21.addTransicao('p', 17);
            q21.addTransicao('q', 17);
            q21.addTransicao('r', 17);
            q21.addTransicao('s', 17);
            q21.addTransicao('t', 22);
            q21.addTransicao('u', 17);
            q21.addTransicao('v', 17);
            q21.addTransicao('w', 17);
            q21.addTransicao('x', 17);
            q21.addTransicao('y', 17);
            q21.addTransicao('z', 17);
            this.estados.Add(21, q21);

            Estado q22 = new Estado(true);
            q22.addTransicao('a', 17);
            q22.addTransicao('b', 17);
            q22.addTransicao('c', 18);
            q22.addTransicao('d', 17);
            q22.addTransicao('e', 17);
            q22.addTransicao('f', 17);
            q22.addTransicao('g', 17);
            q22.addTransicao('h', 17);
            q22.addTransicao('i', 17);
            q22.addTransicao('j', 17);
            q22.addTransicao('k', 17);
            q22.addTransicao('l', 17);
            q22.addTransicao('m', 17);
            q22.addTransicao('n', 20);
            q22.addTransicao('o', 17);
            q22.addTransicao('p', 17);
            q22.addTransicao('q', 17);
            q22.addTransicao('r', 17);
            q22.addTransicao('s', 17);
            q22.addTransicao('t', 17);
            q22.addTransicao('u', 17);
            q22.addTransicao('v', 17);
            q22.addTransicao('w', 17);
            q22.addTransicao('x', 17);
            q22.addTransicao('y', 17);
            q22.addTransicao('z', 17);
            q22.addTransicao('$', 22);
            this.estados.Add(22, q22);

        }
        private string formatEstado(int estado)
        {
            if ((this.estados.Count < 100) && (estados.Count < 10))
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


                if (!this.estados[state].existeTransicao(input[symbol]))
                {
                    Console.WriteLine(" - REJEITA");
                    return false;
                }
                else
                {
                    state = this.estados[state].getTransicao(input[symbol]);
                }
            }


            if (this.estados[state].ehAceito())
            {
                Console.WriteLine(" - ACEITA");
            }
            else
            {
                Console.WriteLine(" - REJEITA");
            }

            return estados[state].ehAceito();
        }
    }
}
