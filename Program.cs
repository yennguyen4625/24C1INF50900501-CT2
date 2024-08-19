internal class Program
{
    private static void Main(string[] args)
    {
        //baitap_01();
        //baitap_02();
        //baitap_03();
        vidu_01();
    }
    static void baitap_01()
    { 
        Console.Write("Enter a number as Celsius: ");
        float celsius = Convert.ToSingle(Console.ReadLine());
        float kelvin = celsius + 273;
        float fahrenheit = celsius * 18 / 10 + 32;

        Console.WriteLine("{0} in C = {1} in K", celsius, kelvin);
        Console.WriteLine("{0} in C = {1} in F", celsius, fahrenheit);
        Console.ReadLine();
    }
    static void baitap_02()
    {
        double PI = Math.PI;
        Console.Write("Enter radius of the sphere: ");
        float radius = Convert.ToSingle(Console.ReadLine());
        double surface = 4 * PI * Math.Pow(radius, 2);
        double volume = 4 /3 * PI * Math.Pow(radius, 3);

        Console.WriteLine("{0} in R = {1} in S", radius, surface);
        Console.WriteLine("{0} in C = {1} in V", radius, volume);
        Console.ReadLine();
    }
    static void baitap_03()
    {
        Console.Write("Enter 1st number: ");
        int number_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        int number_2 = Convert.ToInt32(Console.ReadLine());

        int adding = number_1 + number_2;
        int substracting = number_1 - number_2;
        int multiply = number_1 * number_2;
        int dividing = number_1 / number_2;
        int remanding = number_1 % number_2;

        Console.WriteLine($"{number_1} + {number_2} = {adding}");
        Console.WriteLine($"{number_1} - {number_2} = {substracting}");
        Console.WriteLine($"{number_1} * {number_2} = {multiply}");
        Console.WriteLine($"{number_1} / {number_2} = {dividing}");
        Console.WriteLine($"{number_1} % {number_2} = {remanding}");
        Console.ReadLine();
    }
    static void vidu_01()
    {
        int a = 5, b = 6;
        Console.WriteLine("a={0}, b={1}", a, b);
        Console.WriteLine($"a={a}, b={b}");
        Console.WriteLine("""Mama said: "hello" """);
        Console.ReadLine();
    }
}