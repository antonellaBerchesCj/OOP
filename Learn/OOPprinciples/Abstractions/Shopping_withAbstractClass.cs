namespace Learn.OOPprinciples.Abstractions
{
    public abstract class Shopping_withAbstractClass
    {
        private List<string> _basket;
        public Shopping_withAbstractClass()
        {
            _basket = new List<string> { "prod1", "prod2" };
        }

        public List<string> GetBasket() => _basket;


        abstract public void BuyFavouriteFood();
        abstract public void Load();
        abstract public void Store();
        abstract public void Delete();
        abstract public void Update(List<string> products);


        public void DoSomethingElse()
        {
            _basket.ForEach(b => Console.WriteLine(b));
        }

    }

    public class Antonella : IShopping
    {
        public void BuyFavouriteFood()
        {
            List<string> list = new List<string>();
            list.Add("biscuits");
            list.Add("pasta");

            list.ForEach(l => Console.WriteLine(l));
        }

        public void DoSomethingElse()
        {
            Console.WriteLine("zzzz");
        }
    }

    public class David : IShopping
    {
        public void BuyFavouriteFood()
        {
            List<string> list = new List<string>();
            list.Add("chocolate");
            list.Add("sweets");

            list.ForEach(l => Console.WriteLine(l));
        }

        public void DoSomethingElse()
        {
            Console.WriteLine("ruun");
        }
    }

    public class Magazin_Electrocasnice : Shopping_withAbstractClass
    {
        public override void BuyFavouriteFood()
        {
        }

        public override void Delete()
        {
        }

        public override void Load()
        {
        }

        public override void Store()
        {
        }

        public override void Update(List<string> products)
        {
        }
    }

    public class Magazin_Food : Shopping_withAbstractClass
    {
        public override void BuyFavouriteFood()
        {
        }

        public override void Delete()
        {
        }

        public override void Load()
        {
        }

        public override void Store()
        {
        }

        public override void Update(List<string> products)
        {
        }
    }
}
