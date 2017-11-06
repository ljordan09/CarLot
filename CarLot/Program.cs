using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cart = new ArrayList();
            ArrayList Inventory = new ArrayList();
            Inventory.Add(new Car( "Ford", "\b\b\bF-150", 2017, 42_000));
            Inventory.Add(new Car( "Lincoln", "\b\b\b\bMKX", 2017, 45_000));
            Inventory.Add(new Car( "Ford", "\b\b\b\bEdge", 2017, 32_000));
            Inventory.Add(new Car( "Lincoln", "\b\b\b\bMKC", 2017, 35_000));
            Inventory.Add(new UsedCars( "Ford", "\b\b\bEscape", 2015, 14_000, 47_000));
            Inventory.Add(new UsedCars( "Lincoln", "\b\b\b\bMKX", 2014, 21_000, 29_000));
            Inventory.Add("Cancel your order");

            

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\t\t\tMo Money Truck Lot\n");
                Console.WriteLine("  Make        Model           Year         Price        Mileage");
                Console.WriteLine("=================================================================");

                //for loop a better option here. now i don't need to add "quit" to contructor methods
                for (int i = 0; i < Inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Inventory[i]}");
                }


                /*int count = 0;//initializing int count of the index locations
                foreach (Car line in Inventory)
                {
                    //displays each index location of Inventory ArrayList and assigns...
                    //each a number corresponding to its location
                    Console.WriteLine($"{count + 1} {line}");
                    count++;
                }*/

                Console.WriteLine("=================================================================");
                
                Console.WriteLine("\nPlease select a vehicle by entering a number from the list: \n");
                string input = Console.ReadLine().Trim();
                

                if (!int.TryParse(input, out int selection) || selection > 7  ||selection <= 0) 
                {
                    Console.WriteLine("You must enter a number from the list. Please make another selection:  \n");
                    continue;
                }
                else if(selection == Inventory.Count)
                {
                    Console.WriteLine("You have cancelled your order\n");
                    Environment.Exit(0);
                }
                

                while (repeat)
                {
                    int menuChoice = selection - 1;
                    Car choice = (Car)(Inventory[menuChoice]);
                    Console.WriteLine($"\nYou chose {choice.Make} {choice.Model} {choice.Year} {choice.Price:C}\n");

                    Console.Write("\nWould you like to order this vehicle?\n ");
                    string _yesNo = Console.ReadLine().ToLower().Trim();

                    if (_yesNo == "y" || _yesNo == "yes")
                    {
                        Console.WriteLine($"\nYou've ordered {choice.Make} {choice.Model} {choice.Year} " +
                        $"{choice.Price:C}\n");
                        Console.WriteLine($"{choice.Price:C}\n");
                        Inventory.RemoveAt(selection - 1);
                        break;

                        
                    }
                    else if(_yesNo == "n" || _yesNo =="no")
                    {
                        break;
                       
                    }

                    else
                    {
                        Console.WriteLine("Invalid Input. You must enter yes or no. Try again: \n ");
                        continue;
                    }
                }


                while (repeat)
                {
                    Console.WriteLine("\nWould you like to choose another truck (yes or no)? : \n");
                    string yesNo = Console.ReadLine().ToLower().Trim();
                    if (yesNo == "y" || yesNo == "yes")
                    {
                        break;
                    }
                    else if (yesNo == "n" || yesNo == "no")
                    {
                        Console.WriteLine("Thanks for shopping. A sales representative will contact you within 24 hours.\n");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("You must answer yes or no. Try again: \n");
                        continue;
                    }
                }
                



                //cart.Add(new Receipt(choice.Make, choice.Model, choice.Year(), choice.Price(), q));
                



            }
        }
    }

            
           
            
}
