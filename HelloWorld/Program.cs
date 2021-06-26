using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.Addition(5,2);
            Console.WriteLine();
           // Console.WriteLine("Hello");
           // Console.WriteLine("HI");
           // Console.WriteLine("Adding newline in practisebranch");
          //  Console.WriteLine("performing merge command");
          //  Console.WriteLine("latest code from remote area");
            Abstraction abs = new Dog(5);
            int result = abs.age();
            Console.WriteLine("{0}",result);
            Console.WriteLine();
            Encapsulation en = new Encapsulation();
            en.Breed = "Chow Chow";
            Console.WriteLine("The Breed of the Dog is : "+en.Breed);
            en.SetDogsize("Small");
            Console.WriteLine("The size of the Dog is : "+en.GetDogsize());
            Console.WriteLine();
            Student s = new Student();
            s.display("Raghu",13);
            Console.WriteLine();
            Polymorphism poly = new Polymorphism();
            Polymorphism d = new Doggie();
            Polymorphism c = new Cat();
            poly.animalSound();
            d.animalSound();
            c.animalSound();
        }
    }
}
