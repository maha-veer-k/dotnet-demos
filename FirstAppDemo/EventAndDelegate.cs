using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppDemo
{
    internal class EventAndDelegate
    {
        public static void main(String[] args)
        {
            Addition addition = new Addition();
            addition.Eventdelegate += new Addition.mydelegate(print);
            addition.add(2, 5);

            static void print()
            {
                Console.WriteLine("the result is an odd number !!!!!!");
            }
        }
    }

    class Addition
    {
        public delegate void mydelegate();
        public event mydelegate Eventdelegate;

        public void add(int num1, int num2)
        {
            int c = num1 + num2;
            if (c % 2 == 0)
            {
                Eventdelegate();
            }
        }
    }
}
