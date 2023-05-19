using System.Collections;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList testArray = new ArrayList();
            testArray.Add(1);
            testArray.Add("Hello");
            for (int i = 0; i < testArray.Count; i++)
            {
                Console.WriteLine(testArray[i]);
            }
            Console.ReadLine();
        }
    }
}