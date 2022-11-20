internal class Program
{
    private static void Main(string[] args)
    {
        int number;

        Console.WriteLine("Ведите число");
        number = Convert.ToInt32(Console.ReadLine());

        int count = 1;
        while (count <= number)
        {
           if(count % 2 == 0 ) Console.Write(count);
            count++;
        }
        Console.WriteLine();
    }
}



