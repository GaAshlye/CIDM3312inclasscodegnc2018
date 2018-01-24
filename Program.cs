using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


namespace SonOfNicknameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nicknames = new string [10,2]; //rectangular array

            //row one column one
            nicknames[0,0] = "Dude";
            //row one column 2
            nicknames[0,1] = "Jones";

            //row two column 1
            nicknames[1,1] = "Sappy";
            //row two column 2
            nicknames[1,1] = "Firecracker";


            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            //char[] nameparts = name.ToCharArray(); //built in string to do whatever you want 
            string[] nameparts = name.Split(new char[' ']); //spaces allow the code to split names 

            for (int i = 0; i < nameparts.Length; i++)
            {
                Console.WriteLine(nameparts[i]);
            }

            // for(int i = 0; i < nameparts.Length; i++)
            // {
            //     //pick something from the first column and second column to pick name


            // }
            
        }
    }
}

