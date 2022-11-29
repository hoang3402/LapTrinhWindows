namespace LTWindows.Core
{
    internal class Number
    {
        public static bool isEven(long a)
        {
            return (a & 1) == 0;
        }

        public static bool isOdd(long a)
        {
            return !isEven(a);
        }

        public static bool isPositive(long a)
        {
            return a > 0;
        }

        public static bool isNegative(long a)
        {
            return a < 0;
        }

        public static bool isPrimeNumber(long a)
        {
            if (a < 2)
            {
                return false;
            }

            if (a == 2)
            {
                return true;
            }

            if (a % 2 == 0)
            {
                return false;
            }

            for (long i = 3; i <= Math.Sqrt(a); i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static ulong TotalDivisor(long a)
        {
            ulong result = 0;
            for (long i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    result += (ulong)i;
                }
            }
            return result;
        }

        public static bool isPerfectNumber(long a)
        {
            if ((ulong)(2 * a) == TotalDivisor(a))
            {
                return true;
            }
            return false;
        }

        public static bool isFibonacciNumber(long a)
        {
            long Fib1 = 1;
            long Fib2 = 1;
            long Fib = 1;
            while (Fib < a)
            {
                Fib = Fib1 + Fib2;
                Fib1 = Fib2;
                Fib2 = Fib;
            }
            if (Fib == a) return true;
            return false;
        }
    }
}
