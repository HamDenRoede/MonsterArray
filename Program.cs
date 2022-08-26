using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            //MainMenu();
            //Monster();
            readFiles();
        }

        static void Test()
        {
            string input = "";
            File.WriteAllText(@"c:\Users\Jonas\source\repos\MonsterArray\MonsterArray\data_files\drengenavn.dat", input, Encoding.Unicode);
        }

        static void MainMenu()
        {
            string ord = "Min hjerne fungere slet ikke nu yyy";
            string[] Ord_array = ord.Split(' ');

            Console.Write(Ord_array.Length);
            Console.ReadKey();


        }

        static void Monster()
        {

            string[] question = { "fornavn", "efternavn", "vej", "by", };
            string[] answer = new string[4];

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine(question[i]);
                answer[i] = Console.ReadLine();

            }
            Console.WriteLine("");

            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }

            string input = "";

            for (int i = 0; i < answer.Length; i++)
            {
                input = input + answer[i] + ";";
            }

            Console.ReadKey();
            
            File.WriteAllText(@"c:\Users\Jonas\source\repos\MonsterArray\MonsterArray\data_files\test_file.txt", input, Encoding.Unicode);

        }

        static void readFiles()
        {
            string text = File.ReadAllText(@"c:\Users\Jonas\source\repos\MonsterArray\MonsterArray\data_files\efternavne.dat");
            Console.WriteLine(text);
        }
    }
}
