using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            bool playing = true;
            Random secondGenerator = new Random();
            int goodOrBad = secondGenerator.Next(1, 3);
            //Variablar
            int playerCarAmountButInt;
            string playerCarAmount;
            //Instruktioner.
            Console.WriteLine("Please enter the amount of cars that are to be created. Only numbers over 0.");
            Console.Write("Amount: ");
            playerCarAmount = Console.ReadLine();
            if (playerCarAmount.All(char.IsDigit))
            {
                Console.WriteLine("Valid Input.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect.");
                Console.ReadLine();
                return;
            }
            playerCarAmountButInt = int.Parse(playerCarAmount);
            if (playerCarAmountButInt <= 0)
            {
                Console.WriteLine("Incorrect.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You chose to create " + playerCarAmountButInt + " cars.");
                Console.ReadLine();

            }
            List<Car> allCars = new List<Car>();
            //Ett försök till att skapa en for loop som gjorde en contraband bil om det hamnade på 2 och en Clean bil om den hamnade på 1, vilket gav båda en 50% chans att hända.
            for (int i = 0; i < playerCarAmountButInt; i++)
            {
                if (goodOrBad == 1)
                {
                    allCars.Add(new CleanCar());
                }
                else
                {
                    allCars.Add(new ContrabandCar());
                }

            }
            while (playing)
            {
                Console.WriteLine("which car do you want to check? 0-" + playerCarAmountButInt);
                string playerCarChek = Console.ReadLine();
                //Ungefär här gav jag upp.
            }
            //for (int i = 0; i < allCars.Count; i++)
            //{

            //}

            //Hjälp
        }

    }
}
