using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Poodle : Dog
    {
        public string numberOfPonyTails;
        public Poodle(string name, string favoriteDogFood, string numberOfPonyTails) : base(name, favoriteDogFood)
        {
            this.numberOfPonyTails = numberOfPonyTails;

        }
        public override void Bark()
        {
            Console.WriteLine("Auf");
        }

        public override string ToString()
        {
            return $"{base.ToString()} number Of Pony Tails : {numberOfPonyTails} ";
        }
    }
}
