internal class Program
{
    private static void Main(string[] args)
    {
        //baitap_01();
        //baitap_02();
        //baitap_04();
        baitap_05();
        //baitap_06();
    }
    static void baitap_01()
    {
        Console.Write("Enter your number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
        Console.ReadLine();
    }
    static void baitap_02()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a;
        max = max < b ? b : c;
        max = Math.Max(Math.Max(a, b), c);
        Console.WriteLine($"The largest number is {max}");
    }
    static void baitap_04()
    {
        Console.Write("Enter 1st side of the triangle: ");
        int side_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd side of the triangle: ");
        int side_2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 3rd side of the triangle: ");
        int side_3 = Convert.ToInt32(Console.ReadLine());

        if (side_1 == side_2 && side_1 == side_3)
        {
            Console.WriteLine("This triangle is Equilateral");
        }
        else if (side_1 == side_2 || side_1 == side_3 || side_2 == side_3)
        {
            Console.WriteLine("This triangle is Isosceles");
        }
        else
        {
            Console.WriteLine("This triangle is Scalene");
        }
        Console.ReadLine();
    }
    static void baitap_05()
    {
        int number;
        int sum = 0;
        int count = 10;

        Console.WriteLine("Enter 10 numbers: ");
        for (int i = 1; i <= count; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            sum += number;
        }
        double average = sum / count;
        Console.WriteLine("Sum of 10 numbers is ");
        Console.WriteLine("The average of 10 number is ");
        Console.ReadLine() ;
    }
    static void baitap_06()
    {
        Console.Write("Enter your number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The multiplication table of {number}:");
        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }
    }
}
