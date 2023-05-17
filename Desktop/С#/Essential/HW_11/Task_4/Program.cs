using System.Collections;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2.3);
            list.Add(4);
            list.Add('*');
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }
}