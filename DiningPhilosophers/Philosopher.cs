using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DiningPhilosophers
{
    class Philosopher
    {
        private int id;
        private Chopstick left;
        private Chopstick right;
        private int timesEat;
        private Random rand = new Random();

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
                Console.WriteLine("El filosofo " + id + " esta pensando");
                Thread.Sleep(rand.Next(1, 8) * 500);
                Console.WriteLine("El filosofo " + id + " tiene hambre");

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
                    Console.WriteLine("El filosofo " + id + " tomo el chostick derecho\nEl filosofo " + id + ": Ha comido " + ++timesEat + " veces");
                }
                else
                {
                    left.Get();
                    Console.WriteLine("El filosofo " + id + " tomo el chostick izquierdo\nEl filosofo " + id + ": Ha comido " + ++timesEat + " veces");
                }

                right.Put();
                left.Put();
                Console.WriteLine("El filosofo " + id + " bajo los chopsticks.");
            }
            Console.WriteLine("El filosofo " + id + " termino de comer.");
        }
    }
}
;