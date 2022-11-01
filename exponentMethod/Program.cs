class Program
{
    static void Main(string[] args)
    {
        int num1, num2;
    }

    static int GetPower(int baseNumber, int powerNumber)
    {
        int result = 1;

        for (int i = 0; i < powerNumber; i++)
        {
            result = result * baseNumber;
        }
        
        return result;
    }
}