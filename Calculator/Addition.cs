namespace Calculator;

public sealed class Addition : Operation
{
    public Addition() : base("Сложение",2)
    {

    }

    public override double Run(params double[] numbers)
    {
        return numbers.Sum();
    }
}
