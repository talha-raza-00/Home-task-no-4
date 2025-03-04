using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static int[][] movies ;
        static int nummov;
        static int numuser;

        static void intialize(int nm,int nu)
        {
            movies=new int[nm][];
            for(int i = 0; i < nm; i++)
            {
                movies [i] = new int[nu];   
            }
        }

        static void inputrating()
        {
            for(int i = 0;i < nummov;i++)
            {
                Console.WriteLine("Input the rating for movie number {0}", i+1);
                for (int j = 0;j < numuser; j++)
                {
                    Console.Write("user number {0} enter the rating for movie number {1}  (1--5) :",j+1, i+1);
                    movies [i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void DisplayRatings()
        {
            Console.WriteLine("\nMovie Ratings (Users -> Ratings)");
            for (int i = 0; i < nummov; i++)
            {
                Console.Write($"Movie {i + 1}: ");
                foreach (var r in movies[i])
                {
                    Console.Write(r + " ");
                }
                Console.WriteLine();
            }
        }

        static void calavg()
        {
            for (int i = 0; i < nummov; i++)
            {
                double sum = 0;
                foreach (var r in movies[i])
                {
                    sum =sum+ r;
                }
                double avg = sum / movies[i].Length;
                Console.WriteLine("Movie {0} Average Rating: {1}",i+1 , avg);
            }
        }

        static void hrm()
        {
            double maxavg = double.MinValue;
            int index = -1;
            for (int i = 0; i < nummov; i++)
            {
                double sum = 0;
                foreach (var r in movies[i])
                {
                    sum += r;
                }
                double avg = sum / movies[i].Length;
                if (avg > maxavg)
                {
                    maxavg = avg;
                    index = i;
                }
            }
            Console.WriteLine($"Highest Rated Movie: Movie {index + 1} with Average Rating: {maxavg}");
        }

        static void lrm()
        {
            double minavg = double.MaxValue;
            int index = -1;
            for (int i = 0; i < nummov; i++)
            {
                double sum = 0;
                foreach (var r in movies[i])
                {
                    sum += r;
                }
                double avg = sum / movies[i].Length;
                if (avg < minavg)
                {
                    minavg = avg;
                    index = i;
                }
            }
            Console.WriteLine($"Lowest Rated Movie: Movie {index + 1} with Average Rating: {minavg}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of movies : ");
             nummov=int.Parse(Console.ReadLine());
            Console.Write("Enter the number of users : ");
            numuser=int.Parse(Console.ReadLine());

            intialize(nummov,  numuser);


            while (true)
            {
                Console.WriteLine("\n\t| Movies Rating | \n");
                Console.WriteLine("1. Input Movie Ratings");
                Console.WriteLine("2. Display Movie Ratings");
                Console.WriteLine("3. Calculate Average Ratings");
                Console.WriteLine("4. Find Highest Rated Movie");
                Console.WriteLine("5. Find Lowest Rated Movie");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int cho = int.Parse(Console.ReadLine());

                switch (cho)
                {
                    case 1:
                        inputrating();
                        break;
                    case 2:
                        DisplayRatings();
                        break;
                    case 3:
                        calavg();
                        break;
                    case 4:
                        hrm();
                        break;
                    case 5:
                        lrm();
                        break;
                    case 6:
                        return;


                    default:
                        Console.WriteLine("Inval9id chice !!");
                        break;

                }

            }
        }
    }
}
