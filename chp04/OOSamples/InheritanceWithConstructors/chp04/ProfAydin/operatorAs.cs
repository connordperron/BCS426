using System;

namespace LearnCSharp
{
    class Animal
    { //... 
    }
    class Dog : Animal
    { //... 
    }
    class Program
    {
        static void Main()
        {
            Animal a = new Dog(); // Dog is an Animal

            Dog d1 = (Dog)(new Animal()); // not every Animal is a Dog, do explicit type casting
            Dog d2 = (new Animal()) as Dog; // not every Animal is a Dog, use as to check
        }
    }
}
