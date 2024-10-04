internal class Program
{
    private static void Main(string[] args)
    {
        int playerRandomNum;
        int enemyRandomNum;
        int playerPoints=0, enemyPoints=0;
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Press any key to roll the dice: ");

            Console.ReadKey();

            playerRandomNum = random.Next(1,7);
            Console.WriteLine($"you rolled a {playerRandomNum}");
            enemyRandomNum = random.Next(1,7);

            Console.WriteLine(".............");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine($"Enemy AI rolled {enemyRandomNum}");
            


            if (playerRandomNum> enemyRandomNum)
            {
                playerPoints++;
                Console.WriteLine("Player wins this game");
            }
            else if(playerRandomNum == enemyRandomNum){
                playerPoints++;
                Console.WriteLine("It is a draw");
            }
            else
            {
                {
                    Console.WriteLine("Enemy AI wins the game");
                    enemyPoints++;
                }
            }

            Console.WriteLine($"the score now is player: {playerPoints} ,enemy: {enemyPoints}");

        }
        
        
        Console.ReadKey();
    }
}