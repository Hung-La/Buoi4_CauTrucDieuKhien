namespace Buoi4_Bai5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập phần tử 1 : ");
        string a1 = Console.ReadLine();
        int value1 = ValidateValue(a1,1);

        Console.WriteLine("Nhập phần tử 2 : ");
        string a2 = Console.ReadLine();
        int value2 = ValidateValue(a2,2);

        Console.WriteLine("Nhập phần tử 3 : ");
        string a3 = Console.ReadLine();
        int value3 = ValidateValue(a3, 3);

        Console.WriteLine("Nhập phần tử 4 : ");
        string a4 = Console.ReadLine();
        int value4 = ValidateValue(a4, 4);

        Console.WriteLine("Nhập phần tử 5 : ");
        string a5 = Console.ReadLine();
        int value5 = ValidateValue(a5, 5);

        int[] numbers = { value1, value2, value3, value4, value5, };
        Print(numbers);
    }

    static int ValidateValue(string value, int i)
    {
        int result;
        while (!int.TryParse(value, out result))
        {
            Console.WriteLine("Sai kiểu dữ liệu");
            Console.WriteLine("----------------");
            Console.WriteLine($"Nhập phần tử {i} : ");
            value = Console.ReadLine();
        }
        return int.Parse(value);
    }

    static void Print(params int[] numbers)
    {
        Console.WriteLine("------------");
        foreach(var number in  numbers)
        {
            Console.WriteLine(number);
        }
    }
}
