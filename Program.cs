using Drofsnar_The_Bird_Man;

class gameSequencer
{
   public static void Main(){

      string filePath =
      @"./assets/game-sequence.txt";
      StreamReader reader;
      if (File.Exists(filePath)){
         reader = new StreamReader(File.OpenRead(filePath));
         List<string> Moves = new List<string>();
         while (!reader.EndOfStream){
            var line = reader.ReadLine();
            var values = line.Split(',');
            foreach (var item in values){
               Moves.Add(item);
            }
            birdMan.Lives = 3;
            birdMan.Points = 5000;
            bool birdManHighScore = true;
            bool birdHunterOneAlive = true;
            bool birdHunterTwoAlive = true;
            bool birdHunterThreeAlive = true;
            bool birdHunterFourAlive = true;
            foreach (var item in Moves){
                switch (item)
                {
                    case "Bird":
                    birdMan.Points = birdMan.Points + 10;
                    System.Console.WriteLine($"Congrats! You found a Bird! Your new score is {birdMan.Points}");
                    if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "CrestedIbis":
                    birdMan.Points = birdMan.Points + 100;
                    System.Console.WriteLine($"Congrats! You found a Crested Ibis! Your new score is {birdMan.Points}");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "GreatKiskudee":
                    birdMan.Points = birdMan.Points + 300;
                    System.Console.WriteLine($"Congrats! You found a Great Kiskudee! Your new score is {birdMan.Points}");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "RedCrossbill":
                    birdMan.Points = birdMan.Points + 500;
                    System.Console.WriteLine($"Congrats! You found a Red Crossbill! Your new score is {birdMan.Points}");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "Red-neckedPhalarope":
                    birdMan.Points = birdMan.Points + 700;
                    System.Console.WriteLine($"Congrats! You found a Red-Necked Phalarope! Your new score is {birdMan.Points}");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "EveningGrosbeak":
                    birdMan.Points = birdMan.Points + 1000;
                    System.Console.WriteLine($"Congrats! You found a Evening Grosbeak! Your new score is {birdMan.Points}");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "GreaterPrairieChicken":
                    birdMan.Points = birdMan.Points + 2000;
                    System.Console.WriteLine($"Congrats! You found a Greater Praire Chicken! Your new score is {birdMan.Points}");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "IcelandGull":
                    birdMan.Points = birdMan.Points + 3000;
                    System.Console.WriteLine($"Congrats! You found a Iceland Gull! Your new score is {birdMan.Points}");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "Orange-belliedParrot":
                    birdMan.Points = birdMan.Points + 5000;
                    System.Console.WriteLine($"Congrats! You found a Orange-Bellied Parrot! Your new score is {birdMan.Points}");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "InvincibleBirdHunter":
                    birdMan.Lives = birdMan.Lives - 1;
                    System.Console.WriteLine($"Oh no! You ran into an Invincible Bird Hunter and you lost a life! You now have {birdMan.Lives} remaining.");
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    case "VulnerableBirdHunter":
                    if (birdHunterOneAlive == true & birdHunterTwoAlive == true & birdHunterThreeAlive == true & birdHunterFourAlive == true)
                    {
                        birdHunterOneAlive = false;
                        birdMan.Points = birdMan.Points + 200;
                        System.Console.WriteLine($"Congratulations! You just slayed your first Bird Hunter, and got 200 points! Your new score is {birdMan.Points}");
                    } else if (birdHunterOneAlive == false & birdHunterTwoAlive == true & birdHunterThreeAlive == true & birdHunterFourAlive == true)
                    {
                        birdHunterTwoAlive = false;
                        birdMan.Points = birdMan.Points + 400;
                        System.Console.WriteLine($"Congratulations! You just slayed your second Bird Hunter, and got 400 points! Your new score is {birdMan.Points}");
                    } else if (birdHunterOneAlive == false & birdHunterTwoAlive == false & birdHunterThreeAlive == true & birdHunterFourAlive == true)
                    {
                        birdHunterThreeAlive = false;
                        birdMan.Points = birdMan.Points + 800;
                        System.Console.WriteLine($"Congratulations! You just slayed your third Bird Hunter, and got 800 points! Your new score is {birdMan.Points}");
                    }
                    else if (birdHunterOneAlive == false & birdHunterTwoAlive == false & birdHunterThreeAlive == false & birdHunterFourAlive == true)
                    {
                        birdHunterFourAlive = false;
                        birdMan.Points = birdMan.Points + 1600;
                        System.Console.WriteLine($"Congratulations! You just slayed your fourth and final Bird Hunter, and got 1600 points! Your new score is {birdMan.Points}");
                    }
                     if (birdMan.Points > 10000 & birdManHighScore == true)
                    {
                        birdMan.Lives = birdMan.Lives + 1;
                        birdManHighScore = false;
                        System.Console.WriteLine($"You just passed 10,000 points! Congrats, here's an extra life! You now have {birdMan.Lives} lives!");
                    };
                    break;
                    default:
                    System.Console.WriteLine("uh oh");
                    break;
                }
            }
         }
      } else {
         System.Console.WriteLine();
      }
}
}

namespace Drofsnar_The_Bird_Man
{
    class birdMan 
    {
        public static int Lives { get; set; }
        public static int Points { get; set; }
    }
}