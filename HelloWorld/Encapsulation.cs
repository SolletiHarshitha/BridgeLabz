using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Encapsulation
    {
        private String dogBreed;
        private string dogSize;

        public String Breed
        {

            get
            {
                return dogBreed;
            }

            set
            {
                dogBreed = value;
            }

        }
        public string GetDogsize()
        {
            return dogSize;
        }
        public void SetDogsize(string value)
        {
            dogSize = value;
        }
    }
}
