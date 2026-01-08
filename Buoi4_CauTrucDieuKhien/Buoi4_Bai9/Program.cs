namespace Buoi4_Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -3, -5, 0, 5, 7, 10, 6, 5, 6, -8 };
            TimMinMax(out int min, out int max, numbers);
            Console.WriteLine("So lon nhat " + max);
            Console.WriteLine("So nho nhat " + min);
            TinhTrungBinhCong(numbers);
            InNguocLaiMang(numbers);
        }

        static void TimMinMax(out int min, out int max, params int[] numbers)
        {
            min = int.MaxValue;
            max = int.MinValue;

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }
            }
        }

        static void TinhTrungBinhCong(params int[] numbers)
        {
            
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double trungBinhcong = sum / numbers.Length;
            Console.WriteLine("Trung binh cong = " + trungBinhcong);
        }

        static void InNguocLaiMang(params int[] numbers)
        {
            int[] newArray = new int[numbers.Length];
            int j = 0;
            for (int i = numbers.Length - 1;  i >= 0; i--)
            {
                newArray[j] = numbers[i];
                j++;
            }

            foreach (int number in newArray)
            {
                Console.Write(number + " ");
            }
        }

    }
}
