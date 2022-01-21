using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppDemo
{
    public class Calculator
    {
        public T Addition<T>(T key1, T key2)
        {
            dynamic dx = key1, dy = key2;
            return dx + dy;
        }
    }
    public class GenericClass
    {
        static void main(String[] args)
        {
            Calculator math = new Calculator();
            int result =  math.Addition<int>(2, 4);
            Console.WriteLine(result);
        }
        
    }
}
