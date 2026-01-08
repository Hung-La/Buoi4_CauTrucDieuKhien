namespace Buoi4_Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] {-3.5,-5,-2.5,-1.5,0,0.5,8,1.2,2.3,2.5 }; 
            var newArray = SapXep(numbers);
            foreach (var number in newArray)
            {
                Console.WriteLine(number);
            }
        }

        static void InMang(double[] numbers)
        {
            foreach (double number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        static void TimMinMax(double[] numbers, out double min,out double max)
        {
            min = double.MaxValue;
            max = double.MinValue;
            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
        }

        static double[] SapXep(double[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
    }
}
