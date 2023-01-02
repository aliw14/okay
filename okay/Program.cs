namespace okay;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;
        int[] numbers = { 2, 4, 6, 5, 7, -5, -8 };
        for (int i = 0; i < numbers.Length; i++)
        {   if (numbers[i] > 0)
                if (numbers[i] % 2 != 0) 
            {
                sum += numbers[i];
                count++;

            }
        

        }Console.WriteLine(sum);
        Console.WriteLine(count);
    }
}

