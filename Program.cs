using Endproject;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace CricketAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fast Pace Cricket Academy");
        repeat:
            Console.WriteLine("Press 1 to Add Player \nPress 2 to Remove Player \nPress 3 to Get Player Details by ID \nPress 4 to Get Player Details by Name \nPress 5 to Get All Players' Details \n");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                
                    OneDayTeam p1 = new OneDayTeam();
                    if (OneDayTeam.Oneday.Count != OneDayTeam.Oneday.Capacity)
                    {
                        Console.Write("Enter Player ID:");
                        p1.Player_ID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Player's Name:");
                        p1.Player_Name = Console.ReadLine();
                        Console.Write("Enter Player's Age:");
                        p1.Player_Age = Convert.ToInt32(Console.ReadLine());

                        p1.Add(p1);
                    }
                    else
                    {
                        Console.WriteLine("Can't enter more than 11 players in a team");
                        goto repeat;
                    }
                    break;
                case 2:
                    OneDayTeam p2 = new OneDayTeam();
                    Console.Write("Enter Player ID to remove player details:");
                    int id1 = Convert.ToInt32(Console.ReadLine());
                    p2.Remove(id1);
                    break;
                case 3:
                    OneDayTeam p3 = new OneDayTeam();
                    Console.Write("Enter Player ID to search:");
                    int id2 = Convert.ToInt32(Console.ReadLine());
                    Player P1 = p3.GetPlayerById(id2);
                    Console.WriteLine($" Player ID = {P1.Player_ID} \n Player Name = {P1.Player_Name} \n Player Age={P1.Player_Age}");
                    break;
                case 4:
                    OneDayTeam p4 = new OneDayTeam();
                    Console.Write("Enter Player Name to search:");
                    string pname = Console.ReadLine();
                    Player P2 = p4.GetPlayerByName(pname);
                    Console.WriteLine($" Player ID = {P2.Player_ID} \n Player Name = {P2.Player_Name} \n Player Age={P2.Player_Age}");
                    break;
                case 5:
                    Console.WriteLine("All Player Details:::");
                    List<Player> P = new List<Player>();
                    OneDayTeam team = new OneDayTeam();
                    P = team.GetAllPlayers();
                    foreach (var item in P)
                    {
                        Console.WriteLine($"========================= \n Player ID = {item.Player_ID} \n Player Name = {item.Player_Name}  \n Player Age={item.Player_Age} \n=========================");
                    }
                    break;
            }
            Console.WriteLine("Do you want to continue y/n");
            string ji = Console.ReadLine();
            if (ji == "y")
            {
                goto repeat;
            }
            else if(ji == "n")
            {
                Console.WriteLine("Thank you for visiting!!!");
            }
            Console.ReadLine();
        }
    }
}