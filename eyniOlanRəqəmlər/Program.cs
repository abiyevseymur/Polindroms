using System;

namespace eyniOlanRəqəmlər
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Maximum ardici reqemi daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());
            int y = 10;
            int result = 0;
            int first;
            int last;
            int x = 0;

            for (int j = y; j < b; j *= 10)
            {
                x = j;

                for (int i = a; i < b; i++)
                {
                    result = i;
                    last = result / x;
                    first = result % x;
                    //creat last  = reverse;
                    int left = last;
                    int rev = 0;
                    while (left > 0)
                    {
                        int r = left % 10;
                        rev = rev * 10 + r;
                        left = left / 10;
                    }


                    if (last > 0 && rev == first)
                    {
                        Console.WriteLine(result);

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
