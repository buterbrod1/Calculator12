namespace Calculator;

public sealed class Tg : Operation
{
    public Tg() : base("Тангенс",1)
    {

    }

    public override double Run(params double[] numbers)
    {
        return Math.Tan(numbers[0] * double.Pi / 180);
    }
}