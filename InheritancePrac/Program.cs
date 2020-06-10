using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> Dogs = new List<Dog> { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat> { new Cat(), new Cat(), new Cat() };

            foreach( Dog dag in Dogs)
            { 
                dag.Eat();
                dag.Sleep();
                dag.Bark();
            }

            foreach(Cat cat in Cats)
            {
                cat.Eat();
                cat.Sleep();
                cat.Meow();
            }
        }
    }
}
