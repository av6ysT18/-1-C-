internal class Program
{
    private static void Main(string[] args)
    {
        int number; 
         
        Console.WriteLine("Ведите число");
        number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число не четное");
        }
    }
}