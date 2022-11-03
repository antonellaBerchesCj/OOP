namespace Learn.SOLID.OpenClosedPrinciple
{
    /// <summary>
    /// Cafea macinata
    /// </summary>
    public class GroundCoffee
    {
        public string Message { get; set; }
        public int Quantity { get; set; }
        public GroundCoffee(string message, int quantity)
        {
            Message = message;
            Quantity = quantity;
        }
    }
}