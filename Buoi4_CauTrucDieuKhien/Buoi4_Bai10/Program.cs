namespace Buoi4_Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 2, 3, 4, 5, 5.5, 6, 7, 8, 9, 9.5 };
            var result = PhanLoaiDiem(numbers);

            foreach (var item in result)
            {
                Console.WriteLine("Diem : " + item.Item1);
                Console.WriteLine("Phan Loai : " + item.Item2);
                Console.WriteLine("**************************");
            }
        }

        static List<(double, string)> PhanLoaiDiem(params double[] numbers)
        {
            List<(double, string)> phanLoai = new List<(double, string)>();

            foreach (double number in numbers)
            {
                if (number >= 0 && number <= 10)
                {
                    if (number >= 8)
                    {
                        phanLoai.Add((number, "Gioi"));
                    }
                    else if (number >= 6.5 && number <= 7.9)
                    {
                        phanLoai.Add((number, "Kha"));
                    }
                    else if (number >= 5 && number <= 6.4)
                    {
                        phanLoai.Add((number, "Trung Binh"));
                    }
                    else
                    {
                        phanLoai.Add((number, "Yeu"));
                    }
                }

            }

            return phanLoai;
        }

    }
}
