﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_Arv
{
    internal class Lion : Animal//A child class from parent class Animal
    {
        public string _animalType { get; set; }
        public string _animalSound { get; set; }
        public Lion(string animalType = "lion", string name = "Zimba", int age = 10, string color = "golden", string size = "massive", string habitat = "wild")
            : base(name, age, color, size, habitat) 
        {
            _animalType = animalType;
            _animalSound = "roar roar";
        }
        public override void GetInfo()//Displays info of the relevant animal 
        {
            Console.WriteLine($"Our {_size} sized {_color} {_habitat} {_animalType} {_name} is {_age} years old.");
        }
        public override void Sound()//Displays the sound of the animal
        {
            Console.WriteLine($"The {_animalType}'s sound is {_animalSound}.");
        }
        public override void Behavior()//Displays the behavior of the animal
        {
            Console.WriteLine($"{_name} is very fierce.");
        }
    }
}
