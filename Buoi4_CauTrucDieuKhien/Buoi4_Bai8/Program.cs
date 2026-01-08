namespace Buoi4_Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tongSoLe = 0;
            while(true)
            {
                Console.WriteLine("Nhap so : ");
                double x = double.Parse(Console.ReadLine());

                if (x < 0)
                {
                    break;
                }
                else if (x > 0 && x % 2 ==0)
                {
                    continue;
                }
                else
                {
                    tongSoLe += x;
                    Console.WriteLine("Tong so le = " + tongSoLe);
                }
                
            }
        }



    }
}
