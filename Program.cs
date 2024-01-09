using System;
using System.Collections.Generic;
namespace zadacha_1
{
    abstract public class Animals
    {
        public abstract void Info();
        public string Name { get; set; }
        public int Paws { get; set; }
    }
    public class Mammal : Animals
    {
        public Mammal(string name, int paws)
        {
            Name = name;
            Paws = paws;
        }
        public override void Info()
        {
            Console.WriteLine($"Mammal: {Name}, Number of paws {Paws}");
        }
    }

    public class Bug : Animals
    {
        public Bug(string name, int paws)
        {
            Name = name;
            Paws = paws;
        }
        public override void Info()
        {
            Console.WriteLine($"Bug: {Name}, Number of paws {Paws}");
        }
    }

    public class Fish : Animals
    {
        public Fish(string name, int paws)
        {
            Name = name;
            Paws = paws;
        }
        public override void Info()
        {
            Console.WriteLine($"Fish: {Name}, Number of paws {Paws}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Mammal> mammalList = new List<Mammal>();
            List<Bug> bugList = new List<Bug>();
            List<Fish> fishList = new List<Fish>();

                mammalList.Add(new Mammal("Волк", 4));
                mammalList.Add(new Mammal("Лев", 4));
                mammalList.Add(new Mammal("Утконос", 4));
                mammalList.Add(new Mammal("Выхухоль", 4));
                mammalList.Add(new Mammal("Капибара", 4));

                bugList.Add(new Bug("Жук-Геркулес", 6));
                bugList.Add(new Bug("Императорский жук-черепаха", 6));
                bugList.Add(new Bug("Жук-носорог", 6));
                bugList.Add(new Bug("Скарабей", 6));
                bugList.Add(new Bug("Листотел", 6));

                fishList.Add(new Fish("Рыба-капля", 0));
                fishList.Add(new Fish("Летучая рыба", 0));
                fishList.Add(new Fish("Иглобрюх", 0));
                fishList.Add(new Fish("Чёрная химера", 0));
                fishList.Add(new Fish("Латимерия", 0));
            
            Console.WriteLine("Сколько животных надо выбрать?");
            uint numberAnimals = uint.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < numberAnimals; i++)
            {
                int a = random.Next(0, 3);
                switch (a)
                {
                    case 0: int b = random.Next(0, 5); 
                        mammalList[b].Info();
                        break;
                    case 1: b = random.Next(0, 5);
                        bugList[b].Info();
                        break;
                    case 2: b = random.Next(0, 5);
                        fishList[b].Info();
                        break;
                }
                
            }
            
        }
    }
}

