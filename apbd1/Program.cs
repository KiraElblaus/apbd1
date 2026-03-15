// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Second commit");
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        int a = 19;
    }
    
    public double CalculateAverage(List<int> nums)
    {
        Console.WriteLine("Function was called");
        return nums.Average();
    }
    
    public int CalculateMax(List<int> nums)
    {
        return nums.Max();
    }
}
