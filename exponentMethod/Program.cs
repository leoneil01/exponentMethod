class Program
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\n{num1} raise to {num2} is {GetPower(num1, num2)}");
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