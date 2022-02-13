using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visma_meetings
{
    internal class Meeting
    {  
        public List<Person> people { get; set; }
        
        public string name { get; set; }
        public string responsiblePerson { get; set; }
        public string description { get; set; }
        public enum category
        {
            CodeMonkey = 1,
            Hub = 2,
            Short = 3,
            TeamBuilding = 4
        }
        public enum type
        {
            Live= 1,
            InPerson= 2,
        }
        public DateTime startDate;

        public DateTime endDate;
        public category category2;
        public type type2;

        public void checking(Person o)
        {
            if (o.name == people[0].name)
            {
                Console.WriteLine("Cannot add, matching names.");
            }
        }
         public void generatePeople()
        {
            people.Add(new Person("Jonas", "Jonaitis", 25));
            people.Add(new Person("Mindaugas", "Mindaugela", 28));
            people.Add(new Person("Tadas", "Tadusinskas", 29));
            people.Add(new Person("Tomas", "Tamasauskas", 18));
            people.Add(new Person("Andrej", "Andrejav", 30));
            people.Add(new Person("Viktoras", "Viktorevicius", 30));
            people.Add(new Person("Mantas", "Mantlevicius", 30));
            people.Add(new Person("Sofija", "Sofijauskiene", 30));
            people.Add(new Person("Ligita", "Ligitaviciene", 30));
            people.Add(new Person("Zygis", "Zygevicius", 30));
        }

        public void ToString()
        {
            Console.WriteLine($"name:{name} \nresponsiblePerson:{responsiblePerson}\ndescription:{description}\ncategory:{category2}\ntype:{type2}\nstartDate:{startDate}\nendDate:{endDate}");

        }

        public Meeting()
        {
            Console.WriteLine("Meeting name:");
            name = Console.ReadLine();
            Console.WriteLine("Responsible person in a meeting:");
            responsiblePerson = Console.ReadLine();
            Console.WriteLine("Description about the meeting");
            description = Console.ReadLine();
            Console.WriteLine("Choose category of a meeting:\n1.CodeMonkey\n2.Hub\n3.Short\n4.TeamBuilding");
            int chosenCatNumber = Convert.ToInt32(Console.ReadLine());
        
            switch (chosenCatNumber)
            {
                case 1: category2 = category.CodeMonkey; break;
                case 2: category2 = category.Hub; break;
                case 3: category2 = category.Short; break;
                case 4: category2 = category.TeamBuilding; break;
            }
            Console.WriteLine("Choose a type of meeting:\n1.Live \n2.In person");
            int chosenTypeNumber = Convert.ToInt32(Console.ReadLine());
            
            switch (chosenTypeNumber)
            {
                case 1: type2 = type.Live; break;
                case 2: type2 = type.InPerson; break;
            }
            Console.WriteLine("Enter date when meeting will start.\nYear yyyy");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month mm");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("day dd");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hour hh");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minutes");
            int minute = Convert.ToInt32(Console.ReadLine());
            startDate = new DateTime(years, month, day, hour, minute, 00);


            Console.WriteLine("Enter date when meeting will end.\nYear yyyy");
            int yearsE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month mm");
            int monthE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("day dd");
            int dayE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hour hh");
            int hourE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minutes");
            int minuteE = Convert.ToInt32(Console.ReadLine());
            endDate = new DateTime(yearsE, monthE, dayE, hourE, minuteE, 00);
        }

        public Meeting(string name, string responsiblePerson, string description, category category, type type, DateTime startDate, DateTime endDate)
        {
            this.name = name;
            this.responsiblePerson = responsiblePerson;
            this.description = description;
            this.category2 = category;
            this.type2 = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
