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
            List<string> testOne = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics", "tether" };
            void FindTH(List<string> words)
            {
                var wordsTH = words.Where(w => w.Contains("th"));
                foreach (string word in wordsTH)
                    Console.WriteLine(word);
                Console.ReadLine();
            }
            FindTH(testOne);

            ////return list with no duplicates
            List<string> testTwo = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            void RemoveDuplicates(List<string> names)
            {
                var namesDistinct = names.Distinct();
                foreach (string name in namesDistinct)
                    Console.WriteLine(name);
                Console.ReadLine();
            }
            RemoveDuplicates(testTwo);

            ////remove each students lowest grade, find average per student, find average of averages
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            char[] separator = { ',' };
            List<double> classAverage = new List<double>();
            void GetClassAverage(List<string> myClass)
            {
                for (int i = 0; i < myClass.Count; i++)
                {
                    var student = myClass[i];
                    string[] studentList = student.Split(separator);
                    List<int> studentInt = new List<int>();
                    foreach (string s in studentList)
                    {
                        studentInt.Add(int.Parse(s));
                    }
                    studentInt.Remove(studentInt.Min());
                    double studentAverage = studentInt.Average();
                    classAverage.Add(studentAverage);
                    Console.WriteLine("Student " + (i + 1) + " has an average of: " + studentAverage);
                }
                double wholeClassAverage = classAverage.Average();


                Console.WriteLine("This classes average is: " + wholeClassAverage);
                Console.ReadLine();
            }

            GetClassAverage(classGrades);


            //Write function to return each letter alphabetically and with how many instances of that letter are in the string
            //Take in a string from user
            //1. split the string into individual letters
            //2. for each letter, search the list for repeat instances and count them
            //3. remove the recurring strings as they are counted
            //4. add number at the end of the letter string
            //5. bring the list together to form one string

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
    
