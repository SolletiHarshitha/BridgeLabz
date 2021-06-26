using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Polymorphism
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animals make sounds");
        }
    }
    class Doggie : Polymorphism
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says : bow bow");
        }
    }
    class Cat : Polymorphism
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says : meow meow");
        }
    }
}
