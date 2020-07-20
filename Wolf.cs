using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Wolf : Dog
    {
        public string nameOfPack;
        public Wolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood)
        {
            this.nameOfPack = nameOfPack;

        }
        public override void Bark()
        {
            Console.WriteLine("Woooo");
        }
        public override string ToString()
        {
            return $"{base.ToString()} name of pack : {nameOfPack} ";
        }
    }
}
