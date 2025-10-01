namespace ConsoleLottery
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //calls the random tickets array to save them in main 
            int[] WinningTickets = WinningNumbersGenerator();

            //print each of the diffrent elements of the array
            foreach (int Winners in WinningTickets)
            {
                Console.WriteLine(Winners);
            }
        }

        static int[] WinningNumbersGenerator()
        {
            Random rnd = new Random();

            //creates a list that will hold ints
            int[] win = [0, 0, 0];

            //loop will run until 3 unique numbers
            for (int i = 0; i < win.Length; i++)
            {
                bool isMatch = false;
                //holds the random numbers
                int randomnum = rnd.Next(1, 51);

                //if the number is a duplicate it will run the loop again insted of adding the num to the list
                foreach (int num in win)
                {
                    if (num == randomnum)
                    {
                        isMatch = true;
                        i--;
                    }
                }

                if (!isMatch)
                {
                    win[i] = randomnum;
                }


            }

            //changes the list to an array
            return win;
        }
            
        
    }
}
