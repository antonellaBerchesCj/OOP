namespace Learn.OOPprinciples
{
    /*
     * Polimorfism este procesul prin care putem sa creem mai multe copii ale aceleiasi metode 
     * care poate sa primeasca inputuri diferite. 
     * 
     * Ca exemplu practic putem sa luam aici din nou un site de vanzari auto. 
     * Am stabilit mai inainte ca avem nevoie de o clasa Vehicle si in ea vrem sa creem o metoda 
     * care sa ne aduca toate informatiile unei masini pe baza numarul de inmatriculare.
     * In acelasi timp vrem sa putem face acest lucru si pe baza seriei de sasiu. 
     * Ei bine aceste 2 date sunt diferite ca format si lungime asa ca avem nevoie de 2 metode, 
     * cu acelasi nume care primesc inputuri diferite dar afiseaza acelasi lucru.
     */
    public static class Polimorphism
    {
        // The class Printer implements three different (polymorph) versions of the method Print.
        // Type of input decides which of the implementations is executed.
        public static void Execute()
        {
            var p = new Printer();
            p.Print(42);
            p.Print(3.14159265359);
            p.Print("I'm Polymorph");

            var v = new Vehicle();
            Console.WriteLine(v.GetVehicleBySerie("VAW939824793288"));
            Console.WriteLine(v.GetVehicleByNrInmatriculare("CJ43ANT"));
        }
    }

    class Printer
    {
        public void Print(int i) => Console.WriteLine($"Printing int: {i}");
        public void Print(double d) => Console.WriteLine($"Printing double: {d}");
        public void Print(string s) => Console.WriteLine($"Printing string: {s}");
    }

    class Vehicle
    {
        public string GetVehicleBySerie(string serieSasiu) => "Audi";
        public string GetVehicleByNrInmatriculare(string serieSasiu) => "BMW";
    }
}