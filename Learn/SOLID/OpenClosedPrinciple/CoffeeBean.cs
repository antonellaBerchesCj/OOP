namespace Learn.SOLID.OpenClosedPrinciple
{
    public class CoffeeBean
    {
        public string GetName()
        {
            return "Coffee uno";
        }

        public int GetQuantity()
        {
            return 100;
        }

        public void SetQuantity(int value)
        {
            value = 3;
        }
    }
}