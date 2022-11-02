namespace Learn.SOLID
{
    // Ogni classe dovrebbe avere una ed una sola responsabilità, interamente incapsulata al suo interno.
    public static class SingleResponsability
    {

    }

    // clasa Pizzeria are muulte responsabilitati. Daca vrem sa schimbam modalita di cottura sau serviciul delivery, trebuie sa schimbam o clasa centrala (Pizzeria).
    public class Pizzeria
    {
        public void GestisciOrdine(Ordine ordine)
        {
            CucinaPizza(ordine);
        }

        private void CucinaPizza(Ordine ordine)
        {
            Cook(ordine.Pizza, ordine.Pizza.TempoDiCottura);
            InviaPizza(ordine);
        }

        private void InviaPizza(Ordine ordine)
        {
            Invia(ordine.Pizza, ordine.Indirizzo ?? "via napoli");
        }

        private void Cook(Pizza pizza, int tempoDiCottura)
        {
            throw new NotImplementedException();
        }

        private void Invia(Pizza pizza, string indirizzo)
        {
            throw new NotImplementedException();
        }
    }

    public class Ordine
    {
        public string? Indirizzo { get; set; }
        public Pizza Pizza { get; set; }
    }
    public class Pizza
    {
        public int TempoDiCottura { get; set; }
    }
}
