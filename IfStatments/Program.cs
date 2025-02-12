namespace IfStatments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            
            Boolean correctDir = false;
            while (correctDir == false)
            {
                Console.WriteLine("Enter a direction, this will tell you if its N E S or W");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (input <= 0 || input >= 361)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine();
                }
                else if (input >= 315 || input <= 45)
                {
                    Console.WriteLine("North");
                    Console.WriteLine();
                    correctDir = true;
                }
                else if (input >= 46 && input <= 135)
                {
                    Console.WriteLine("East");
                    Console.WriteLine();
                    correctDir = true;
                }
                else if (input >= 136 && input <= 225)
                {
                    Console.WriteLine("South");
                    Console.WriteLine();
                    correctDir = true;
                }
                else if (input >= 226 && input <= 314)
                {
                    Console.WriteLine("West");
                    Console.WriteLine();
                    correctDir = true;
                }
            }


            //Part 2
            int fee = 4;
           
            Console.WriteLine("Enter how long you were parked for:");
            int mins = Convert.ToInt32(Console.ReadLine());

            
            if (mins <= 60)
            {
                fee += 2;
            }
            else if (mins >= 61 && mins <= 120)
            {
                fee += 4;
            }
            else if (mins >= 121 && mins <= 180)
            {
                fee += 6;
            }
            else if (mins >= 181 && mins <= 240)
            {
                fee += 8;
            }
            else if (mins >= 241 && mins <= 300)
            {
                fee += 10;
            }
            else if (mins >= 241 && mins <= 300)
            {
                fee +=12;
            }
            else if (mins >= 301 && mins <= 360)
            {
                fee += 14;
            }
            else if (mins >= 361)
            {
                fee += 16;
            }
           
            Console.WriteLine("Your fee after that much time would be: $" + fee);
            Console.WriteLine();

            //Part 3

            int Number = 5;

            switch (Number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
            }


        }
    }
}
