using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Car
    {
        public string model, color;
        public int year;

        public Car(string modelName, string colorName, int year)
        {
            this.model = modelName;
            this.color = colorName;
            this.year = year;
        }


    }

    class Person
    {
        public string Name 
        {
            set;
            get; 
        }
    }


    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("Animal make sound");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Dog Sound");
        }
    }

}
