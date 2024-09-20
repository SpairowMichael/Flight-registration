using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security;

namespace learn
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sector = { 0, 6, 28, 15, 15, 17 };
            int[] sectorCost = { 0, 20000, 15000, 10000, 5000, 5000 };
            int userSector, userSeatAmount;
            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("\n");

                Console.SetCursorPosition(0, 25);
                for (int i = 1; i < sector.Length; i++)
                {
                    Console.WriteLine($"Sector{i} have {sector[i]} free seats");

                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Flight Registration");
                Console.WriteLine("\n\n1 - book a seat \n2 - quit the program\n\n");

                Console.Write("Choose the command: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:

                        Console.Write("Which sector u want to flight: ");
                        userSector = Convert.ToInt32(Console.ReadLine());

                        if (sector.Length <= userSector || userSector <= 0)
                        {
                            Console.WriteLine("eRROR! This sector doesn't exist");
                            break;
                        }

                        Console.Write("How many seats u want book?: ");
                        userSeatAmount = Convert.ToInt32(Console.ReadLine());

                        if (sector[userSector] < userSeatAmount || userSeatAmount < 0)
                        {
                            Console.WriteLine($"eRROR! Sector{userSector} don't have so many seats. Sector have only {sector[userSector]} seats");
                            break;
                        }
                        else
                        {
                            sector[userSector] -= userSeatAmount;
                            Console.WriteLine("Booking is successful");

                            Console.Write("Want to pay?(yes/no): ");
                            string answer = Console.ReadLine();

                            if (answer == "yes")
                            {
                                Console.Clear();

                                for (int i = 1; i < sector.Length; i++)
                                {
                                    
                                    //должно быть по пунктам(кост1: 20000, кост2:0 итд, тчоб по логике было)

                                }

                                int totalCost = 0;

                                totalCost = userSeatAmount * sectorCost[userSector];

                                Console.WriteLine($"SECTOR{userSector}: {userSeatAmount}");
                                Console.WriteLine("\n");
                                Console.WriteLine($"TOTAL COST: {totalCost}");

                                Console.ReadKey();

                                totalCost = 0;

                                break;
                            }
                            if (answer == "no")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("eRROR!");

                                break;
                            }

                        }
                    case 2:
                        isOpen = false;

                        break;

                    default:
                        Console.WriteLine("eRROR!");

                        break;
                }

                Console.Clear();
            }

        }
    }
                    
}
