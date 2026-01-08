namespace Buoi4_Bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so n : ");
            int x = 0;
            try
            {
                string A = Console.ReadLine();
                while (A == "")
                {
                    Console.WriteLine("Nhap lai so n : ");
                    A = Console.ReadLine();
                }
                x = int.Parse(A);

            }
            catch
            {
                Console.WriteLine("Nhap sai kieu du lieu");
            }

            TinhGiaiThua(x, out long ketqua);
            Console.WriteLine("Giai thua cua so n = " + ketqua);

        }

        static void TinhGiaiThua(int x, out long ketqua)
        {
            ketqua = 1;
            for (int i = x; i > 0; i--)
            {
                ketqua *= i;
            }

        }
    }
}
