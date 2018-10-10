using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracArray
{
    
    class Torches
    {
        public static void Main()
        {
            bool[] torches = { true, true, true, true, true, true, true };
            string torchChosen;


            Console.WriteLine("Choose a torch!");
            Console.WriteLine(torches[0] + " " + torches[1] + " " + torches[2] + " " + torches[3] + " " + torches[4] + " " + torches[5] + " " + torches[6]);
            Console.WriteLine("");


            while (torches[0] == true || torches[1] == true || torches[2] == true || torches[3] == true || torches[4] == true || torches[5] == true || torches[6] == true)
            {
                torchChosen = Console.ReadLine();
                switch (torchChosen)
                {
                    case "1":
                        torches[0] = !torches[0];
                        torches[6] = !torches[6];
                        torches[1] = !torches[1];
                        break;
                    case "2":
                        torches[1] = !torches[1];
                        torches[0] = !torches[0];
                        torches[2] = !torches[2];
                        break;
                    case "3":
                        torches[2] = !torches[2];
                        torches[1] = !torches[1];
                        torches[3] = !torches[3];
                        break;
                    case "4":
                        torches[3] = !torches[3];
                        torches[2] = !torches[2];
                        torches[4] = !torches[4];
                        break;
                    case "5":
                        torches[4] = !torches[4];
                        torches[3] = !torches[3];
                        torches[5] = !torches[5];
                        break;
                    case "6":
                        torches[5] = !torches[5];
                        torches[4] = !torches[4];
                        torches[6] = !torches[6];
                        break;
                    case "7":
                        torches[6] = !torches[6];
                        torches[5] = !torches[5];
                        torches[0] = !torches[0];
                        break;

                }

                Console.WriteLine("");
                Console.WriteLine(torches[0] + " " + torches[1] + " " + torches[2] + " " + torches[3] + " " + torches[4] + " " + torches[5] + " " + torches[6]);
                Console.WriteLine("");

            }

            Console.WriteLine("You win!");

            Console.WriteLine();
            Console.WriteLine("Press Any Button To Quit");
            Console.ReadKey();

        }
    }

}
