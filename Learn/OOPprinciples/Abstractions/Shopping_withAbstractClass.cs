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
        abstract public void Load(List<string> products);
        abstract public void Update(List<string> products);
        abstract public void Store(List<string> products);
        abstract public void Delete(List<string> products);


        public void DoSomethingElse()
        {
            _basket.ForEach(b => Console.WriteLine(b));
        }

        //public void Execute()
        //{
        //    Antonella a = new Antonella();
        //    a.BuyFavouriteFood(); // call abstract class
        //    a.DoSomethingElse(); // call regular method (DoSomethingElse() is not abstract method)

        //    Console.WriteLine();

        //    David d = new David();
        //    d.BuyFavouriteFood(); // call abstract class
        //    d.DoSomethingElse(); // call regular method (DoSomethingElse() is not abstract method)

        //    Shopping_withAbstractClass s = new Magazin();
        //    s.BuyFavouriteFood();
        //    s.DoSomethingElse();

        //}
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

    public class Magazin : Shopping_withAbstractClass
    {
        public override void BuyFavouriteFood()
        {
            throw new NotImplementedException();
        }

        public override void Delete(List<string> products)
        {
            throw new NotImplementedException();
        }

        public override void Load(List<string> products)
        {
            throw new NotImplementedException();
        }

        public override void Store(List<string> products)
        {
            throw new NotImplementedException();
        }

        public override void Update(List<string> products)
        {
            throw new NotImplementedException();
        }
    }
}
