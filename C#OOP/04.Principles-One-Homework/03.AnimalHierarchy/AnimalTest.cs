﻿namespace AnimalHierarchy
{
    using Classes;
    using System;
    using System.Linq;
    class AnimalTest
    {
        static void Main()
        {
            Animal[] animals = new Animal[]

            {
                new Dog(3, "Rex", Sex.male),
                new Dog(14, "OldSox", Sex.male),
                new Frog(1, "Froggie", Sex.female),
                new Frog(4, "Qwackstein", Sex.male),
                new Tomcat(6, "Timmy"),
                new Tomcat(14, "Mr. Mittens"),
                new Kitten(7, "FluffBall")
            };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);
            Console.WriteLine("Average age of the dogs: {0}", averageDogsAge);
            Console.WriteLine("Average age of the frogs: {0}", averageFrogsAge);
            Console.WriteLine("Average age of the cats: {0}", averageCatsAge);
        }
    }
}
