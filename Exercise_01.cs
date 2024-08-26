internal class Program
{
    private static void Main(string[] args)
    {
        //baitap_01();
        //baitap_02();
        //baitap_03();
        //baitap_04();
        //baitap_05();
        //baitap_06();
        //baitap_07();
        //baitap_08();
        //baitap_09();
        baitap_10();
    }
    static void baitap_01()
    {
        Console.Write("Enter 1st number: ");
        int number_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        int number_2 = Convert.ToInt32(Console.ReadLine());

        int sum = number_1 + number_2;

        Console.WriteLine($"{number_1} + {number_2} = {sum}");
        Console.ReadLine();
    }
    static void baitap_02()
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After swapping");
        Console.WriteLine($"New value of a is: {a}");
        Console.WriteLine($"New value of b is: {b}");
        Console.ReadLine();
    }
    static void baitap_03()
    {
        Console.Write("Enter 1st number: ");
        double number_1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter 2nd number: ");
        double number_2 = Convert.ToDouble(Console.ReadLine());

        double multiply = number_1 * number_2;

        Console.WriteLine($"{number_1} * {number_2} = {multiply}");
        Console.ReadLine();
    }
    static void baitap_04()
    {
        double feet, meter;
        //feet to meter;
        Console.WriteLine("Enter feet:");

        feet = Convert.ToDouble(Console.ReadLine());
        meter = feet / 3.2808399;
        Console.WriteLine("To meter =" + meter);
        Console.ReadLine();
    }
    static void baitap_05()
    {
        double celsius, fahrenheit;
        // Celsius to Fahrenheit;
        Console.WriteLine("Enter Celcius=");
        celsius = Convert.ToDouble(Console.ReadLine());
        fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"To fahrenheit =" + fahrenheit);

        // Fahrenheit to Celsius;
        Console.WriteLine("Enter Fahrenheit=");
        fahrenheit = Convert.ToDouble(Console.ReadLine());
        celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"To celsius =" + celsius);
    }
    static void baitap_06()
    {
        Console.WriteLine("Size of byte: " + sizeof(byte) + "byte");
        Console.WriteLine("Size of sbyte: " + sizeof(sbyte) + "sbyte");
        Console.WriteLine("Size of short: " + sizeof(short) + "short");
        Console.WriteLine("Size of ushort: " + sizeof(ushort) + "ushort");

        Console.WriteLine("Size of int: " + sizeof(int) + "int");
        Console.WriteLine("Size of uint: " + sizeof(uint) + "uint");
        Console.WriteLine("Size of long: " + sizeof(long) + "long");
        Console.WriteLine("Size of ulong: " + sizeof(ulong) + "ulong");

        Console.WriteLine("Size of float: " + sizeof(float) + "float");
        Console.WriteLine("Size of double: " + sizeof(double) + "double");
        Console.WriteLine("Size of decimal: " + sizeof(decimal) + "decimal");
        Console.WriteLine("Size of bool: " + sizeof(bool) + "bool");

        Console.WriteLine("Size of char: " + sizeof(char) + "char");
        Console.ReadKey();
    }
    static void baitap_07()
    {
        //Read character;
        Console.Write("Enter a character: ");
        char character = Console.ReadKey().KeyChar;
        //Print number of this char;
        int ASCIIValue = Convert.ToInt32(character);
        Console.WriteLine($"The ASCII value of " + character + " is: " + ASCIIValue);
    }
    static void baitap_08()
    {
        double R, S;
        double PI = Math.PI;
        Console.WriteLine("Enter the length of side R:");
        R = Convert.ToDouble(Console.ReadLine());
        S = R * R * Math.PI;
        Console.WriteLine($"Area of Square =" + S);
        Console.ReadLine();
    }
    static void baitap_09()
    {
        double a, S;
        Console.WriteLine("Enter the length of side a:");
        a = Convert.ToDouble(Console.ReadLine());
        S = a * a;
        Console.WriteLine($"Area of Square =" + S);
        Console.ReadLine();
    }
    static void baitap_10()
    {
        int totalDays, years, weeks, days; //Convert days to years, weeks and days;
        Console.Write("Enter totalDays:");
        totalDays = Convert.ToInt32(Console.ReadLine());
        years = totalDays / 365;
        weeks = (totalDays % 365) / 7;
        days = (totalDays % 365) % 7;

        Console.WriteLine("Years" + years);
        Console.WriteLine("Weeks" + weeks);
        Console.WriteLine("Days" + days);
        Console.ReadKey();
    }
}