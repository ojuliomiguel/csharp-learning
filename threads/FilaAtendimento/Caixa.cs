using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FilaAtendimento
{
    abstract class BaseThread
    {
        private Thread _thread;
       

        protected BaseThread()
        {
            _thread = new Thread(new ThreadStart(this.Atender));
        }

        public void Start() => _thread.Start();
        public void Join() => _thread.Join();
        public bool IsAlive() => _thread.IsAlive;
        public abstract void Atender();



    }
    class Caixa:BaseThread
    {
        private Queue<Cliente> _fila;
        private Random _rand;
        public int ID;
        public bool IsOcupado { get; set; } = false;

        public Caixa(Queue<Cliente> fila)
            :base()
        {
            this._fila = fila;
            this._rand = new Random();
            this.ID = this._rand.Next(1000, 10000);
        }

        public override void Atender()
        {
            //this.Start();
            while (this._fila.Count > 0) 
            { 
                Console.WriteLine($"Thread de ID {this.ID} Atendendo {this._fila.Dequeue()}");
                Thread.Sleep(this._rand.Next(5000, 10000));
            }
        }
    }
}
