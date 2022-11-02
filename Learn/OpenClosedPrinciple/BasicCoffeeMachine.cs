namespace Learn.OpenClosedPrinciple
{
    public class BasicCoffeeMachine : ICoffeeMachine
    {
        public BasicCoffeeMachine(Dictionary<CoffeeSelection, GroundCoffee> selection)
        {

        }

        public CoffeeModel BrewCoffee(CoffeeSelection selection)
        {
            throw new NotImplementedException();
        }
    }
}
