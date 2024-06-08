namespace Calculator;

public sealed class OperationMenu : IMenu<IOperation>
{
    public OperationMenu(IOperationProvider operationProvider,
        IOperationMenuItemSelector menuItemSelector)
    {
        this.operationProvider = operationProvider;
        ItemSelector = menuItemSelector;
    }

    private readonly IOperationProvider operationProvider;

    public IMenuItemSelector<IOperation> ItemSelector { get; }

    public IMenu<IOperation> Show()
    {
        Console.WriteLine("======== КАЛЬКУЛЯТОР ==========");
        int i = 1;
        foreach (IOperation operation in operationProvider.Get())
            Console.WriteLine($"{i++}. ОПЕРАЦИЯ {operation.Name};");
        return this;
    }
}
