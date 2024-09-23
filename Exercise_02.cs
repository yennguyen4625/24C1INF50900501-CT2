﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*
     Create a Jagged Array with random integer numbers (or by user input) by getting 
        the number of rows and columns from the user and printing the data in the array to the user. 
    Then, create functions to implement following tasks:
        Print the biggest number of each row and the largest number of the whole array.
        Sort values ascending of each row.
        Print items of the array that are prime.
        Search and print all positions of a number (enter from the user).

     */
    internal class Exercise_02
    {
        /// <summary>
        /// Create a Jagged Array with random integer numbers (or by user input) by getting 
        ///the number of rows and columns from the user
        /// </summary>
        /// <param name="a"></param>
        static void init_random(int[][] a, int rows)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter the No columns of the row {i}th: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                    a[i][j] =rnd.Next(10, 50);
            }
        }
        static void init_from_user(int[][] a)
        {

        }

        /// <summary>
        /// printing the data in the array to the user
        /// </summary>
        /// <param name="a"></param>

        static void print(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                    Console.Write(a[i][j] + "\t");
                Console.WriteLine();
            }
        }

        static int max(int[][] a)
        {

            //....
            return 0;
        }
        static void sort_rows(int[][] a)
        {
            //>?????
        }

        /// <summary>
        /// Search and print all positions of a number (enter from the user).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="val"></param>
        static void search_and_print(int[][] a, int val)
        {

        }

        /// <summary>
        ///  Print items of the array that are prime.
        /// </summary>
        /// <param name="a"></param>
        static void print_primes(int[][] a)
        {
            //????
        }


        static int menu()
        {
            Console.WriteLine("\t\tjagged array demo\n");
            Console.WriteLine("1. Jagged array init");
            Console.WriteLine("2. print array");
            Console.WriteLine("3...");
            Console.WriteLine("4....");
            Console.WriteLine("5....");
            Console.WriteLine("6....");
            Console.WriteLine("0. exit");
            Console.WriteLine();
            Console.Write("Your select <1..6>");
            int sel = 0;
            while (true)
            {
                bool c = int.TryParse(Console.ReadLine(), out sel);
                if (c && sel >= 0 && sel <= 6)
                    break;
                else Console.WriteLine("Please enter a valid choice!");
            }
            return sel;
        }


        public static void Main(string[] args)
        {
            Console.Write("ENter the no rows: ");
            int rows = int.Parse(Console.ReadLine());
            int[][] a = new int[rows][];
            //init_random(a,rows);
            //print(a);
            while(true)
            {
                int sel = menu();
                switch (sel)
                {
                    case 0: Console.WriteLine("Bye"); return;
                    case 1: init_random(a, rows); break;
                    case 2: print(a); break;
                        //...
                }
            }
            
        }
    }
}
