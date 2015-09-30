using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TeadsSponsoredChallenge
{
    class TeadsSponsoredChallenge
    {
        static void Main(string[] args)
        {
            StreamReader myReader = File.OpenText(Directory.GetCurrentDirectory()+@"\Tests\test1.txt");


            int n = int.Parse(myReader.ReadLine()); // the number of adjacency relations
            for (int i = 0; i < n; i++)
            {
                string[] inputs = myReader.ReadLine().Split(' ');
                int xi = int.Parse(inputs[0]); // the ID of a person which is adjacent to yi
                int yi = int.Parse(inputs[1]); // the ID of a person which is adjacent to xi
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("1"); // The minimal amount of steps required to completely propagate the advertisement
            Console.ReadKey();
        }
    }
}
class People
{
    public int ID;
    public List<int> Neighbors;
}
