namespace Buoi4_CauTrucDieuKhien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Câu điều kiện if
            int age = 6;
            if (age >= 6)
            {
                Console.WriteLine("Du tuoi vao lop 1");
            }
            else
            {
                Console.WriteLine("Chua du tuoi");
            }

            // Câu điều kiện switch case
            int ageV2 = 6;
            switch (ageV2)
            {
                case 1:
                    Console.WriteLine("You are 1 year old.");
                    break;
                case 2:
                    Console.WriteLine("You are 2 year old.");
                    break;
                case 3:
                    Console.WriteLine("You are 3 year old.");
                    break;
                case 4:
                    Console.WriteLine("You are 4 year old.");
                    break;
                case 5:
                    Console.WriteLine("You are 5 year old.");
                    break;
                default:
                    Console.WriteLine("You are older than 5 years.");
                    break;
            }

            // Vòng lặp
            // 1. Vòng lặp for

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("gia tri : " + i);
            }

            // 2. Vòng lặp while
            int a = 0;
            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }

            // 3. Vòng lặp do-while
            int number;
            do
            {
                Console.WriteLine("Nhap so :");
                number = int.Parse(Console.ReadLine());
            }
            while (number < 5);

            // 4. foreach
            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }


            // Từ khoá break -> tránh vòng lặp vô hạn, tránh lặp lại những phần tử không cần thiết
            for (int i = 0; i < 10; i++)
            {
                int x = 0;
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(x);
                }
                if (i % 7 == 0)
                {
                    Console.WriteLine("Tim thay : " + i);
                    break;
                }
            }

            // Từ khoá continue -> Bỏ qua nhưng ko thoát

            for (int i = 0; i <= 100; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    continue;
                }
                Console.WriteLine("So ko chia het cho 7 : " + i);
            }

            // từ khoá return -> thoát khỏi hàm
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i != 0)
            //    {
            //        return;
            //    }
            //    Console.WriteLine("So ko chia het cho  : " + i);
            //}


            // In bang cuu chuong
            Console.WriteLine("---------------------------------");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
