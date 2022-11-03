namespace Learn.OOPprinciples
{
    /*
     * Moștenirea presupune opțiunea unor clase de a prelua din proprietățile altor clase.
     * 
     * În alte cuvinte, poți crea o clasă child derivată din o alta parent care moștenește 
     * atributele acesteia și poate adăuga atribute proprii. 
     * 
     * Un exemplu bun pentru a explica mostenirea este cazul unei aplicatii prin care vindem masini. 
     * Aceste masini au in general aceleasi proprietati cu unele mici diferente. 
     * Toate vor avea un anumit tip de combustibil, capacitate cilindrica a motorului sau pret. 
     * Diferenta vine atunci cand ne intereseaza numarul de locuri in cazul unui autoturism si masa 
     * maxima de transport in cazul unui camion. In codul nostru, vom avea nevoie de 2 clase si anume 
     * Car si Truck care au destul de multe proprietati in comun. 
     * 
     * Ca sa nu duplicam proprietatile acestea putea sa creem o clasa principala numita Vehicle care va 
     * avea proprietatile comune si apoi clasele Car si Truck care vor mostenii Vehicle si vor avea in 
     * plus proprietatile specifice.
     */
    public static class Inheritance2
    {
        // The species dog and human is in the functionality of the mammal, and modifies the two parameters legs and specie.
        public static void Execute()
        {
            var m = new Mammal();
            Console.WriteLine($"{m.Specie} has {m.NumberOfLegs} legs");

            var d = new Dog();
            Console.WriteLine($"{d.Specie} has {d.NumberOfLegs} legs");

            var h = new Human();
            Console.WriteLine($"{h.Specie} has {h.NumberOfLegs} legs");
        }
    }

    public class Mammal
    {
        private int numberOfLegs = 0;
        private string specie = string.Empty;

        public Mammal()
        {
            specie = "Unknown";
        }

        public Mammal(string specie, int numberOfLegs)
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

    public class Dog : Mammal
    {
        public Dog() : base("Dogs", 4) { }
    }

    public class Human : Mammal
    {
        public Human() : base("Humans", 2) { }
    }
}
