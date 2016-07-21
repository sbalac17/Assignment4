using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Shivya Balachandran
    Comp123
    07/19/2016
    300884989
*/
namespace AirlineReservationsSystem
{
    /**
   * <summary>
   * This class is the main program
   * </summary>
   * 
   * @class Program
   */
    class Program
    {
        private static List<string> _seatingChart;
        private static List<string> _assignedSeats;

        static void Main(string[] args)
        {
            _seatingChart = new List<string>();
            _assignedSeats = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                _seatingChart.Add("First Class");
            }
            for (int i = 0; i < 5; i++)
            {
                _seatingChart.Add("Economy");
            }

            DisplayMenu();
        }
        //this is a menu
        static void DisplayMenu()
        {
            string choose;
            do
            {
                Console.WriteLine("1 first class");
                Console.WriteLine("2 economy");
                Console.WriteLine("3 exit");

                Console.Write("choose something: ");
                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        FirstClass();
                        break;
                    case "2":
                        Economy();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("invaid choice");
                        break;
                }
            } while (choose != "3");
        }
        static void FirstClass()
        {
            if (_seatingChart.Remove("First Class"))
            {
                // add to assigned
                _assignedSeats.Add("First Class");
                Console.WriteLine("You got first class");
            }
            else
            {
                Console.Write("First class is full, do you want economy? ");
                string answer = Console.ReadLine();
                if (answer == "yes" && _seatingChart.Remove("Economy"))
                {
                    _assignedSeats.Add("Economy");
                    Console.WriteLine("You got economy");
                }
                else
                {
                    Console.WriteLine("Next flight leaves in 3 hours");
                }
            }
        }
        static void Economy()
        {
            if(_seatingChart.Remove("Economy"))
            {
                // add to assigned
                _assignedSeats.Add("Economy");
                Console.WriteLine("You got economy");
            }
            else
            {
                Console.Write("Economy is full, do you want First Class? ");
                string answer = Console.ReadLine();
                if (answer == "yes" && _seatingChart.Remove("First Class"))
                {
                    _assignedSeats.Add("First Class");
                    Console.WriteLine("You got FirstClass");
                }
                else
                {
                    Console.WriteLine("Next flight leaves in 3 hours");
                }
            }
        }

        private static int Find(List<string> list, string item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                {
                    return i;
                }
                
            }
            return -1;
        }
    } 
}
