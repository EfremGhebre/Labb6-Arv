using System.Drawing;

namespace Labb6_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello lovely people and welcome to our little zoo!\n"); //Greeting message to the user
            
            //Creation of new objects from the class Animal
            Dog dog = new Dog();
            Cat cat = new Cat();
            Elephant elephant = new Elephant();
            Lion lion = new Lion();

           //An array holding new objects created from the class Animal
            Animal[] animals = { dog, cat, elephant, lion };

            //Foreach loop to display all new objects with applied methods
            foreach (Animal animal in animals)
            {
                animal.GetInfo(); //Displays information of the created object  
                animal.Sound(); //Displays the sound the called object makes  
                animal.Behavior(); //Displays the behavior the called object has 
            }
            Console.WriteLine(" "); //To add space between rows

            //Creation of new objects from the class Dog
            BigDog bigDog = new BigDog();
            SmallDog smallDog = new SmallDog();

            // An array holding new objects created from the class Dog
            Dog[] dogs = { bigDog, smallDog };

            //Foreach loop to display all new objects with applied methods
            foreach (Dog canine in dogs)
            {
                canine.GetInfo();
                canine.Sound();
                canine.Behavior();
            }
        }
    }
    internal class Animal //A new class, Parent class
    {
        public string _name { get; set; }
        public int _age { get; set; }
        public string _color { get; set; }
        public string _size { get; set; }
        public string _habitat { get; set; }

        public Animal(string name, int age, string color, string size, string habitat) //A constructor for the class Animal
        {
            //Fields within the class Animal
            _name = name;
            _age = age;
            _color = color;
            _size = size;
            _habitat = habitat;
        }
        //Methods with specific functionalities
        public virtual void GetInfo()//Displays the information of the animal and allows overriding of new methods 
        {
        }
        public virtual void Sound()//Displays the sound of the animal and allows overriding of new methods 
        {
        }     
        public virtual void Behavior()//Displays the behavior of the animal and allows overriding of new methods 
        {
        }
    }
}