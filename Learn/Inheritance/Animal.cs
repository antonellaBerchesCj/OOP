namespace Learn.Inheritance
{
    /* 
     * Allows us to perform a single action in diferent ways. Code reusability
     */
    internal class Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Animal sound!");
        }

        public virtual void AnimalSound_WithVirtual()
        {
            Console.WriteLine("Animal sound");
        }

        public void DoWork_WithoutKeyworkVirtualAndOverride()
        {
            Console.WriteLine("Without Virtual keyword: ");

            Animal a = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            a.AnimalSound();
            pig.AnimalSound();
            dog.AnimalSound();

            // OUTPUT: Animal sound, Animal sound, Animal sound
        }

        public void DoWork_WithKeyworkVirtual()
        {
            Console.WriteLine("\nWith Virtual keyword: ");
            Animal a = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            a.AnimalSound_WithVirtual();
            pig.AnimalSound_WithVirtual();
            dog.AnimalSound_WithVirtual();

            // OUTPUT: Animal sound, guits, ham
        }
    }

    internal class Pig : Animal // derived class
    {
        public void AnimalSound()
        {
            Console.WriteLine("guits");
        }

        public override void AnimalSound_WithVirtual()
        {
            Console.WriteLine("guits");
        }
    }

    internal class Dog : Animal // derived class
    {
        public void AnimalSound()
        {
            Console.WriteLine("ham");
        }

        public override void AnimalSound_WithVirtual()
        {
            Console.WriteLine("ham");
        }
    }
}
