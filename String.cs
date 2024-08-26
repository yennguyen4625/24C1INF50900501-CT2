internal class Program
{
    private static void Main(string[] args)
    {
        //baitap_01();
        //baitap_02();
        //baitap_03();
        //baitap_04();
    }
    static void baitap_01()
    {
        Console.Write("Input the string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine($"The string you entered is: {inputString}");
        Console.ReadKey();
    }
    static void baitap_02()
    {
        Console.Write("Input the string: ");
        string inputString = Console.ReadLine();
        int lenght = 0;
        foreach (char c in inputString )
        {
            lenght++;
        }
        Console.WriteLine($"Lenght of the string is: {lenght}");
        Console.ReadKey();
    }
    static void baitap_03()
    {
        Console.Write("Input the string: ");
        string inputString = Console.ReadLine();
        Console.WriteLine("The characters of the string are:");
        foreach (char c in inputString)
        {
            Console.Write(c + " ");
        }
        Console.ReadKey();
    }
    static void baitap_04()
    {
        Console.Write("Input the string: ");
        string inputString = Console.ReadLine();
        // Print each character in the string in reverse order
        Console.WriteLine("The characters of the string in reverse are:");
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            Console.Write(inputString[i] + " ");
        }
        Console.ReadKey();
    }
}