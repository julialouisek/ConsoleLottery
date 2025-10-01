namespace ConsoleLottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }


        static bool CheckResult(int ticket, int[] winningNumbers)
        {
            foreach (int number in winningNumbers)
            {
                if (ticket == number)
                {
                    return true;
                }
            }
            return false;
        }

        static int CheckEveryNumber(int[] tickets, int[] winningNumbers)
        {
            int amount = 0;
            foreach (int ticket in tickets)
            {
                if (CheckResult(ticket, winningNumbers))
                {
                    amount++;
                }
            }
            return amount;
        }
    }
}
