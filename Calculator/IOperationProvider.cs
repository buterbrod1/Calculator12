namespace Calculator;

public interface IOperationProvider
{
    public IEnumerable<Operation> Get();
}
