namespace HW_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection carCollection = new CarCollection();
            carCollection.Add("Mersedes", 2023);
            carCollection.Add("Ford", 1999);
            Console.WriteLine("The number of cars is: " + carCollection.Count);
            Console.WriteLine(carCollection[1]);
            Console.WriteLine(new string ('_', 30));
            carCollection.Show();
            carCollection.DeleteAll();
            Console.WriteLine(new string ('-',30));
            carCollection.Show();
            Console.ReadLine();
        }
    }
}