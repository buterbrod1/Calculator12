namespace Calculator;

public sealed class Sqrt : Operation
{
    public Sqrt() : base("Квадратный корень",1)
    {

    }

    public override double Run(params double[] numbers)
    {
        return Math.Sqrt(numbers[0]);
    }
}
