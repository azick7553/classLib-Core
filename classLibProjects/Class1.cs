using System;

namespace classLibProjects
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public Person(int Id, string FullName)
        {
            this.Id = Id;
            this.FullName = FullName;
        }
        public Person()
        {

        }
        public void GetInfo()
        {
            System.Console.WriteLine($"ID: {this.Id}\nFullName: {this.FullName}");
        }
    }
}
