namespace propery2
{
    class Program
    {
        static void Main(string[] args)
        {
            NBClass sun = new NBClass();
            sun.Price = 25000;
            Console.WriteLine("sun筆電單價{0}", sun.Price);
            Console.Read();
        }
    }
}