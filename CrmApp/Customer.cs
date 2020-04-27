using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class Customer
    {

        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name={Name} Gender={Gender} Age={Age} ";

        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ToString());
            Console.WriteLine();
        }
    }

   
}
