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
            return this.Aceito;
        }

        public void addTransicao(char simbolo, int estado)
        {
            transicao.Add(simbolo, estado);
        }

        public bool existeTransicao(char simbolo){
            return this.transicao.ContainsKey(simbolo);
        }

        public int getTransicao(char simbolo)
        {
            return this.transicao[simbolo];
        }
    }
}
