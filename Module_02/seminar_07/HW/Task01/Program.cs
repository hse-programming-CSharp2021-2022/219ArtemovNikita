using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter count of creatures:");
            if (!int.TryParse(Console.ReadLine(), out var n) || n is < 0 or > 100)
            {
                Console.WriteLine("less than 0 or greater than 100");
                return;
            }

            var creatures = new Creature[n];

            for (var i = 0; i < n; i++)
            {
                var r = new Random();
                var perc = r.NextDouble();
                var c = r.Next(3, 11);
                var name = "";
                for (var j = 0; j < c; j++)
                {
                    var S = r.Next(65, 91);
                    var s = r.Next(97, 123);
                    if (name.Length > 1)
                    {
                        var or = r.Next(0, 2);
                        if (or == 0)
                        {
                            name += ((char) s).ToString();
                        }
                        else
                        {
                            name += ((char) S).ToString();
                        }
                    }
                    else
                    {
                        name += ((char) S).ToString();
                    }
                }

                var sp = r.Next(10, 19);
                if (perc - 0.2 < 0)
                {
                    creatures[i] = new Creature(name, sp);
                }
                else if (perc is > 0.2 and < 0.6)
                {
                    var str = r.Next(-50, 51);
                    creatures[i] = new Dwarf(name, sp, str);
                }
                else
                {
                    creatures[i] = new Elf(name, sp);
                }
            }

            var count = 0;
            foreach (var creature in creatures)
            {
                Console.WriteLine(creature);
                if (creature is Dwarf)
                {
                    count++;
                }
            }

            Dwarf dw = new Dwarf("fd", 10, 12);
            for (var i = 0; i < count; i++)
            {
                dw.MakeNewStaff();
            }

            Console.WriteLine("if u want to break the program - click enter. ");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                return;
            }
        }
    }
}

class Creature
{
    public string Name { get; }

    private double _speed;

    public double Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException("Speed has to be greater then 0");
            _speed = value;
        }
    }

    public Creature(string name, double speed)
    {
        (Name, Speed) = (name, speed);
    }

    public virtual string Run()
    {
        return $"I am running with such high speed as {Speed}. ";
    }

    public override string ToString()
    {
        return Run() + $"My name is {Name}. ";
    }
}

class Dwarf : Creature
{
    private int _strength;
    
    public int Strength
    {
        get
        {
            return _strength;
        }
        set
        {
            if (value < 1 || value > 20)
            {
                var r = new Random();
                _strength = r.Next(1, 21);
            }
            else
            {
                _strength = value;
            }
        }
    }

    public Dwarf(string name, double speed, int strength) : base(name, speed)
    {
        Strength = strength;
    }

    public new string Run()
    {
        return base.Run() + $"My strength is {Strength}. ";
    }

    public void MakeNewStaff()
    {
        Console.WriteLine("I've created new staff!");
    }

    public override string ToString()
    {
        return Run() + $"My name is {Name}. ";
    }
}

class Elf : Creature
{
    public int Age { get; }

    public Elf(string name, double speed) : base(name, speed)
    {
        var r = new Random();
        Age = r.Next(100, 201);
        Speed = speed + Age / 77;
    }

    public new string Run()
    {
        return base.Run() + $"My age is {Age}. ";
    }
    
    public override string ToString()
    {
        return Run() + $"My name is {Name}. ";
    }
}
