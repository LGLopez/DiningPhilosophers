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
                    Monitor.Wait(this);
                }
                taken = true;

                // Console.WriteLine("Chopstick " + id + " tomado");
            }
        }

        public void Put()
        {
            lock(this)
            {
                taken = false;
                // Console.WriteLine("Chopstick " + id + " bajado a la mesa.");
                Monitor.Pulse(this);
            }
        }

    }
}
