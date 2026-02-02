namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
        return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        

        public static string Add(int a, int b, bool dollars)
        {
            var sum = a + b;
            if (dollars && sum ==1)
            {
                return $"{sum} dollar"; 
            }
            else if (dollars && sum > 1)
            {
                return $"{sum} dollars";
            }
            return sum.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 5));
            Console.WriteLine(Add(2.5m, 2.5m));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(10, 20, true));
            Console.WriteLine(Add(10, 20, false));
        }
    }
}
