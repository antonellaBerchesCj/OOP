namespace Learn.OOPprinciples.Abstractions
{
    /*
     * Data abstraction: process of hiding certain details and showing only essential info to the user.
     * Se poate face din clasa abstracta sau interfata.
     * 
     * Clasa abstracta este o clasa restransa ce NU poate fi folosita pentru a crea obiecte.
     * (de ex. nu poti face Animal a = new Animal();)
     * 
     * Pentru a ACCESA o clasa abstracta,TREBUIE MOSTENITA neaparat din alta clasa.
     * 
     * Clasa abstracta poate mosteni dintr-o interfeta (invers nu!)
     */
    internal abstract class Animal_withAbstractClass
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("zzz");
        }

        public void DoWork()
        {
            Pig p = new Pig();
            p.AnimalSound(); // call abstract class
            p.Sleep(); // call regular method (Sleep() is not abstract method)
        }
    }

    internal class Pig : Animal_withAbstractClass // derived class
    {
        public override void AnimalSound()
        {
            Console.WriteLine("guits");
        }
    }
}
