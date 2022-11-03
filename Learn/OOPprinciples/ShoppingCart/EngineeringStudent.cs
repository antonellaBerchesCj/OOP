namespace Learn.OOPprinciples.ShoppingCart
{
    class EngineeringStudent : Shopper
    {
        public EngineeringStudent(double totalSpent, double creditLimit) : base(totalSpent, creditLimit)
        {
        }

        public override void BuyFavoriteStuff()
        {
            BuyPencils();
            BuyGraphingCalculator();
            BuyPocketProtector();
        }

        private void BuyPocketProtector()
        {
            throw new NotImplementedException();
        }

        private void BuyGraphingCalculator()
        {
            throw new NotImplementedException();
        }

        private void BuyPencils()
        {
            throw new NotImplementedException();
        }
    }
}
