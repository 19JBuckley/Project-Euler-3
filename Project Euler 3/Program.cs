

namespace ProjectEuler_3
{
    class Program
    {
        static long input = 600851475143;

        static void Main()
        {
            long lastPrimeFactor = 0;

            for (long i = 2; i < input; i++)
            {
                if (primeBool(i) && input % i == 0)
                {
                    lastPrimeFactor = i;
                }
            }
            Console.WriteLine(lastPrimeFactor);
        }

        static bool primeBool(long n)
        {
            if (n < 4) return n > 1;
            if (n % 2 == 0 || n % 3 == 0) return false;

            long limit = (long)Math.Sqrt(n);
            for (long i = 5; i <= limit; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}