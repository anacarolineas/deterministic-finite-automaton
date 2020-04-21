using System;
using System.Collections.Generic;
using System.Text;

namespace DeterministicFiniteAutomaton
{
    public class Estado
    {
        private bool Aceito;

        private Dictionary<char, int> transicao;

        public Estado(bool aceito)
        {
            Aceito = aceito;

            transicao = new Dictionary<char, int>();
        }

        public bool ehAceito()
        {
            return Aceito;
        }

        public void addTransicao(char simbolo, int estado)
        {
            transicao.Add(simbolo, estado);
        }

        public int getTransicao(char simbolo)
        {
            return transicao.get(simbolo);
        }
    }
}
