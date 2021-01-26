using System;
using System.Collections.Generic;
using System.Text;

namespace FilaAtendimento
{
    class Cliente
    {
        private string _nome;

        public Cliente(string nome) => this._nome = nome;

        override
        public string ToString()
        {
            return $"Cliente {this._nome}";
        }
    }
}
