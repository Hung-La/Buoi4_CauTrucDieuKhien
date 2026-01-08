namespace Buoi4_Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void IfElse_ForLoop(params int[] numbers)
        {
            int soDuong, soAm, soKhong;
            soDuong = 0;
            soAm = 0;
            soKhong = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    soDuong++;
                }
                else if (number < 0)
                {
                    soAm++;
                }
                else if (number == 0)
                {
                    soKhong++;
                }

            }

            Console.WriteLine($"Có {soDuong} số dương");
            Console.WriteLine($"Có {soAm} số âm");
            Console.WriteLine($"Có {soKhong} số không");
        }
    }
}
