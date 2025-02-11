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
                   
                }
            }
       


        }
    }
}
