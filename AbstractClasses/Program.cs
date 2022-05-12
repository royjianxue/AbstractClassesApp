using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.Write("Please enter the dog name: ");
            string input = Console.ReadLine();
            dog.SetName(input);
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
   
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public abstract class Animal
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
           
        }
        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();

    }


}
