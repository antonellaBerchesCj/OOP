namespace Learn.OOPprinciples.ShoppingCart
{
    public class ArtStudent : Shopper
    {
        public ArtStudent(double totalSpent, double creditLimit) : base(totalSpent, creditLimit)
        {
        }

        public override void BuyFavoriteStuff()
        {
            BuyArtSupplies();
            BuyBlackTurtlenecks();
            BuyDepressingMusic();
        }

        private void BuyDepressingMusic()
        {
            throw new NotImplementedException();
        }

        private void BuyBlackTurtlenecks()
        {
            throw new NotImplementedException();
        }

        private void BuyArtSupplies()
        {
            throw new NotImplementedException();
        }
    }
}
