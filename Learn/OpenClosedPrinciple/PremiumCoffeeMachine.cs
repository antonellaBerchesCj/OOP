namespace Learn.OpenClosedPrinciple
{
    public class PremiumCoffeeMachine : ICoffeeMachine
    {
        public Dictionary<CoffeeSelection, CoffeeConfiguration> _configMap;
        public Dictionary<CoffeeSelection, CoffeeBean> _beans;
        public Grinder _grinder;
        public BrewingUnit _brewingUnit;

        public PremiumCoffeeMachine(Dictionary<CoffeeSelection, CoffeeBean> beans)
        {
            _beans = beans;
            _grinder = new Grinder();
            _brewingUnit = new BrewingUnit();

            _configMap = new Dictionary<CoffeeSelection, CoffeeConfiguration>();
            _configMap.Add(CoffeeSelection.FILTER_COFFEE, new CoffeeConfiguration(30, 480));
            _configMap.Add(CoffeeSelection.ESPRESSO, new CoffeeConfiguration(8, 28));
        }

        //@Override
        public CoffeeModel BrewCoffee(CoffeeSelection selection) => selection switch
        {
            CoffeeSelection.ESPRESSO => BrewEspresso(),
            CoffeeSelection.FILTER_COFFEE => BrewFilterCoffee(),
            _ => throw new CoffeeException("CoffeeSelection [" + selection + "] not supported!"),
        };

        public CoffeeModel BrewEspresso()
        {
            CoffeeConfiguration config = _configMap[CoffeeSelection.ESPRESSO];

            // grind the coffee beans
            GroundCoffee groundCoffee = _grinder.Grind(_beans[CoffeeSelection.ESPRESSO], config.GetQuantityCoffee());

            // brew an espresso
            var result = _brewingUnit.Brew(CoffeeSelection.ESPRESSO, groundCoffee, config.GetQuantityWater());
            return result;
        }

        public CoffeeModel BrewFilterCoffee()
        {
            CoffeeConfiguration config = _configMap[CoffeeSelection.FILTER_COFFEE];

            // grind the coffee beans
            GroundCoffee groundCoffee = _grinder.Grind(_beans[CoffeeSelection.FILTER_COFFEE], config.GetQuantityCoffee());

            // brew a filter coffee
            var result = _brewingUnit.Brew(CoffeeSelection.FILTER_COFFEE, groundCoffee, config.GetQuantityWater());

            return result;
        }

        public void AddCoffeeBeans(CoffeeSelection sel, CoffeeBean newBeans)
        {
            CoffeeBean existingBeans = _beans[sel];
            if (existingBeans != null)
            {
                if (existingBeans.GetName() == newBeans.GetName())
                {
                    existingBeans.SetQuantity(existingBeans.GetQuantity() + newBeans.GetQuantity());
                }
                else
                {
                    throw new CoffeeException("Only one kind of coffee supported for each CoffeeSelection.");
                }
            }
            else
            {
                _beans.Add(sel, newBeans);
            }
        }

    }
}
