using System;

namespace Inheritance
{
    public class Student_Committee
    {
        public string Gen_Secretary;
        public string Treasurer;
        public string Event_head;
        public void Event_Details()
        {
            Console.WriteLine("General Secretary - {0}", Gen_Secretary);
            Console.WriteLine("Treasurer - {0}", Treasurer);
            Console.WriteLine("Event head - {0}", Event_head);
        }       
    }
    public class Event : Student_Committee
    {
        public void Treasure_Hunt()
        {
            int No_of_players_in_a_team = 4;
            int Pay_per_team = 120;
            Console.WriteLine("");
            Console.WriteLine("For Treasure Hunt - ");
            Console.WriteLine("No of Players in a team = {0}", No_of_players_in_a_team);
            Console.WriteLine("Per Team Pay = {0}/-", Pay_per_team);
            Console.WriteLine("");
        }
        public void Housie()
        {
            int Per_ticket =20;
            Console.WriteLine("For Housie - ");
            Console.WriteLine("Amount per ticket ={0}/-", Per_ticket);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student_Committee SC = new Student_Committee();
            SC.Gen_Secretary = "Richa";
            SC.Treasurer = "Ayush";       
            SC.Event_head = "Isha";

            SC.Event_Details();

            Event E = new Event();
            E.Treasure_Hunt();
            E.Housie();
        }
    }
}
