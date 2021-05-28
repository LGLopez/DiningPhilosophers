using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Chopstick
    {
        private bool taken = false;

        private int id;

        public Chopstick(int id)
        {
            this.id = id;
        }

        public void Get()
        {
            lock (this)
            {
                while (taken)
                {
                    Console.WriteLine("El chopstick " + id + " se intento tomar pero esta siendo usado.");
                    Monitor.Wait(this);
                }
                taken = true;
            }
        }

        public void Put()
        {
            lock(this)
            {
                taken = false;
                Monitor.Pulse(this);
            }
        }

    }
}
