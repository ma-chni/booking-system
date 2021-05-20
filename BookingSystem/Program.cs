using System;
using System.Collections.Generic;
using System.Threading;

namespace BookingSystem
{
    class Program
    {
        private static string roomId;

        static void Main(string[] args)
        {
            bool isRunning = true;
            string roomName;
            string description;
            int id = 0;
            int i = 0;
            List<DateTime> toReservation = new List<DateTime>();
            List<DateTime> fromReservation = new List<DateTime>();
            List<string> addroom = new List<string>();
            List<string> adddescription = new List<string>();
            List<string> addId = new List<string>();
            string correctUsername = "";
            string correctPassword = "";
            Console.WriteLine("Username: \n");
            Console.Write("Password:");
            Console.SetCursorPosition(9, 0);
            string username = Console.ReadLine();
            Console.SetCursorPosition(9, 2);
            string password = Console.ReadLine();
            Console.Clear();
            while (isRunning == true)
            {
                if (correctUsername == username && correctPassword == password) //Login user
                {
                    //Menu
                    Console.WriteLine("1. Add room");
                    Console.WriteLine("2. List rooms");
                    Console.WriteLine("3. Remove room");
                    Console.WriteLine("4. Make reservation");
                    Console.WriteLine("5. Remove reservation");
                    Console.WriteLine("6. List reservations");
                    Console.WriteLine("7. Exit");
                    Console.WriteLine("> ");
                    Console.SetCursorPosition(1, 7);
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }


                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (input)
                    {
                    case 1: 
                        Console.WriteLine("Name: \n");
                        Console.Write("Description:"); 
                        Console.SetCursorPosition(5, 0);
                        roomName = Console.ReadLine();
                        Console.SetCursorPosition(12, 2);
                        description = Console.ReadLine();
                        addroom.Add(roomName);
                        adddescription.Add(description);
                        Console.Clear();
                        break;
                    case 2: 
                        Console.WriteLine("NAME");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        addroom.ForEach(Console.WriteLine);
                        Console.WriteLine("\t");
                        Console.WriteLine("<Press any key to return to main menu>");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3: 
                        Console.WriteLine("ID");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (string roomname in addroom)
                        {
                            id++;
                            Console.WriteLine($"{id}\t{roomname}");
                        }
                        addroom.RemoveAt(Int32.Parse(Console.ReadLine()) - 1);
                        Console.Clear();
                        Console.WriteLine("Deleted Successfully! Press any button");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4: 
                        Console.WriteLine("ID:\n\nFrom:\n\nTo:");
                        Console.SetCursorPosition(3, 0);
                        roomId = Console.ReadLine();
                        Console.SetCursorPosition(5, 2);
                        DateTime From = DateTime.Parse(Console.ReadLine());
                        Console.SetCursorPosition(3, 4);
                        DateTime To = DateTime.Parse(Console.ReadLine());
                        toReservation.Add(From);
                        fromReservation.Add(To);
                        addId.Add(roomId);
                        Console.Clear();
                        break;
                    case 5: 
                        Console.WriteLine("Room");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (string roomname in addroom)
                        {
                            id++;
                            Console.WriteLine($"{id}" + "\t" + fromReservation[i] + "\t" + toReservation[i]);
                        }
                        addroom.RemoveAt(Int32.Parse(Console.ReadLine()) - 1);
                        Console.Clear();
                        Console.WriteLine("Deleted Successfully! Press any button");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Room\t\tFrom\t\t\tTo");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        foreach (string roomname in addroom)
                        {
                            Console.WriteLine($"{roomname}" + "\t" + fromReservation[i] + "\t" + toReservation[i] );
                        }
                        Console.WriteLine("\t");
                        Console.WriteLine("<Press any key to return to main menu>");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7: 
                        isRunning = false;
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;

                    default:
                        throw new InvalidOperationException("Unknown Item Type");
                }
            }
        }
    }
}





