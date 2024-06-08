namespace Calculator;

public sealed class Substraction : Operation
{
    public Substraction() : base("Вычитание",2)
    {

    }

    public override double Run(params double[] numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result -= numbers[i];
        }
        return result;
    }
}
