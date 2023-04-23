using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Advanced_LINQ.Controllers
{
    internal class UI
    {
        public static void UserMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("The user menu");
                Menu();
                if(int.TryParse(Console.ReadLine(), out int navigate))
                {
                    switch (navigate)
                    {
                        case 1:
                            UIControllers.getMathTeacher();
                            break;
                        case 2:
                            UIControllers.studentsWithTeachers();
                            break;
                        case 3:
                            UIControllers.contiansProgram();
                            break;
                        case 4:
                            UIControllers.updateSubject();
                            break;
                        case 5:
                            UIControllers.fromAnasToReidar();
                            break;
                        case 6:
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("The menu must be navigated with a number that is available in the menu");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("The menu must be navigated with a number");
                }


            }
                

        }
        public static void Menu()
        {
            Console.WriteLine("[1] All Teachers that teach math\n[2] Get all students and their teacher\n" +
                "[3] Does the courseplan contains programmering 1?\n" +
                "[4] Edit the coursename from programmering 2 to OOP\n" +
                "[5] Update students teacher from Anas to Reidar\n [6] Exit Program");
        }
    }
}
