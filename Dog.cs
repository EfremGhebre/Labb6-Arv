using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv
{
    internal class Dog : Animal //A child class from parent class Animal
    {
        public string _animalType { get; set; }
        public string _animalSound { get; set; }        
        public Dog(string animalType = "dog", string name = "Buster", int age = 5, string color = "brown", string size = "medium", string habitat = "pet")
            : base(name, age, color, size, habitat)
        {
            _animalType = animalType;
            _animalSound = "woof woof";
        }
        public override void GetInfo() //Displays info of the relevant animal 
        {
            Console.WriteLine($"Our {_size} sized {_color} {_habitat} {_animalType} {_name} is {_age} years old.");
        }
        public override void Sound()//Displays the sound of the animal
        {
            Console.WriteLine($"The {_animalType}'s sound is {_animalSound}.");
        }
        public override void Behavior()//Displays the behavior of the animal
        {
            Console.WriteLine($"{_name} is very playful.");
        }
    }
    internal class BigDog : Dog //A second level inheritance from the class Dog with new properties
    {
        public string _dogName { get; set; }
        public string _dogBreed { get; set; }
        public new string _animalSound { get; set; }

        public BigDog(string dogName = "Rocky", string dogBreed = "Siberian husky", int age = 8, string color = "black & white", string size = "big", string habitat = "pet")
            : base(dogName, dogBreed, age, color, size, habitat)
        {
            _dogName = dogName;
            _dogBreed = dogBreed;
            _animalSound = "bark bark";
        }
        public override void GetInfo()
        {
            Console.WriteLine($"{_dogName}, our {_size} sized {_color} {_dogBreed} {_habitat} is {_age} years old.");
        }
        public override void Behavior()
        {
            Console.WriteLine($"{_dogName} the {_dogBreed} is very energetic.");
        }
        public override void Sound()
        {
            Console.WriteLine($"{_dogName}'s sound is {_animalSound}.");
        }
    }
    internal class SmallDog : Dog//A second level inheritance from the class Dog with new properties
    {
        public string _dogName { get; set; }
        public string _dogBreed { get; set; }

        public SmallDog(string dogName = "Timmy", string dogBreed = "Bull dog", int age = 80, string color = "brown & golden", string size = "medium", string habitat = "pet")
            : base(dogName, dogBreed, age, color, size, habitat)
        {
            _dogName = dogName;
            _dogBreed = dogBreed;
            _animalSound = "awww awww";
        }
        public override void GetInfo()
        {
            Console.WriteLine($"{_dogName}, our {_size} sized {_color} {_dogBreed} {_habitat} is {_age} years old.");
        }
        public override void Behavior()
        {
            Console.WriteLine($"{_dogName} the {_dogBreed} is very strong.");
        }
        public override void Sound()
        {
            Console.WriteLine($"{_dogName}'s sound is {_animalSound}.");
        }
    }
}
