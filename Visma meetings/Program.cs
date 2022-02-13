using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Visma_meetings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Meeting> meetingList = new List<Meeting>();
            Meeting meeting = new Meeting("susitinkam", "Mantas", "apie nieka realiai", Meeting.category.CodeMonkey,Meeting.type.Live,new DateTime(2022,02,15,15,00,00), new DateTime(2022,02,15,16,00,00));
            //meeting.ToString();
           meetingList.Add(meeting);
            meetingList.Add(new Meeting("Lets meet", "Petras", "About that intern", Meeting.category.TeamBuilding, Meeting.type.InPerson, new DateTime(2022, 02, 14, 08, 00, 00), new DateTime(2022, 02, 14, 12, 00, 00)));
            meetingList.Add(new Meeting("Lets meet again", "Tomas", "About that intern who wants to learn OOP", Meeting.category.TeamBuilding, Meeting.type.InPerson, new DateTime(2022, 02, 15, 08, 00, 00), new DateTime(2022, 02, 15, 11, 00, 00)));
            
            string bandom = Newtonsoft.Json.JsonConvert.SerializeObject(meetingList);

            string url = "C:/Users/Dell/Desktop/Manto/programavimas/testinis.txt";

           if (!File.Exists(url))
            {
                using (StreamWriter sw = File.CreateText(url))
                {
                    sw.Write(bandom);
                }
            }
            Console.WriteLine("1.new meeting \n2.delete meeting \n3.add person to the meeting \n4.remove person from the meeting\n5.list all meetings");
            int pasirinkimas= Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas) 
            {
                case 1: meetingList.Add(new Meeting());
                        string bandom2 = Newtonsoft.Json.JsonConvert.SerializeObject(meetingList);
                      
                    using (StreamWriter sw = File.CreateText(url))
                    {
                        
                        sw.Write(bandom2);
                    }
                    break;
                case 2:
                    Console.WriteLine("witch meeting you want to delete?");
                    
                    foreach (Meeting meetings in meetingList)
                    {
                        Console.WriteLine( meetings.name);
                    }
                    /*
                 using (StreamReader sr = new StreamReader(url))
                    {
                        string line = sr.ReadToEnd();
                        Console.WriteLine(line);
                    }
                    */ 
                    int atsI= Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter responsible Person");
                    string ats = Console.ReadLine();
                    if (ats == meetingList[atsI-1].responsiblePerson)
                    {
                        meetingList.RemoveAt(atsI-1);
                    }
                    string bandom3 = Newtonsoft.Json.JsonConvert.SerializeObject(meetingList);
                    using (StreamWriter sw = File.CreateText(url))
                    {
                        sw.WriteLine(bandom3);
                    }
                    foreach (Meeting meetings in meetingList)
                    {

                        Console.WriteLine(meetings.name);

                    }
                    break;
                case 3: meeting.generatePeople();
                    meeting.people= new List<Person> { new Person() }

                    ; break;
                case 4: meeting.people.RemoveAt(0); break;
                case 5: foreach (Meeting meetings in meetingList)
                    {
                        Console.WriteLine(bandom);
                    }break;
            }
            
            //Console.Write(bandom);
            Console.ReadKey();
        }
    }
}
