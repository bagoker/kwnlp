using System;

namespace kwnlp
{
    public class Lib
    {
        public Lib()
        {
            Console.WriteLine("Hello! I am initialised.");
        }
        private string greeting;
        public string Greeting
        {
            get => greeting;
            set => greeting = value;
        }
        public string GreetMe(string words)
        {
            Greeting = words;
            return Greeting;
        }
    }
}