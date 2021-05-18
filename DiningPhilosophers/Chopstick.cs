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

        private int identity;

        public Chopstick(int id)
        {
            identity = id;
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

                Console.WriteLine("Chopstick " + identity + " tomado");
            }
        }

        public void Put()
        {
            lock(this)
            {
                taken = false;
                Console.WriteLine("Chopstick " + identity + " bajado a la mesa.");
                Monitor.Pulse(this);
            }
        }

    }
}
