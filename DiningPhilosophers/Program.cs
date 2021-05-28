using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiningPhilosophers
{
    class Program
    {
        static Thread[] philosophers;
        static Chopstick[] chopstick;

        static int numPhilosophers = 5;

        static void Main(string[] args)
        {
            philosophers = new Thread[numPhilosophers];
            chopstick = new Chopstick[numPhilosophers];

            for (int i = 0; i < numPhilosophers; i++)
            {
                chopstick[i] = new Chopstick(i);
            }

            for (int i = 0; i < numPhilosophers; i++)
            {
                philosophers[i] = MakePhilosopher(i, chopstick[(i - 1 + numPhilosophers) % numPhilosophers], chopstick[i]);
                philosophers[i].Start();
            }

        }

        public static Thread MakePhilosopher(int id, Chopstick left, Chopstick right)
        {
            Philosopher p = new Philosopher(id, left, right);
            return new Thread(new ThreadStart( p.RunPhilosopher) );
        }
    }
}
