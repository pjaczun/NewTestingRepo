using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NewClass someClass = new NewClass();
            string sometext = someClass.SomeTekst = "NewRepo";
            Console.WriteLine(sometext);
            Console.WriteLine("lol");
        }
    }
}
