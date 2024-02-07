using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int startHunger = random.Next(90, 100);
            int startThirst = random.Next(60, 70);
            int startEnergy = random.Next(60, 70);


            VirtualPet userPet = new VirtualPet();
            userPet.Hunger = startHunger;
            userPet.Thirst = startThirst;
            userPet.Energy = startEnergy;

            Console.Clear();



            Console.WriteLine("Hello \nLet's start by choosing an animal you'd like to have as a VirtualPet.\nPlease enter the number 1,2,3 that corresponds to your animal choice.");

            List<string> animalTypes = new List<string>();
            animalTypes.Add("Dog");
            animalTypes.Add("Cat");
            animalTypes.Add("Rabbit");

            for (int i = 0; i < animalTypes.Count; i++)
            {
                int menuNumber = i + 1;
                Console.WriteLine("\tPress {0} for {1}.", menuNumber, animalTypes[i]);
            }

            int animalChoice = int.Parse(Console.ReadLine());

            while (animalChoice < 1 || animalChoice > animalTypes.Count)
            {
                Console.WriteLine("You must choose a number from the options!");
                animalChoice = int.Parse(Console.ReadLine());
            }


            if (animalChoice == 1)
            {
                userPet.PetType = animalTypes[animalChoice - 1];

            }
            else if (animalChoice == 2)
            {
                userPet.PetType = animalTypes[animalChoice - 1];
            }
            else (animalChoice == 3)
            {
                userPet.PetType = animalTypes[animalChoice - 1];
            }
           

            Console.Clear();
            Console.WriteLine("before we begin.\nWhat would you like to name your pet?");
            userPet.PetsName = Console.ReadLine();
            Console.Clear();

            do
            {

                userPet.ShowPetStatus();

                //user menu
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\tPress 1 to feed {0}.", userPet.PetsName);
                Console.WriteLine("\tPress 2 to give {0} water.", userPet.PetsName);
                Console.WriteLine("\tPress 3 to play with {0}.", userPet.PetsName);
                Console.WriteLine("\tPress 4 to quit the game.");

                int userMethodChoice = int.Parse(Console.ReadLine());

                while (userMethodChoice < 1 || userMethodChoice > 4)
                {
                    Console.WriteLine("You must choose an option from the menu!\nWhat would you like to do?");
                    userMethodChoice = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                switch (userMethodChoice)
                {

                    case 1:
                        {
                            userPet.FeedPet();
                        }
                        break;

                    case 2:
                        {
                            userPet.WaterPet();
                        }
                        break;

                    case 3:
                        {
                            userPet.PlayWithPet();
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("{0} says, \"You're leaving me?\"", userPet.PetsName);
                            Console.WriteLine("You're guilty of animal neglect...");
                            Environment.Exit(0);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("{0)} says, \"Thanks for the extra food!\"", userPet.PetsName);
                            userPet.FeedPet();
                            break;
                        }


                }


                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

            } while (userPet.PetSatisfaction <= 90);

            Console.WriteLine("\nCongratulations {0}!\nYou have successfully provided for {1} the {2} today!\nThe game will now close!", userPet.PetsName, userPet.PetType);
            Environment.Exit(0);
        }

    }





}
