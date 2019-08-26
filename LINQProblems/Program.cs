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
            //filter list to only include strings that contain "th"
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsTH = words.Where(w => w.Contains("th"));
            foreach (string word in wordsTH)
            Console.WriteLine(word);
            Console.ReadLine();

            //return list with no duplicates
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var namesDistinct = names.Distinct();
            foreach (string name in namesDistinct)
                Console.WriteLine(name);
            Console.ReadLine();

            //remove each students lowest grade, find average per student, find average of averages
            List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

            //Write function to return each letter alphabetically and with how many instances of that letter are in the string

        }
    }
}
