using Internal;
using System;

namespace NewTestingRepo
{
    public class NewClass
    {
        public string SomeTekst { get; set; }


        var tekst = "NewRepo";
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            NewClass someClass = new NewClass();
            string sometext = someClass.SomeTekst = "NewRepo";
            Console.WriteLine(sometext);
        }
    }

}