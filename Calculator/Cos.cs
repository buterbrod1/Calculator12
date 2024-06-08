namespace Calculator;

public sealed class Cos : Operation
{
    public Cos() : base("Косинус",1)
    {

    }

    public override double Run(params double[] numbers)
    {
        return Math.Cos(numbers[0] * double.Pi / 180);
    }
}
