namespace Learn.OpenClosedPrinciple
{
    public class CoffeeConfiguration
    {
        public int Val1 { get; set; }
        public int Val2 { get; set; }

        public CoffeeConfiguration(int val1, int val2)
        {
            Val1 = val1;
            Val2 = val2;
        }

        public int GetQuantityWater()
        {
            return 5;
        }

        public int GetQuantityCoffee()
        {
            return 2;
        }
    }
}