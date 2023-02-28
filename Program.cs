namespace apple_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of kids: ");
            int kids = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of apples: ");
            int apples = Convert.ToInt32(Console.ReadLine());

            int divisibleapples = apples - (apples % kids);
            int perkid = divisibleapples / kids;
            int remainingapples = apples % kids;

            Console.WriteLine("Every kid gets {0} apples and there are {1} apples left.", perkid, remainingapples);
        }
    }
}
