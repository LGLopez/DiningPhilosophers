using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Philosopher
    {
        private int id;
        private Chopstick left;
        private Chopstick right;
        private int timesEat;

        public Philosopher(int id, Chopstick left, Chopstick right)
        {
            this.id = id;
            this.left = left;
            this.right = right;
        }

        public void RunPhilosopher()
        {
            while (timesEat < 5)
            {
                Console.WriteLine("Filosofo " + id + " esta pensando");
                
                Console.WriteLine("Filosofo " + id + " tiene hambre");

                if (id % 2 == 0)
                {
                    left.Get();
                    Console.WriteLine("El filosofo " + id + " tieme el chopstick izquierdo");
                }
                else
                {
                    right.Get();
                    Console.WriteLine("El filosofo " + id + " tomo el chopstick derecho");
                }

                if (id % 2 == 0)
                {
                    right.Get();
                    Console.WriteLine("El filosofo " + id + " tomo el chostick derecho");
                    Console.WriteLine("Ha comido " + ++timesEat + " veces");
                }
                else
                {
                    left.Get();
                    Console.WriteLine("El filosofo " + id + " tomo el chostick izquierdo");
                    Console.WriteLine("Ha comido " + ++timesEat + " veces");
                }

                right.Put();
                left.Put();
            }
        }


    }
}
;