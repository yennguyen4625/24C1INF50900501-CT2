internal class Program
{
    private static void Main(string[] args)
    {
        //baitap_01();
        //baitap_02();
        baitap_03();
        //baitap_04();
        //baitap_05();
        //baitap_06();
        //baitap_07();
        //baitap_08();
        //baitap_09();
        //baitap_10();
        //baitap_11();
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
     static void baitap_03()
    {
        Console.Write("Input the value for x coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the value for y coordinate");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quandrant");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quandrant");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quandrant");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quandrant");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Origin");
        }
        else if (x == 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the the Y-axis");
        }
        else
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the the X-axis");
        }
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
            Console.Write($"Number {i}: ");
            number = Convert.ToInt32(Console.ReadLine());
            sum += number;
        }
        double average = sum / count;
        Console.WriteLine($"Sum of 10 numbers is {sum}");
        Console.WriteLine($"The average of 10 number is {average}");
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
     static void baitap_07()
    {
        int number = 1;
        int h1;
        Console.WriteLine("Enter h1");
        h1 = int.Parse("0" + Console.ReadLine());
        for (int i = 1; i <= h1; i++)
        {
            for (int j = 1; j <= i; j--)
            {
                Console.Write(number++);

            }
            Console.WriteLine(" ");
        }
     }
     static void baitap_08()
    {
        int number = 1;
        int h3;
        Console.WriteLine("Enter h3");
        h3 = int.Parse("0" + Console.ReadLine());
        for (int i = 1; i <= h3; i++)
        {
            int num = 1;
            for (int j = h3 - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number++ +" ");
            }
            Console.WriteLine();
        }
    }
     static void baitap_09()
    {
    int n;
    Console.WriteLine("Enter the number of terms n:");
    n = int.Parse("0" + Console.ReadLine());

    double sum = 0;
    Console.WriteLine("The terms of the harmonic series:");
    for (int i = 1; i <= n; i++)
    {
        double term = 1.0 / i;
        Console.Write("Term number {0}: ", i);
        Console.WriteLine(term);
        sum += term;
    }
    Console.WriteLine($"The sum of {n} terms is " + sum);
     }
     static void baitap_10()
{
    Console.Write("Enter the lower bound: ");
    int lowerBound = int.Parse("0" + Console.ReadLine());

    Console.Write("Enter the upper bound: ");
    int upperBound = int.Parse("0" + Console.ReadLine());

    Console.WriteLine("Perfect numbers in the given range:");

    for (int number = lowerBound; number <= upperBound; number++)
    {
        int divisorSum = 0;

        for (int divisor = 1; divisor < number; divisor++)
        {
            if (number % divisor == 0)
            {
                divisorSum += divisor;
            }
        }

        if (divisorSum == number)
        {
            Console.WriteLine(number);
        }
    }
}
     static void baitap_11()
{
    int number;
    Console.WriteLine("Enter an integer:");
    number = int.Parse("0" + Console.ReadLine());

    if (number <= 1)
    {
        Console.WriteLine("The number is not a prime number.");
    }
    else
    {
        bool isPrime = true;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine("The number is a prime number.");
        }
        else
        {
            Console.WriteLine("The number is not a prime number.");
        }
    }
}
}
