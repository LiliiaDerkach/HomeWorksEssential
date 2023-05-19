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
            list.Add("Hello");

            int a = 5;
            object b = a;
            Console.WriteLine(b);
            Console.WriteLine(new string('*', 35));


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine(new string ('*', 35));
            MyArrayList myList = new MyArrayList();
            myList.Add(3.5);
            myList.Add(4);
            myList.Add('T');
            myList.Add("Hello");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            myList.Clear();
            Console.WriteLine(new string ('*', 35));
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.ReadLine();
        }
    }
}