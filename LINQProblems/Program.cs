using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            ////filter list to only include strings that contain "th"
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var wordsTH = words.Where(w => w.Contains("th"));
            //foreach (string word in wordsTH)
            //Console.WriteLine(word);
            //Console.ReadLine();

            ////return list with no duplicates
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var namesDistinct = names.Distinct();
            //foreach (string name in namesDistinct)
            //    Console.WriteLine(name);
            //Console.ReadLine();

            ////remove each students lowest grade, find average per student, find average of averages
            //List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            //char[] separator = { ',' };
            //List<double> classAverage = new List<double>();
            ////Student 1
            //var studentOne = classGrades[0];
            //string[] studentOneList = studentOne.Split(separator);
            //List<int> studentOneInt = new List<int>();
            //foreach (string s in studentOneList)
            //{
            //    studentOneInt.Add(int.Parse(s));
            //}
            //studentOneInt.Remove(studentOneInt.Min());
            //double studentOneAverage = studentOneInt.Average();
            //classAverage.Add(studentOneAverage);

            ////Student 2
            //var studentTwo = classGrades[1];
            //string[] studentTwoList = studentTwo.Split(separator);
            //List<int> studentTwoInt = new List<int>();
            //foreach (string s in studentTwoList)
            //{
            //    studentTwoInt.Add(int.Parse(s));
            //}
            //studentTwoInt.Remove(studentTwoInt.Min());
            //double studentTwoAverage = studentTwoInt.Average();
            //classAverage.Add(studentTwoAverage);

            ////Student 3
            //var studentThree = classGrades[2];
            //string[] studentThreeList = studentThree.Split(separator);
            //List<int> studentThreeInt = new List<int>();
            //foreach (string s in studentThreeList)
            //{
            //    studentThreeInt.Add(int.Parse(s));
            //}
            //studentThreeInt.Remove(studentThreeInt.Min());
            //double studentThreeAverage = studentThreeInt.Average();
            //classAverage.Add(studentThreeAverage);

            ////Student 4
            //var studentFour = classGrades[3];
            //string[] studentFourList = studentFour.Split(separator);
            //List<int> studentFourInt = new List<int>();
            //foreach (string s in studentFourList)
            //{
            //    studentFourInt.Add(int.Parse(s));
            //}
            //studentFourInt.Remove(studentFourInt.Min());
            //double studentFourAverage = studentFourInt.Average();
            //classAverage.Add(studentFourAverage);

            //double wholeClassAverage = classAverage.Average();


            //Console.WriteLine(wholeClassAverage);
            //Console.ReadLine();


            //Write function to return each letter alphabetically and with how many instances of that letter are in the string

            //Write a function that takes in a string of letters (Example ALEX)
            // Those letters should return an alphabetially ordered string
            //That string should show  the letter frequenzy

            void GetFrequency (string Test)
            {
                var frequency = Test.ToLower();

                var charFrequencies = from c in frequency.ToArray()
                                      orderby c 
                                      group c by c into groupFrequencies
                                      select groupFrequencies;
                foreach (var c in charFrequencies)
                    Console.Write($"{c.Key}{c.Count()}");

                Console.ReadLine();


            }
            GetFrequency("Alexander Mencia");

        }


    }
}
    
