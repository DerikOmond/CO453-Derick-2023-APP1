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

        public void Run()
        {
            DisplayHeader();

            do
            {
                UserSelect();
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

        private void UserSelect()
        {
            do
            {
                FirstUserSelection();
                SecondUserSelection();

                if(SameOptionsChecker())
                {
                    Console.WriteLine("\nYOU CANNOT CONVERT FROM THIS UNIT BACK TO ITSELF.\nTRY AGAIN WITH DIFFERENT UNITS.");
                }
            }
            while (true);
        }

        private void FirstUserSelection()
        {

        }

        private void SecondUserSelection() 
        {

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
    }
}
