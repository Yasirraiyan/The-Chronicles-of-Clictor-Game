  public class Utility
    {
        public void producenumber()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            int randomnumber=rnd1.Next(0,2);
            Console.WriteLine(rnd1);
            Console.WriteLine(rnd2);
            Console.WriteLine(randomnumber);


        }
        public int ProduceNumber(int min, int max)
        { 
            Random random = new Random();
            return random.Next(min, max); 
        } 
        public (int, int) GetRandomPosition2D(int xRange, int yRange) 
        { 
            int x = ProduceNumber(0, xRange); 
            int y = ProduceNumber(0, yRange);
            return (x, y); 
        } 
        public (int, int, int) GetRandomPosition3D(int xRange, int yRange, int zRange)
        { 
            int x = ProduceNumber(0, xRange); 
            int y = ProduceNumber(0, yRange);
            int z = ProduceNumber(0, zRange); 
            return (x, y, z); 
        } 
        public string GetRandomAction()
        {
            string[] actions = { "Move", "Attack", "Defend", "Collect" }; 
            int index = ProduceNumber(0, actions.Length); return actions[index]; 
        } 
 public int CalculateScore(int moves, int attacks, int defenses, int itemsCollected)
        { 
            int score = (moves * 10) + (attacks * 20) + (defenses * 15) + (itemsCollected * 5);
            return score;
        } 
        public void PrintUtilityDetails() 
        {
            Console.WriteLine("Utility Class for Cictor Game"); 
        }
    }
}
