namespace Calculator;

public sealed class Sin : Operation
{
    public Sin() : base("Синус",1)
    {

    }

    public override double Run(params double[] numbers)
    {
        return Math.Sin(numbers[0] * double.Pi / 180);
    }
}
