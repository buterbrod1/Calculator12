namespace Calculator;

public sealed class Multiplacation : Operation
{
    public Multiplacation() : base("Умножение",2)
    {

    }

    public override double Run(params double[] numbers)
    {
        double result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result *= numbers[i];
        }
        return result;
    }
}
