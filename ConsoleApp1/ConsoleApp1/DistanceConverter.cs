/// <summary>
/// This application has been designed to allow a user to input a value in a selection
/// of SI units they can choose from and convert it to another.
/// </summary>
/// <author>
/// Derick Omondi version 1.0
/// </author>

//Dependancies
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Class
    class DistanceConverter
    {
        //All of conversion factors required between each combination of units.
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

        //Repeatedly used strings that change according to user decisions.
        private const string MILES = "miles";
        private const string FEET = "feet";
        private const string METRES = "metres";
        private const string YARDS = "yards";
        private const string KILOMETRES = "kilometres";
        private const string INCHES = "inches";

        //Attributes that adopt values according to user decision and input.
        private double miles;
        private double feet;
        private double metres;
        private double yards;
        private double kilometres;
        private double inches;

        //Range of choices available to the user.
        private int userChoice1;
        private int userChoice2;

        //Value and units the user wishes to convert.
        private double fromDistance;
        private double toDistance;

        //New values and units from the previous distance and units chosen.
        private string fromUnit;
        private string toUnit;

        //Choices that are not allowed in the program.
        private bool invalidChoice1 = false;
        private bool invalidChoice2 = false;

        //Option to begin the program all over again.
        private bool retry;

        //Sole public method used to start the program.
        public void Run()
        {
            DisplayHeader();

            do
            {
                UserSelect();
                PromptUser(fromUnit, toUnit);
                InputDistance();
                ConvertDistance();
                OutputDistance();
                TryAgain();
            }
            while (retry = true);
        }

        //Method for displaying the name of the program, author and brief explination of what  the program does.
        public void DisplayHeader()
        {
            Console.WriteLine("\n==========================================================================================");
            Console.WriteLine("========                         App01 Distance Converter                         ========");
            Console.WriteLine("========                             By Derick Omondi                             ========");
            Console.WriteLine("==========================================================================================\n");
            Console.WriteLine("\nThis console application allows a user to input a value in one of the 6 suggested units and\n convert" +
                " it into one of the other 5 options.\n");
            Console.Write("\nPress enter to start\n>");
            Console.ReadLine();
        }

        //Method used to give the user an idea of what they're converting.
        private void PromptUser(String unit1, String unit2)
        {
            Console.WriteLine($"\nYou are converting from {unit1} to {unit2}.");
        }

        //Method for taking the user's input and appling it to the attribute.
        private void InputDistance()
        {
            Console.Write($"\nEnter the no. of {fromUnit}: ");
            string userInputNum = Console.ReadLine();
            this.fromDistance = Convert.ToDouble(userInputNum);

            Console.WriteLine($"\nYou entered {fromDistance} {fromUnit}.");
        }

        //Method used to take the user through the whole selection process
        //This goes through the initial and final units.
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
            while (sameOptionsChecker());
        }

        //Method displaying all unit options.
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

        //Initial selection process that assigns values for the previous units and distance value
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

        //Second part of the selection process in which assigns the final units and distance value to be displayed.
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

        //Method that displayes error message when user inputs a value not stated to be available.
        private void InvalidChoice()
        {
            Console.WriteLine("\nTHAT IS AN INVALID OPTION!!");
            invalidChoice1 = true;
            invalidChoice2 = true;
        }

        //boolean method for checking whether the user has selected the same unit twice.
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

        //Calculations that take place under certain conditions
        //Those condition depend on the values the user wants to convert between.
        private void ConvertDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }

            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }

            else if (fromUnit == MILES && toUnit == YARDS)
            {
                toDistance = fromDistance * YARDS_IN_MILES;
            }
            else if (fromUnit == YARDS && toUnit == MILES)
            {
                toDistance = fromDistance / YARDS_IN_MILES;
            }

            else if (fromUnit == MILES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * KILOMETRES_IN_MILES;
            }
            else if (fromUnit == KILOMETRES && toUnit == MILES)
            {
                toDistance = fromDistance / KILOMETRES_IN_MILES;
            }

            else if (fromUnit == MILES && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_MILES;
            }
            else if (fromUnit == INCHES && toUnit == MILES)
            {
                toDistance = fromDistance / INCHES_IN_MILES;
            }

            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }

            else if (fromUnit == YARDS && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_YARDS;
            }
            else if (fromUnit == FEET && toUnit == YARDS)
            {
                toDistance = fromDistance / FEET_IN_YARDS;
            }

            else if (fromUnit == KILOMETRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_KILOMETRES;
            }
            else if (fromUnit == FEET && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / FEET_IN_KILOMETRES;
            }

            else if (fromUnit == FEET && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_FEET;
            }
            else if (fromUnit == INCHES && toUnit == FEET)
            {
                toDistance = fromDistance / INCHES_IN_FEET;
            }

            else if (fromUnit == YARDS && toUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_YARDS;
            }
            else if (fromUnit == METRES && toUnit == YARDS)
            {
                toDistance = fromDistance * METRES_IN_YARDS;
            }

            else if (fromUnit == METRES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance * METRES_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_KILOMETRES;
            }

            else if (fromUnit == METRES && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_METRES;
            }
            else if (fromUnit == INCHES && toUnit == METRES)
            {
                toDistance = fromDistance / INCHES_IN_METRES;
            }

            else if (fromUnit == YARDS && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / YARDS_IN_KILOMETRES;
            }
            else if (fromUnit == KILOMETRES && toUnit == YARDS)
            {
                toDistance = fromDistance * YARDS_IN_KILOMETRES;
            }

            else if (fromUnit == YARDS && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_YARDS;
            }
            else if (fromUnit == INCHES && toUnit == YARDS)
            {
                toDistance = fromDistance / INCHES_IN_YARDS;
            }

            else if (fromUnit == KILOMETRES && toUnit == INCHES)
            {
                toDistance = fromDistance * INCHES_IN_KILOMETRES;
            }
            else if (fromUnit == INCHES && toUnit == KILOMETRES)
            {
                toDistance = fromDistance / INCHES_IN_KILOMETRES;
            }
        }

        //Displays the original converted to the new units.
        private void OutputDistance()
        {
            Console.WriteLine($"\n{fromDistance} {fromUnit} is equivalent to {toDistance} {toUnit}.");
        }

        //Option to restart the program from the selection process.
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
