namespace Learn.OOPprinciples.Abstractions
{
    public abstract class Shopping_withAbstractClass
    {
        private List<string> _basket; // field
        public Shopping_withAbstractClass()
        {
            _basket = new List<string> { "prod1", "prod2" };
        }

        public List<string> GetBasket() => _basket;
        
        public abstract List<string> _basket2 { get; } // property


        abstract public List<string> Load();
        abstract public void Store();
        abstract public void Delete();
        abstract public int Update(List<string> products);


        public void DoSomethingElse()
        {
            _basket.ForEach(b => Console.WriteLine(b));
        }
    }

    public class Magazin_Electrocasnice : Shopping_withAbstractClass
    {
        public override void Delete()
        {
        }

        public override List<string> Load()
        {
            List<string> list = new List<string>();
            list.Add("microunde");
            list.Add("frigider");

            list.ForEach(l => Console.WriteLine(l));

            return list;
        }

        public override void Store()
        {
        }

        public override int Update(List<string> products)
        {
            return 1;
        }
    }

    public class Magazin_Sport : Shopping_withAbstractClass
    {
        private List<string> _basketList = new List<string>();

        public override void Delete()
        {
        }

        public override List<string> Load()
        {
            _basketList.Add("minge");
            _basketList.Add("ghete iarna");

            _basketList.ForEach(l => Console.WriteLine(l));

            return _basketList;
        }

        public override void Store()
        {
        }

        public override int Update(List<string> products)
        {
            return 1;
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
}
