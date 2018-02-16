using System;
using System.Diagnostics;
using System.Threading;

namespace Intermediate_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //STACK OVERFLOW POST EXCERCISE - STARTS HERE
            var post = new Post();
            post._title = "TITLE";
            post._desc = "This is the description of the post";

            Console.WriteLine(post.DisplayPost());

            Console.WriteLine();
            Console.WriteLine("Press Enter to enter Voting for this post & Esc to get out of voting");
            var condition = true;
            while (condition)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Up Arrow to UpVote and Down Arrow to downvote");

                    while (condition)
                    {
                        var postInput = Console.ReadKey();


                        switch (postInput.Key)
                        {
                            case ConsoleKey.UpArrow:
                                post.UpVote();
                                Console.WriteLine("Total No. of Votes:" + post.NoOfVotes());
                                break;

                            case ConsoleKey.DownArrow:
                                post.DownVote();
                                Console.WriteLine("Total No. of Votes:" + post.NoOfVotes());
                                break;

                            case ConsoleKey.Escape:
                                condition = false;
                                Console.WriteLine();
                                break;

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try again");
                }
 
            }
            Console.WriteLine(post.DisplayPost());


            //STACK OVERFLOW POST EXCERCISE - ENDS HERE

            //STOP WATCH EXCERCISE - STARTS HERE

            //var stopwatch = new Stopwatch();
            //while(true)
            //{
            //    stopwatch.Start();
            //    Thread.Sleep(1000);
            //    stopwatch.Stop();
            //    Console.WriteLine(stopwatch.Interval());
            //    Console.WriteLine("Enter key to start again");
            //    Console.ReadLine();
            //}

            //STOP WATCH EXCERCISE - ENDS HERE


           

          




        }
    }
}
