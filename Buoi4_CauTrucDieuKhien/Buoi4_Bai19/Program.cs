namespace Buoi4_Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12456;
            TinhTongSoNhapVao(number);
        }

        static void TinhTongSoNhapVao(int number)
        {
            string A = number.ToString();

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] - '0';
            }

            Console.WriteLine(sum);
        }
    }
}
