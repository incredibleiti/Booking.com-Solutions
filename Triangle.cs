    static int triangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            return 0;
        else if (a == b && b == c)
            return 1;
        else if (a + b > c && a + c > b && b + c > a)
            return 2;
        else
            return 0;
    }
// new solution in leetcode foldee
