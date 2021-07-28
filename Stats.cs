using System;
namespace Assignment5
{
    class Stats
    {
        int[] runs = new int[30];

        int total_runs = 0;

        int count_zero = 0;
        int count_ones = 0;
        int count_twos = 0;
        int count_threes = 0;
        int count_fours = 0;
        int count_sixes = 0;
        double strikerate = 0;

        public void generate_runs()
        {
            Random run = new Random();
            for (int i = 0; i < 30; i++)
            {
                runs[i] = run.Next(0, 7);
                if (runs[i] == 5)
                {
                    i = i - 1;
                }

            }


            foreach (int i in runs)
            {
                total_runs = total_runs + i;
                switch (i)
                {
                    case 0:
                        count_zero += 1;
                        break;
                    case 1:
                        count_ones += 1;
                        break;
                    case 2:
                        count_twos += 1;
                        break;
                    case 3:
                        count_threes += 1;
                        break;
                    case 4:
                        count_fours += 1;
                        break;
                    case 6:
                        count_sixes += 1;
                        break;
                }
                
            }
            strikerate = (double)(total_runs) / 30.0;



            /*
            int count = 0;
            foreach(int i in runs)
            {
                count = count + 1;
                Console.WriteLine(i);
            }
            Console.WriteLine("The count is: " + count);
            */
        }

        public void last5innings()
        {

        }
        public void displayStats()
        {
            Console.WriteLine("Total Runs: " + total_runs);
            Console.WriteLine("Number of 0's: " + count_zero);
            Console.WriteLine("Number of 1's: " + count_ones);
            Console.WriteLine("Number of 2's: " + count_twos);
            Console.WriteLine("Number of 3's: " + count_threes);
            Console.WriteLine("Number of 4's: " + count_fours);
            Console.WriteLine("Number of 6's: " + count_sixes);
            Console.WriteLine("Strike Rate: " + Math.Round(strikerate,2));
        }
    }
}
