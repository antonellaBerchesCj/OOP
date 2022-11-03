namespace Learn.OOPprinciples.Abstractions
{
    /*
     * Abstractizarea este un concept creat ca să ușureze munca. 
     * Ideea de bază este că nu trebuie să știi ce se întâmplă în spatele unei metode care funcționează. 
     * 
     * Spre exemplu, dacă folosești un aparat de făcut cafea, tot ce trebuie să știi este că dacă apeși 
     * pe butonul X primești cafeaua Y. Detalii precum softul și componentele din interior care ajută 
     * la crearea cafelei nu te ajută să faci o cafea mai bună.
     
     * Prin urmare, abstractizarea furnizează doar informațiile de care ai nevoie și ascunde detaliile interne. 
     * Astfel, procesul nu este afectat de clasă și poate scădea considerabil mărimea codului.
     * 
     * 
     * -> To only show the essentials functionality of a class
     * -> To hide away implementation details
     */
    public static class Abstraction
    {
        // The class MammalAbstract can't be instantiated since it have the modifier abstract, only the class Dog and Human can be instantiated,
        // all functionality data which is generic for mammals are hidden in the MammalAbstract class.
        // The abstract method MakeASound needs to be implemented in all classes which inherits from MamiferAbstract.
        public static void Execute()
        {
            var d = new DogAbstract();
            Console.WriteLine($"{d.Specie} has {d.NumberOfLegs} legs");
            Console.Write("The dog say: ");
            d.MakeASound();

            var h = new HumanAbstract();
            Console.WriteLine($"{h.Specie} has {h.NumberOfLegs} legs");
            Console.Write("The human say: ");
            h.MakeASound();
        }
    }

    public abstract class MammalAbstract
    {
        private int numberOfLegs = 0;
        private string specie = string.Empty;
        public abstract void MakeASound();

        public MammalAbstract(string specie, int numberOfLegs)
        {
            this.numberOfLegs = numberOfLegs;
            this.specie = specie;
        }

        public int NumberOfLegs
        {
            get => numberOfLegs;
        }

        public string Specie
        {
            get => specie;
        }

    }

    public class DogAbstract : MammalAbstract
    {
        public DogAbstract() : base("Dogs", 4) { }

        public override void MakeASound() => Console.WriteLine("Wuf");
    }

    public class HumanAbstract : MammalAbstract
    {
        public HumanAbstract() : base("Humans", 2) { }

        public override void MakeASound() => Console.WriteLine("Hello World");
    }
}