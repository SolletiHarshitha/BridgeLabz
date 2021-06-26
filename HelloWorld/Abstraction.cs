using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    abstract class Abstraction
    {
        public abstract int age();
    }
    class Dog : Abstraction
    {

        private int dogAge;
        public Dog(int x = 0)
        {
            dogAge = x;
        }

        public override int age()
        {
                Console.Write("The age of Dog is: ");
                return (dogAge);
        }
    }
}
