using System;

namespace kwnlp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Lib helloWorld = new Lib();
            Console.WriteLine(helloWorld.GreetMe("What's up?"));
        }
    }
}
