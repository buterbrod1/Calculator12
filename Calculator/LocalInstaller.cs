using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Calculator;

internal class LocalInstaller : IWindsorInstaller
{
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
        container.Register(
            Component.For<IWindsorContainer>().Instance(container),
            Component.For<Application>()
                     .StartUsingMethod("Run"),

            Component.For<IOperationMenuItemSelector>()
                     .ImplementedBy<OperationMenuItemSelector>()
                     .LifestyleTransient(),
            Component.For<IMenuItemSelectorProvider>()
                     .ImplementedBy<OperationMenuItemSelectorView>()
                     .LifestyleTransient(),
            Component.For<IOperationProvider>()
                     .ImplementedBy<OperationProvider>(),

            Component.For<IMenu<IOperation>>()
                     .ImplementedBy<OperationMenu>()
                     .LifestyleTransient(),

            Component.For<Operation>()
                     .ImplementedBy<Addition>(),
            Component.For<Operation>()
                     .ImplementedBy<Substraction>(),
            Component.For<Operation>()
                     .ImplementedBy<Multiplacation>(),
            Component.For<Operation>()
                     .ImplementedBy<Division>(),
            Component.For<Operation>()
                     .ImplementedBy<Sqrt>(),
            Component.For<Operation>()
                     .ImplementedBy<Cos>(),
            Component.For<Operation>()
                     .ImplementedBy<Sin>(),
            Component.For<Operation>()
                     .ImplementedBy<Tg>()
        );
    }
}
