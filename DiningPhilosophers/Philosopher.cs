using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Philosopher
    {
        protected int identity;
        protected Chopstick left;
        protected Chopstick right;
        private int timesEat;

        public Philosopher(int id, Chopstick left, Chopstick right)
        {
            identity = id;
            this.left = left;
            this.right = right;
        }

        public void RunPhilosopher()
        {
            while (timesEat < 5)
            {
                Console.WriteLine("Filosofo " + identity + " esta pensando");

                Console.WriteLine("Filosofo " + identity + " tiene hambre");

                if (identity % 2 == 0)
                {
                    left.Get();
                    Console.WriteLine("El filosofo " + identity + " tieme el chopstick izquierdo");
                }
                else
                {
                    right.Get();
                    Console.WriteLine("El filosofo " + identity + " tomo el chopstick derecho");
                }

                if (identity % 2 == 0)
                {
                    right.Get();
                    Console.WriteLine("El filosofo " + identity + " tomo el chostick derecho");
                    Console.WriteLine("Ha comido " + ++timesEat + " veces");
                }
                else
                {
                    left.Get();
                    Console.WriteLine("El filosofo " + identity + " tomo el chostick izquierdo");
                    Console.WriteLine("Ha comido " + ++timesEat + " veces");
                }

                right.Put();
                left.Put();
            }
        }


    }
}
;