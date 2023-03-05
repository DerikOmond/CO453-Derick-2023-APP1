using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DistanceConverter
    {
        private const int FEET_IN_MILES = 5280;
        private const double METRES_IN_MILES = 1609.34;
        private const int YARDS_IN_MILES = 1760;
        private const double KILOMETRES_IN_MILES = 1.60934;
        private const int INCHES_IN_MILES = 63360;
        private const double FEET_IN_METRES = 3.28084;
        private const int FEET_IN_YARDS = 3;
        private const double FEET_IN_KILOMETRES = 3280.84;
        private const int INCHES_IN_FEET = 12;
        private const double METRES_IN_YARDS = 1.09361;
        private const int METRES_IN_KILOMETRES = 1000;
        private const double INCHES_IN_METRES = 39.3701;
        private const double YARDS_IN_KILOMETRES = 1093.61;
        private const int INCHES_IN_YARDS = 36;
        private const double INCHES_IN_KILOMETRES = 39379.1;

        private const string MILES = "miles";
        private const string FEET = "feet";
        private const string METRES = "metres";
        private const string YARDS = "yards";
        private const string KILOMETRES = "kilometres";
        private const string INCHES = "inches";

        private double miles;
        private double feet;
        private double metres;
        private double yards;
        private double kilometres;
        private double inches;

        private int userChoice1;
        private int userChoice2;

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        private bool invalidChoice1 = false;
        private bool invalidChoice2 = false;

        private bool retry;

        public void Run()
        {
            DisplayHeader();

            do
            {
                UserSelect();
                PromptUser(fromUnit, toUnit);
                TryAgain();
            }
            while (true);
        }

        public void DisplayHeader()
        {
            Console.WriteLine("\n==========================================================================================");
            Console.WriteLine("========                         App01 Distance Converter                         ========");
            Console.WriteLine("========                             By Derick Omondi                             ========");
            Console.WriteLine("==========================================================================================\n");
            Console.Write("Press enter to start\n>");
            Console.ReadLine();
        }

        private void PromptUser(String unit1, String unit2)
        {
            Console.WriteLine($"\nYou are converting from {unit1} to {unit2}.");
        }

        private void UserSelect()
        {
            do
            {
                FirstUserSelection();
                SecondUserSelection();

                if(sameOptionsChecker())
                {
                    Console.WriteLine("\nYOU CANNOT CONVERT FROM THIS UNIT BACK TO ITSELF.\nTRY AGAIN WITH DIFFERENT UNITS.");
                }
            }
            while (true);
        }

        private void UserOptions()
        {
            Console.WriteLine($"1. {MILES}");
            Console.WriteLine($"2. {FEET}");
            Console.WriteLine($"3. {METRES}");
            Console.WriteLine($"4. {YARDS}");
            Console.WriteLine($"5. {KILOMETRES}");
            Console.WriteLine($"6. {INCHES}");
            Console.WriteLine("");
            Console.Write("> ");
        }

        private void FirstUserSelection()
        {
            do
            {
                invalidChoice1 = false;

                Console.WriteLine("\nPlease select the number corrosponding to the unit of measurement you would like to convert from. \n");
                UserOptions();
                string firstUserChoice = Console.ReadLine();
                this.userChoice1 = Convert.ToUInt16(firstUserChoice);

                if (userChoice1 == 1)
                {
                    fromUnit = MILES;
                    fromDistance = miles;

                }
                else if (userChoice1 == 2)
                {
                    fromUnit = FEET;
                    fromDistance = feet;
                }
                else if (userChoice1 == 3)
                {
                    fromUnit = METRES;
                    fromDistance = metres;
                }
                else if (userChoice1 == 4)
                {
                    fromUnit = YARDS;
                    fromDistance = yards;
                }
                else if (userChoice1 == 5)
                {
                    fromUnit = KILOMETRES;
                    fromDistance = kilometres;
                }
                else if (userChoice1 == 6)
                {
                    fromUnit = INCHES;
                    fromDistance = inches;
                }
                else
                {
                    InvalidChoice();
                }
            }
            while (invalidChoice1 == true);
        }

        private void SecondUserSelection() 
        {
            do
            {
                invalidChoice2 = false;

                Console.WriteLine("\nSelect the unit you would like to convert to. \n");
                UserOptions();
                string secondUserChoice = Console.ReadLine();
                this.userChoice2 = Convert.ToUInt16(secondUserChoice);

                if (userChoice2 == 1)
                {
                    toUnit = MILES;
                    toDistance = miles;
                }
                else if (userChoice2 == 2)
                {
                    toUnit = FEET;
                    toDistance = feet;
                }
                else if (userChoice2 == 3)
                {
                    toUnit = METRES;
                    toDistance = metres;
                }
                else if (userChoice2 == 4)
                {
                    toUnit = YARDS;
                    toDistance = yards;
                }
                else if (userChoice2 == 5)
                {
                    toUnit = KILOMETRES;
                    toDistance = kilometres;
                }
                else if (userChoice2 == 6)
                {
                    toUnit = INCHES;
                    toDistance = inches;
                }
                else
                {
                    InvalidChoice();
                }
            }
            while (invalidChoice2 == true);
        }

        private void InvalidChoice()
        {
            Console.WriteLine("\nTHAT IS AN INVALID OPTION!!");
            invalidChoice1 = true;
            invalidChoice2 = true;
        }

        private bool sameOptionsChecker() 
        {
            if (this.userChoice1 == this.userChoice2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TryAgain()
        {
            Console.Write("\nWould you like to try again?(enter 'yes', 'ye', 'y' or 'yeah').\n>");
            string repetition = Console.ReadLine();

            if (repetition.Equals("yes") || repetition.Equals("ye") || repetition.Equals("y") || repetition.Equals("yeah"))
            {
                retry = true;
            }
            else
            {
                retry = false;
                Console.Write("\nGoodbye...");
                Console.ReadLine();
                Environment.Exit(1);
            }
        }
    }
}
