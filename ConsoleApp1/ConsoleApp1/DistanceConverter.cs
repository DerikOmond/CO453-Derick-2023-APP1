using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DistanceConverter
    {
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
    }
}
