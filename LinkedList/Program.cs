namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            Console.ReadLine();
        }
    }
}