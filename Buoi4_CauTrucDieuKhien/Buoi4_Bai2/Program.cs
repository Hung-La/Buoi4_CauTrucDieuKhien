namespace Buoi4_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập thứ trong tuần");
            string A = Console.ReadLine();

            int result;
            while (!int.TryParse(A, out result))
            {
                Console.WriteLine("Sai kiểu dữ liệu");
                Console.WriteLine("----------------");
                Console.WriteLine("Nhập thứ trong tuần");
                A = Console.ReadLine();
            }
            SwitchFunction(result);
        }

        static void SwitchFunction(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("Chủ nhật");
                    break;
                case 2:
                    Console.WriteLine("Thứ 2");
                    break;
                case 3:
                    Console.WriteLine("Thứ 3");
                    break;
                case 4:
                    Console.WriteLine("Thứ 4");
                    break;
                case 5:
                    Console.WriteLine("Thứ 5");
                    break;
                case 6:
                    Console.WriteLine("Thứ 6");
                    break;
                default:
                    Console.WriteLine("Không hợp lệ");
                    break;
            }
        }

    }
}
