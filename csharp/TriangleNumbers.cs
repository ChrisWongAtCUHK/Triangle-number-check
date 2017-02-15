using System;

public class TriangleNumbers
{

    public static bool isTriangleNumber(long number)
    {
        long i = 1;
        while (true)
        {
            number -= i;
            if (number == 0)
            {
                return true;
            }
            if (number < 0)
            {
                return false;
            }
            i++;
        }
    }
}

