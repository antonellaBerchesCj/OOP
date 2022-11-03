namespace Learn.OOPprinciples.ShoppingCart
{
    public abstract class Shopper
    {
        private double _totalSpent { get; }
        private double _creditLimit { get; }

        public Shopper(double totalSpent, double creditLimit)
        {
            _totalSpent = totalSpent;
            _creditLimit = creditLimit;
        }

        public void ShopTillYouDrop()
        {
            while (_totalSpent < _creditLimit)
                BuyFavoriteStuff();
        }
        public abstract void BuyFavoriteStuff();
        //{
            // No implementation here - we don’t know
            // what our student likes to buy!
        //}
    }
}
