// See https://aka.ms/new-console-template for more information
public static class MyMathHelper
{
    public static int AddWithOverflowCheck(int a, int b)
    {
        try
        {
            checked
            {
                return a + b;
            }
        }
        catch (OverflowException)
        {
            throw new OverflowException("Overflow occurred while adding the two integers.");
        }
    }
}
