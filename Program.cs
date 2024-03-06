using System;

namespace Inheritance
{
    // Base class
    class Animal
    {
        public string name;

        // Constructor
        public Animal()
        {
            name = "";
        }

        // Parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    // Derived class of Animal
    class Dog : Animal
    {
        // Additional fields for Dog
        public string Breed;
        public int Age;
        public string Color;

        // Constructors
        public Dog() : base()
        {
            Breed = "";
            Age = 0;
            Color = "";
        }

        public Dog(string name, string breed, int age, string color) : base(name)
        {
            Breed = breed;
            Age = age;
            Color = color;
        }

        // Display method for Dog
        public void DisplayDogInfo()
        {
            Console.WriteLine("Dog Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Age: {Age} years");
            Console.WriteLine($"Color: {Color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a dog using user input
            Console.Write("Enter the dog's name: ");
            string dogName = Console.ReadLine();

            Console.Write("Enter the dog's breed: ");
            string dogBreed = Console.ReadLine();

            Console.Write("Enter the dog's age: ");
            int dogAge = int.Parse(Console.ReadLine());

            Console.Write("Enter the dog's color: ");
            string dogColor = Console.ReadLine();

            Dog myDog = new Dog(dogName, dogBreed, dogAge, dogColor);
            myDog.DisplayDogInfo();

            Console.ReadLine();
        }
    }
}
