namespace Learn.OpenClosedPrinciple
{
    public class BasicCoffeeApp
    {

        private BasicCoffeeMachine coffeeMachine;

        public BasicCoffeeApp(BasicCoffeeMachine coffeeMachine)
        {
            this.coffeeMachine = coffeeMachine;
        }

        public CoffeeModel PrepareCoffee(CoffeeSelection selection)
        {
            CoffeeModel coffee = coffeeMachine.BrewCoffee(selection);
            Console.WriteLine("Coffee is ready!");
            return coffee;
        }

        public void DoWork()
        {
            var beans = new Dictionary<CoffeeSelection, GroundCoffee>();
            beans.Add(CoffeeSelection.FILTER_COFFEE, new GroundCoffee("My favorite filter coffee bean", 1000));
            // beans.Add(CoffeeSelection.ESPRESSO, new GroundCoffee("My favorite espresso bean", 1000));

            BasicCoffeeMachine machine = new BasicCoffeeMachine(beans);

            BasicCoffeeApp app = new BasicCoffeeApp(machine);

            // brew a fresh coffee
            try
            {
                app.PrepareCoffee(CoffeeSelection.FILTER_COFFEE);
            }
            catch (CoffeeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}