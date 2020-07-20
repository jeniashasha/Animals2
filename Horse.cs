using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Horse : Animal
    {
        public bool racingHorse;
        public Horse(string name, bool racingHorse) : base(name)
        {
            this.racingHorse = racingHorse;

        }
        public override void MakeSound()
        {
            Neigh();
        }
        public virtual void Neigh()
        {
            Console.WriteLine("neeeegh");
        }

        public override string ToString()
        {
            return $"{base.ToString()} racing Horse : {racingHorse} ";
        }
    }
}
