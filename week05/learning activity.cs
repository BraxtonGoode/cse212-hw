static integer SumofDigits(integer n)
{
    // creating a recursive function to calculate all the numbers between 1 to n
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n + SumofDigits(n - 1);
    }
}