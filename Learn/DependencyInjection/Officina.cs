namespace Learn.DependencyInjection
{
    /*
     * La Dependency Injection è un pattern nel quale oggetti complessi non istanziano altri oggetti all’interno dei 
     * loro metodi o nel proprio costruttore: le dipendenze saranno fornite dall’esterno tramite il costruttore.
     * 
     * Ogni volta che la dipendenza concreta viene fornita nel costruttore specificando come parametro l’interfaccia 
     * e non la classe concreta si parla di Dependency Injection.
     */


    // Progettare un’officina che permetta di costruire automobili con diversi motori.
    // Per implementare questo requisito supponiamo di avere una classe Automobile che ha bisogno di un motore per funzionare.
    // Il motore può avere diverse implementazioni: Motore1400, Motore1600, ecc.

    // Officina class si occupa di configurare le istanze della classe Automobile, per prepararle al loro corretto funzionamento
    public class Officina // sau atelier - e un INJECTOR
    {
        public Automobile Macchina1400()
            => new Automobile(new Motore1400());

        public Automobile Macchina1600()
            => new Automobile(new Motore1600());
    }

    public interface IMotore
    {
        int AumentaPotenza();
        int DiminuisciPotenza();
    }
    
    public class Motore1400 : IMotore
    {
        public int AumentaPotenza() => 10;
        public int DiminuisciPotenza() => -10;
    }

    public class Motore1600 : IMotore
    {
        public int AumentaPotenza() => 20;
        public int DiminuisciPotenza() => -20;
    }

    // La classe Automobile, che userà il motore, non sarà accoppiata ad un motore specifico, ma all’interfaccia Motore generica.
    // In questo modo possiamo creare automobili con differenti motori.
    public class Automobile
    {
        private int _velocita; // incapsulation
        private IMotore _motore;

        // configurare le dipendenze sempre tramite costruttore (non tramite specifico metodo di set)
        public Automobile(IMotore motore)
        {
            _motore = motore;
        }
        public void Accelera() =>
            _velocita = Math.Min(_motore.AumentaPotenza(), 360);

        public void Frena() =>
           _velocita = Math.Min(0, _motore.DiminuisciPotenza());
    }
}
