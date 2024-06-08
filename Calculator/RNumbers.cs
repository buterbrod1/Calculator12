namespace Calculator
{
    internal class RNumbers 
    {
        public double[] numbers = new double[1000];
        public double[] RNums(int NumCount)
        {
            for (int i = 0; i != NumCount; i++)
            {
                Console.Write($"Введите число {i + 1} : ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());

            }
            return numbers;
        }

    }
}

