namespace Learn.SOLID.OpenClosedPrinciple
{
    // Open closed principle applied adding this interface and providing two independent implementations of it.
    public interface ICoffeeMachine
    {
        CoffeeModel BrewCoffee(CoffeeSelection selection);
    }
}
