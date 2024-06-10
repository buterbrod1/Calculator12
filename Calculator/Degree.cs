namespace Calculator;

public sealed class Degree : Operation
{
    public Degree() : base("Степень", 2)
    {

    }

    public override double Run(params double[] numbers)
    {
        return Math.Pow(numbers[0], numbers[1]);
    }
}