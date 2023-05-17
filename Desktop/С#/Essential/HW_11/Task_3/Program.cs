namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Hello");
            dictionary.Add(2, "Doodbye");
            dictionary.Add(3, "What's up?");
            Console.ReadLine();
        }
    }
}