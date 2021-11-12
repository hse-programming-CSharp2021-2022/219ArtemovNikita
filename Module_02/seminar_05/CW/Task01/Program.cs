using System;

namespace Task01
{
    internal static class Program
    {
        private static void Main()
        {
            var cow = new Cow("CowName", 10, 150);
            
            var dog = new Dog("DogName", 5, "husky", true);
            
            Console.WriteLine(cow.AnimalInfo());
            
            Console.WriteLine(dog.AnimalInfo());
        }
    }
    
    internal abstract class Animal
    {
        protected Animal(string name, int age)
        {
            NickName = name;
            Age = age;
        }
        protected string NickName { get; }
        
        protected int Age { get; }

        protected abstract string AnimalSound();

        public abstract string AnimalInfo();
        
    }

    internal class Dog : Animal
    {
        public Dog(string name, int age, string breed, bool istrained) : base(name, age)
        {
            Breed = breed;
            IsTrained = istrained;
        }
        
        private string Breed { get; }
        
        private bool IsTrained { get; }
        
        protected override string AnimalSound()
        {
            return "*sound of dog*";
        }
        
        public override string AnimalInfo()
        {
            return $"Breed: {Breed}; isTrained: {IsTrained}; NickName: {NickName}; Age: {Age}; Sound: {AnimalSound()}";
        }
    }


    internal class Cow : Animal
    {
        public Cow(string name, int age, int milkCount) : base(name, age)
        {
            CountOfMilk = milkCount;
        }
        
        private int CountOfMilk { get; }
        
        protected override string AnimalSound()
        {
            return "*sound of cow*";
        }
        
        public override string AnimalInfo()
        {
            return $"Milk count: {CountOfMilk}; NickName: {NickName}; Age: {Age}; Sound: {AnimalSound()}";
        }
    }
}


