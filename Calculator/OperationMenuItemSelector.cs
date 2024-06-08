namespace Calculator;

public sealed class OperationMenuItemSelector : IOperationMenuItemSelector
{
    public OperationMenuItemSelector(
        IMenuItemSelectorProvider selector,
        IOperationProvider operationProvider)
    {
        this.selector = selector;
        this.operationProvider = operationProvider;
    }

    private readonly IMenuItemSelectorProvider selector;
    private readonly IOperationProvider operationProvider;

    public Operation Select()
    {
        int id = selector.GetMenuItemId();
        return operationProvider.Get().ElementAt(id - 1);
    }
}
