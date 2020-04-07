using System;
using classLibProjects;
namespace alifConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person(1, "Test");
            p.GetInfo();

        }
    }
}
