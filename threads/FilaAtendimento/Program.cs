using System;
using System.Collections.Generic;
using System.Threading;

namespace FilaAtendimento
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] nomes = { "André", "Luiz", "João", "Carlos", "Mario", "Lucas", "Isac", "Tércion", "Julieta", "Aurelio" };
            Queue<Cliente> fila = new Queue<Cliente>();

            // Inserindo Clientes na fila
            for (int i = 0; i < 10; i++)
            {
                fila.Enqueue(new Cliente(nomes[i]));
            }

            var caixa = new Caixa(fila);
            var caixa2 = new Caixa(fila);
            var caixa3 = new Caixa(fila);

            
            caixa.Start();
            caixa2.Start();
            caixa3.Start();

            caixa.Join();
            caixa2.Join();
            caixa3.Join();

           


        }
    }
}
