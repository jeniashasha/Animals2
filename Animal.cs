using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class Animal
    {
        public string name;

        protected Animal(string name)
        {
            this.name = name;
        }
        public abstract void MakeSound();
        
        
        public override string ToString()
        {
            return $"{base.ToString()} name : {name} ";
        }

    }
}
