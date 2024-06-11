namespace _6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stacky stacky = new Stacky(10);
            Console.WriteLine("Hello, World!");
            stacky.Push(1);
            stacky.Push(2);
            stacky.Push(3);
            stacky.Print();
            int var = stacky.Pop();
            Console.WriteLine($"This var is popped {var}");
            stacky.Print();
        }
    }
}
