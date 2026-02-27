using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Class8_Polymorphism
{
    class Animal
    {

        public void animalSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("Dog makes the sound: Bark Bark!");
        }
    }

    class Cat : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("Cat makes the sound: Meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            myAnimal.animalSound();
            myDog.animalSound();
            myCat.animalSound();

            Console.ReadLine();
        }
    }
}
