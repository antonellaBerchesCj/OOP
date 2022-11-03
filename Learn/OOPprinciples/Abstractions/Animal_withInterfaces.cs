namespace Learn.OOPprinciples.Abstractions
{
    /*
     * Pentru a acces o interfata, interfata trebuie "implementata" intr-o alta clasa.
     * 
     * by default, members are PUBLIC
     * 
     * C# nu suporta multiple inheritance, dar se poate face asta cu interfete!!
     * 
     * Daca o clasa abstracta are toate metodele abstracte => atunci e interfata!
     */
    internal class Animal_withInterfaces
    {
        public void DoWork()
        {
            Cat c = new Cat();
            c.AnimalSound();
        }
    }

    public class Cat : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("miao");
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public interface IAnimal
    {
        void AnimalSound();
        void Run();
    }
}
