using System;
using System.Collections.Generic;
using System.Text;
using PortAdministration.Methods;
using PortAdministration.Models;

namespace PortAdministration
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int dayCount = 1;                  
            

            //Initialize Total number of  PortSlot
            int[] totalNumberOfPortSlot = new int[25];

            //Initialize array for holding boat names
            string[] boatPlacedInSlots = new string[25];

            //Initialize Type of Boat Variable 
            string[] boatTypeVariable = new string[25];

            //Initialize array for Boats Day in and Day out            
            int[] DayIn = new int[25];
            int[] DayOut = new int[25];

            //Initialize generated Boat of a day
            string[] boatsOfADay = new string[5];


            //Initialize rejected boats of an day
            int rejectedboat = 0;

            //Initialize Free slot count
            int freeSlot = 0;

            //Initialize rowbaot dayin dayout

            int[] dayInRow = new int[25];
            int[] dayOutRow = new int[25];
            string[] secondRowBoat = new string[25];
            string[] boatTypeVaraibleRowBoat = new string[25];

            //Initialize prefix array
            string[] prefixArray = new string[25];




            int[] dailyBoats = new int[5];
            do
            {                      
                //Generate 5 random boats for a day.
                for (int i = 0; i < dailyBoats.Length; i++)
                {

                    string boatgenrated = GenerateRandomBoat.GenerateBoatNameWithPrefix();
                    boatsOfADay[i] = boatgenrated;

                    int index = boatgenrated.IndexOf('-');
                    string prefix = boatgenrated.Substring(0, index);

                    //assigning prefix
                    for (int j = 0; j < 25; j++)
                    {
                       
                            if (boatPlacedInSlots[j] != null && boatPlacedInSlots[j]!="")
                            {
                                int index1 = boatPlacedInSlots[j].IndexOf('-');
                                string prefix1 = boatPlacedInSlots[j].Substring(0, index1);
                                prefixArray[j] = prefix1;
                            }
                        


                     }
                    



                    switch (prefix)
                    {
                        case "R":
                            for (int j = 0; j < totalNumberOfPortSlot.Length; j++)
                            {
                                
                                

                                if((prefixArray[j]=="R"&& secondRowBoat[j]==null)|| (prefixArray[j] == "R" && secondRowBoat[j] == ""))
                                {                                   

                                        secondRowBoat[j] = boatgenrated.ToString();
                                        dayInRow[j] = dayCount;
                                        dayOutRow[j] = dayCount + 1;
                                        boatTypeVaraibleRowBoat[j] = "RowBoat";

                                        break;
                                   
                                }
                                else if(prefixArray[j]==""&&secondRowBoat[j]!=null)
                                {
                                    boatPlacedInSlots[j] = boatgenrated.ToString();
                                    DayIn[j] = dayCount;
                                    DayOut[j] = dayCount + 1;
                                    boatTypeVariable[j] = "RowBoat";
                                    break;

                                }
                                
                                else
                                {
                                    
                                    if (boatPlacedInSlots[j] == null || boatPlacedInSlots[j] == "")
                                    {
                                        boatPlacedInSlots[j] = boatgenrated.ToString();
                                        DayIn[j] = dayCount;
                                        DayOut[j] = dayCount + 1;
                                        boatTypeVariable[j] = "RowBoat";
                                        break;
                                    }
                                }

                                

                            }
                                break;
                        case "M":
                            for (int j = 0; j < totalNumberOfPortSlot.Length; j++)
                            {
                                if (boatPlacedInSlots[j] == null || boatPlacedInSlots[j] == "")
                                {
                                    boatPlacedInSlots[j] = boatgenrated.ToString();
                                    DayIn[j] = dayCount;
                                    DayOut[j] = dayCount + 3;
                                    boatTypeVariable[j] = "MotorBoat";
                                    break;
                                }                               

                            }
                            break;

                        case "S":
                            for (int j = 0; j < totalNumberOfPortSlot.Length; j++)
                            {   if (j < 24)
                                {
                                    if ((boatPlacedInSlots[j] == null && boatPlacedInSlots[j + 1] == null)||(boatPlacedInSlots[j]==""&& boatPlacedInSlots[j+1] == ""))
                                    {
                                        boatPlacedInSlots[j] = boatgenrated.ToString();
                                        boatPlacedInSlots[j + 1] = boatgenrated.ToString();
                                        DayIn[j] = dayCount;
                                        DayIn[j + 1] = dayCount;
                                        DayOut[j] = dayCount + 4;
                                        DayOut[j + 1] = dayCount + 4;
                                        boatTypeVariable[j] = "SailBoat";
                                        boatTypeVariable[j + 1] = "SailBoat";
                                        break;
                                    }
                                }

                            }
                            break;

                        case "C":
                            for (int j = 0; j < totalNumberOfPortSlot.Length; j++)
                            {
                                if (j < 22)
                                {
                                    if ((boatPlacedInSlots[j] == null && boatPlacedInSlots[j + 1] == null && boatPlacedInSlots[j + 2] == null && boatPlacedInSlots[j + 3] == null)
                                        ||(boatPlacedInSlots[j] == ""&& boatPlacedInSlots[j+1] == ""&& boatPlacedInSlots[j+2] == ""&& boatPlacedInSlots[j+3] == ""))
                                    {
                                        boatPlacedInSlots[j] = boatgenrated.ToString();
                                        boatPlacedInSlots[j + 1] = boatgenrated.ToString();
                                        boatPlacedInSlots[j + 2] = boatgenrated.ToString();
                                        boatPlacedInSlots[j + 3] = boatgenrated.ToString();
                                        DayIn[j] = dayCount;
                                        DayIn[j + 1] = dayCount;
                                        DayIn[j + 2] = dayCount;
                                        DayIn[j + 3] = dayCount;
                                        DayOut[j] = dayCount + 6;
                                        DayOut[j + 1] = dayCount + 6;
                                        DayOut[j + 2] = dayCount + 6;
                                        DayOut[j + 3] = dayCount + 6;
                                        boatTypeVariable[j] = "CargoShip";
                                        boatTypeVariable[j + 1] = "CargoShip";
                                        boatTypeVariable[j + 2] = "CargoShip";
                                        boatTypeVariable[j + 3] = "CargoShip";
                                        break;
                                    }
                                }

                            }

                            break;
                    }
                   
                }
                

                // write a function to clear slots if its date expires 
                for (int i = 0; i < 25; i++)
                {
                    if (DayOut[i] == dayCount)
                    {
                        boatPlacedInSlots[i] = "";
                        DayIn[i] = 0;
                        DayOut[i] = 0;
                        boatTypeVariable[i] = "";
                        prefixArray[i] = "";
                    }

                    if(dayOutRow[i]==dayCount)
                    {
                        secondRowBoat[i] = "";
                        dayInRow[i] = 0;
                        dayOutRow[i] = 0;
                        boatTypeVaraibleRowBoat[i] = "";
                        prefixArray[i] = "";
                    }


                }



                //Print the output               
                Console.WriteLine($"Day {dayCount}\n");
                Console.WriteLine($"---Generated boats in day {dayCount}----");
                for (int i = 0; i < dailyBoats.Length; i++)
                {
                    Console.WriteLine(boatsOfADay[i]);
                }
                //Rejected boats of the day
                foreach (var boat in boatsOfADay)
                {

                    int resultPosition = Array.IndexOf(boatPlacedInSlots, boat);

                    if (resultPosition < 0)
                    {

                        rejectedboat++;
                    }

                }
                //Free slots
                foreach (var boat in boatPlacedInSlots)
                {
                    if (boat == null || boat == "")
                        freeSlot++;

                }
                Console.WriteLine("\n--Boat placed in slots list--");
                // Console.WriteLine("Plats \t BoatType\t\t BoatName\t\tDayIn\t\tDayOut");
                Console.WriteLine("Slot \t BoatType\t\t BoatName");

                for (int k = 0; k < totalNumberOfPortSlot.Length; k++)
                {
                   

                    Console.WriteLine($"{k}\t {boatTypeVariable[k]}\t\t{boatPlacedInSlots[k]}\t\t\t{DayIn[k]}\t\t\t{DayOut[k]}");
                    //Console.WriteLine($"{k}\t {boatTypeVariable[k]}\t\t{boatPlacedInSlots[k]}");
                    if (secondRowBoat[k]!=null && secondRowBoat[k]!="")            
                    {
                       
                       Console.WriteLine($"{k}\t {boatTypeVaraibleRowBoat[k]}\t\t{secondRowBoat[k]}\t\t\t{dayInRow[k]}\t\t\t{dayOutRow[k]}");


                    }
                }




                Console.WriteLine($"Number of Rejected Boats in day {dayCount} is {rejectedboat}");
                Console.WriteLine($"Number of Free slots in day {dayCount} is {freeSlot}");

                Console.WriteLine("----------Enter any key for next day------");
                if(Console.ReadKey().Key == ConsoleKey.Enter)               

                //Increment daycount
                dayCount++;

                //resetting rejected boat
                rejectedboat = 0;
                //resetting free slots count
                freeSlot = 0;

            } while (true);


        }
        

    }
}
