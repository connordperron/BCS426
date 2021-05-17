using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Lab6

{
    public abstract class Player
    {
        private string _name;
        private double _salary;

        public Player (string name = "", double salary = 0.0)
        {
            _name = name;
            _salary = salary;
        }
        public string Name { get; set; }

        public double Salary { get; set; }

        public override string ToString() => $"{ _name } with salary of ${ _salary }";

        public abstract void displayStatistics();



    }



    public class BaseballPlayer : Player
    {
        private int _atBats;
        private int _homeRuns;
        private int _hits;

        public BaseballPlayer(string name = "" , double salary = 0.0 , int atBats = 0 , int homeRuns = 0, int hits = 0): base(name, salary)
        {
            this.Name = name;
            this.Salary = salary;
            _atBats = atBats;
            _homeRuns = homeRuns;
            _hits = hits;
        }
        public int AtBats { get; set; }

        public int HomeRuns { get; set; }

        public int Hits { get; set; }

        public override void displayStatistics()

        {

            Console.WriteLine($"Player: {this.Name} \n Salary: {this.Salary} \n At Bats: { _atBats } \n Home Runs: {  _homeRuns }\n Hits: { _hits }");

        }



    }


    class Program

    {


        static void Main()
        {

            // create a one dimensional array of baseball
            // players with size of 100
            BaseballPlayer[] team = new BaseballPlayer[100];

            // add three baseball players to the array
            BaseballPlayer b1 = new BaseballPlayer("Connor Perron", 1000000.99, 1001, 102, 506);
            BaseballPlayer b2 = new BaseballPlayer("Ilknur Aydin", 2100000.99, 5992, 732, 116);
            BaseballPlayer b3 = new BaseballPlayer("John Jones", 50000.00, 201, 10, 63);
            BaseballPlayer temp = new BaseballPlayer();
            team[0] = b1;
            team[1] = b2;
            team[2] = b3;
            // show menu to the user
            // 1. sort players based on salary and display
            // 2. sort players based on hits and display
            // 3. sort players based on name and display
            Console.WriteLine("Welcome to the baseball player database");
            Console.WriteLine("Please choose from the following options to sort players: \n (1) Salary (Lowest to Highest) \n (2) Hits (Lowest to Highest) \n (3) Name (A to Z)");

            // ask the user what option they want fromthe menu
            int choice = Convert.ToInt32(Console.ReadLine());

            // and accordingly display all the information
            // of the baseball players in that specific order
            //...
            if (choice == 1)
            {
                Console.WriteLine("Players from Lowest Salary to Highest Salary");
                for (int i =0; i < 2; i++)
                {
                    if (team[i].Salary < team[i+1].Salary)
                    {
                        temp = team[i];
                        team[i] = team[i + 1];
                        team[i + 1] = temp;
                    }

                }

                for (int j = 2; j >= 0; j--)
                {
                    team[j].displayStatistics();
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("Players from Lowest Hits to Highest Hits");
                for (int i = 0; i < 2; i++)
                {
                    if (team[i].Hits < team[i + 1].Hits)
                    {
                        temp = team[i];
                        team[i] = team[i + 1];
                        team[i + 1] = temp;
                    }

                }

                for (int j = 2; j >= 0; j--)
                {
                    team[j].displayStatistics();
                }
            }

            else if (choice == 3)
            {
                Console.WriteLine("Players in Alphabetical Order");
                for (int i = 0; i < 2; i++)
                {
                    string name = team[i].Name;
                    int compare = name.CompareTo(team[i + 1].Name);

                    if (compare > 0)
                    {
                        temp = team[i];
                        team[i] = team[i + 1];
                        team[i + 1] = temp;
                    }
                }


                for (int j = 0; j < 3; j++)
                {
                    team[j].displayStatistics();
                }
            }

            else
            {
                Console.WriteLine("Invalid Choice :(");
            }



        }

    }

}
