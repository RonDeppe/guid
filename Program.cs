namespace guid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Guid.NewGuid());
            }

            Console.ReadKey();
        }
    }
}
