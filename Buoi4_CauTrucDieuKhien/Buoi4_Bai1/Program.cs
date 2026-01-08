namespace Buoi4_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap số nguyên : ");
            string A = Console.ReadLine();
            int x;
            while(!int.TryParse(A, out x))
            {
                Console.WriteLine("Sai kieu du lieu");
                Console.WriteLine("-----------------");
                Console.WriteLine("Nhap so nguyen : ");
                A = Console.ReadLine();
            }
            IfFunction(x);
        }

        static void IfFunction(int x)
        {
            if (x > 0)
            {
                Console.WriteLine("Số dương");
            }
            else if (x < 0)
            {
                Console.WriteLine("Số âm");
            }
            else if (x == 0)
            {
                Console.WriteLine("Số không");
            }
        }

    }
}
