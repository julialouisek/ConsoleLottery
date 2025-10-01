namespace ConsoleLottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] col = Buy();
            foreach (var i in col)
            {
                Console.WriteLine(i);
            }

        }


        static int[] Buy()
        {
            int lottery = 0;
            int userNumber = -1;
            int[] col = new int[5];
            int remaining = 5;
            while (remaining != 0)
            {
                Console.Write("Skriv en siffra mellan 1-50: ");
                while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber <= 0 || userNumber >= 51)
                {
                    Console.WriteLine("Det måste vara en siffra mellan 1-50");
                }
                col[lottery] = userNumber;
                lottery++;
                remaining--;
                
            }
            return col;
        }


    }

}

