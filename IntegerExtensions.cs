using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            // put your code here
            //throw new NotImplementedException();
            int d = 0;
            while (a % 2 == 0 && b % 2 == 0 )
            {
                    a = a / 2;
                    b = b / 2;
                    d = d + 1;
            }
            while (a != b)
            {
                if (a % 2 == 0)
                {
                    a = a / 2;
                }
                else
                {
                    if (b % 2 == 0)
                    {
                        b = b / 2;
                    }
                    else
                    {
                        if (a > b)
                        {
                            a = (a - b) / 2;
                        }
                        else
                        {
                            b = (b - a) / 2;
                        }
                    }
                }
            
            }
            int v = (a * 2 ^ d)-1 ;
            return v;

        }

    }
}

