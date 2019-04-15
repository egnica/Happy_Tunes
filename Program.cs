using System;

namespace Happy_Tunes
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] GENRES = {"1 Classical", "2 Easy Listening", "3 Jazz", "4 Pop", "5 Rock", "6 Other"};
            int [] genersCount = {0, 0, 0, 0, 0, 0,};
            double [] genersTotals = {0, 0, 0, 0, 0, 0};
            double PRICE = 0.99;
            int selection;
            string sentinal;
            string EXIT = "EXIT";
            double total = 0;
           // double grandTotal = 0;
            System.Console.WriteLine("Welcome to happy tunes. Type 'enter' to enter ");
            sentinal = Console.ReadLine();

            while(sentinal != EXIT){
                System.Console.WriteLine("Please enter which geners of music you would like to buy. Each selection is $.99");
                for(int i = 0; i < GENRES.Length; i++){
                    System.Console.WriteLine($"{GENRES[i]}");
                }
                selection = Convert.ToInt32(Console.ReadLine());
                selection = selection - 1;

                genersTotals[selection] = genersTotals[selection] + PRICE;
                genersCount[selection] = genersCount[selection] + 1;
                if(selection > 0 ){
                    total = total + PRICE;
                }
                
                System.Console.WriteLine("Would you like to continue to shop? Press ENTER. To Exit type 'EXIT'.");
                sentinal = Console.ReadLine();
            }
            System.Console.WriteLine("Thanks for shopping. Here are the counts and totals per geners");
            
            for(int x = 0; x < GENRES.Length; x++){
                System.Console.WriteLine($"{GENRES[x]}: count: {genersCount[x]} amount: ${genersTotals[x]}");
                if(genersTotals[x] > 0 && genersTotals[x] < 3.00){
                    
                    System.Console.WriteLine($"Geners $3.00 or slower{GENRES[x]}");
                }else if(genersTotals[x] > 3 && genersTotals[x] < 5.99){
                     System.Console.WriteLine($"Geners $3.00 through $5.99{GENRES[x]}");
                }
            }
            System.Console.WriteLine($"Your total is ${total}");
            
        }
    }
}
