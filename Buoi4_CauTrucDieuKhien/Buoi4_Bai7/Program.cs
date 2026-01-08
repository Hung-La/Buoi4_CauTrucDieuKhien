namespace Buoi4_Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phep tinh");
            string phepTinh = Console.ReadLine();

            switch (phepTinh)
            {
                case "+": Add(a,b); break;
                case "-": Sub(a, b); break;
                case "*": Mul(a, b); break;
                case "/": Div(a, b); break;
            }

        }

        static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        static void Sub(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void Mul(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        static void Div(double a, double b)
        {
            Console.WriteLine(a / b);
        }
    }
}
