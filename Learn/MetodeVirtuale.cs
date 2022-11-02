namespace Learn
{
    /*
        virtual => pt a suprascrie o metoda din clasa parinte in clasa copil
                cl parinte (virtual method)
                cl copil (override method)

     * Deși a treia instanță 
            Feline felineLeu = new Leu();

     * a fost apelată metoda suprascrisă, și nu cea de bază, virtuală; (s-a afisat "Leul vaneaza gazele")
     * Putem concluziona că metodele virtuale, precum și metodele abstracte, pot fi rescrise, suprascrise. 
     
        S-ar putea să dorim să apelăm metoda virtuală din clasa copil (Felina), fără a o suprascrie.
        

     * De fapt, metodele abstracte sunt doar metode virtuale, dar fără o implementare concretă.
     */
    public static class MetodeVirtuale
    {
        public static void Execute()
        {
            Pisica pisica = new Pisica();
            pisica.Vaneaza("soareci");

            Leu leu = new Leu();
            leu.Vaneaza("zebre");

            Feline felineLeu = new Leu();
            felineLeu.Vaneaza("gazele");

            Feline trigru = new Tigru();
            felineLeu.Vaneaza("orice");

            Console.Read();
        }
    }

    public class Feline
    {
        public virtual void Vaneaza(object prada) => Console.WriteLine("Felina vaneaza " + prada);
    }

    public class Pisica : Feline
    {
        public override void Vaneaza(object prada) => Console.WriteLine("Pisica vaneaza " + prada);
    }

    public class Leu : Feline
    {
        public override void Vaneaza(object prada) => Console.WriteLine("Leul vaneaza " + prada);
    }

    public class Tigru : Feline
    {
    }
}