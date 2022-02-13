using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visma_meetings
{
    internal class Person
    {
        public event EventHandler check;
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public bool responsible { get; set; }


        public static void deleteMeeting(Meeting ob) 
        {
            Console.WriteLine("who is responsible?");

        }
        public void watchAction(Person p)
        {
            check += 
        }

      

        public Person() 
        {
            Console.WriteLine("enter your name");
            name =Console.ReadLine();
            
            Console.WriteLine("enter your last name");
            lastName = Console.ReadLine();
            Console.WriteLine("enter your age");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public Person(string name, string lastName,int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
