using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppDemo
{
    public delegate void mydelegate(String msg);

    public class DelegateMethods
    {
        public void func1(String msg)
        {
            Console.WriteLine("hiii " + msg);
        }

        public void func2(String msg)
        {
            Console.WriteLine("hello " + msg);
        }

        public void func3(String msg)
        {
            Console.WriteLine("hey " + msg);
        }
    }
    internal class ImplementDelegates
    {
        public static void main(String[] args)
        {
            DelegateMethods delegateMethods = new DelegateMethods();
            mydelegate del1 = new mydelegate(delegateMethods.func1);
            del1("mahaveer");
            mydelegate del2 = new mydelegate(delegateMethods.func2);
            del2("mithlesh");
            mydelegate del3 = new mydelegate(delegateMethods.func3);
            del3("ujjwal");
            mydelegate del = new mydelegate(delegateMethods.func1);
            del += new mydelegate(delegateMethods.func2);
            del += new mydelegate(delegateMethods.func3);
            Console.WriteLine("----------------------------");
            del -= new mydelegate(delegateMethods.func2);


        }
    }
}
