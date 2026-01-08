namespace Buoi4_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so : ");
            string a = Console.ReadLine();
            int n;
            while(!int.TryParse(a, out n))
            {
                Console.WriteLine("Sai kieu du lieu");
                Console.WriteLine("----------------");
                Console.WriteLine("Nhap so : ");
                a = Console.ReadLine();
            }

            ForFunction(n);
        }

        static void ForFunction(int x)
        {
            Console.WriteLine("-----------");
            for (int i = 1; i <= x; i++)
            {
                
                Console.WriteLine(i);
            }
        }
    }
}
