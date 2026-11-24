using System;

namespace Homework
{
    public abstract class Animal
    {
        public Animal(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string MakeSound();
        public abstract string Move();

        public void DisplayName()
        {
            Console.WriteLine($"Hayvon: {Name}");
        }
    }

    public class Lion : Animal
    {
        public Lion(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return $"{Name}: Arslon: Rov!";
        }

        public override string Move()
        {
            return $"{Name} yurgizib";
        }
    }

    public class Parrot : Animal
    {
        public Parrot(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return $"{Name}: To‘tiqush: Help!";
        }

        public override string Move()
        {
            return $"{Name} uchib";
        }
    }

    public class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return $"{Name}: Fil: Tup-tup!";
        }

        public override string Move()
        {
            return $"{Name} astoydil yurib";
        }
    }
}