namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;

            while (choice !=4)
            { 
            //print menu
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine("");

            //prompt for and get user choice
            Console.WriteLine("please enter 1, 2, 3, or 4");
            choice = int.Parse(Console.ReadLine());
            //Console.WriteLine(choice);
            
                if(choice == 1)
                {
                    Console.WriteLine("starting new game!!");
                }
                else if(choice == 2)
                {
                    Console.WriteLine("loading game...");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("open options");
                }
                else if(choice > 4 || choice < 1)
                { 
                    Console.WriteLine("not a valid. choice please enter 1, 2, 3, or 4");
                }
                Console.WriteLine();
            }
        }
    }
}