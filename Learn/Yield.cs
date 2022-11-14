namespace Learn
{
    /*
     * La parola chiave yield è una parola chiave contestuale in C#. 
     * Viene utilizzato con la parola chiave return per specificare che il metodo in cui viene utilizzato 
     * è un iteratore. Il miglior utilizzo della parola chiave yield è quando stiamo iterando una lista. 
     * 
     * Con la parola chiave yield, possiamo scorrere una lista e restituire un elemento dalla lista alla 
     * funzione chiamante, quindi tornare al bucle e avviarlo dall’indice successivo. 
     * 
     * La parola chiave yield restituisce un oggetto della classe IEnumerator.
     * Quindi, il tipo di ritorno della funzione che utilizza la parola chiave yield deve essere IEnumerator. 
     * Il seguente esempio di codice ci mostra come possiamo usare la parola chiave yield in C#.
     */
    public static class Yield
    {
        // La parola chiave yield prende un valore dall’elenco Values, lo restituisce alla funzione chiamante,
        // e poi continua il bucle dall’iterazione successiva se la funzione Strings() viene invocata di nuovo.
        public static IEnumerable<string> Strings()
        {
            List<string> Values = new List<string> { "value1", "value2", "value3", "value4" };
            foreach (var val in Values)
            {
                yield return val;
            }
        }
        public static void Execute()
        {
            foreach (var i in Strings())
            {
                Console.WriteLine(i);
            }
        }
    }
}
