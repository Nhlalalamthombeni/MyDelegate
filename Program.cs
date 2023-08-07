using System;
namespace MyDelegation
{
    class program
    {
        delegate int del(int x, int y);
        static void Main(string[] args)
        {
           /* Mark m = new Mark();
            Console.WriteLine(m.AddNumbers(3, 3));
            Console.WriteLine(m.MultiplyNumber(4, 4));
           */

            //using delegateion methods
            Mark m = new Mark();
            del d = m.AddNumbers;
            Console.WriteLine(d(3,4));

            d = m.MultiplyNumber;
            Console.WriteLine(d(3,4));

            d = m.DoAnotherThing;
            Console.WriteLine("Do another thing: "+ d(3,4));
        }
    }
    public class Mark
    {
        public int AddNumbers(int a,int b)
        {
            return a + b;
        }
        public int MultiplyNumber(int a, int b)
        {
            return a * b;
        }
        public int DoAnotherThing(int x,int y)
        {
            return x + (y*3);
        }
    }

}
