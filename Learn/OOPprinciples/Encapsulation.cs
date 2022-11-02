namespace Learn.OOPprinciples
{
    /*
     * ENCAPSULATION = este procesul prin care tinem datele si functiile separate de exterior. 
     * Prin incapsulare creem o capsula care delimiteaza interiorul de exterior.
     * 
     * Încapsularea se petrece atunci când un obiect rămâne privat, în interiorul unei clase. 
     * Prin urmare, nici o altă clasă nu are acces la obiect. 
     * Desigur, este posibil să comunici cu obiectul prin metodele prestabilite, dar nu-l poți schimba.
     * 
     */
    public static class Encapsulation
    {
        // The class Counter, have the inner state counterValue which is hidden for the outside and can only be modified by the methods CountUp and CountDown.
        public static void Execute()
        {
            var c = new Counter();
            Console.WriteLine(c.GetCounterValue()); //Expected 0
            c.CountUp(); // value wil be increased to: 1
            c.CountUp(); // value wil be increased to: 2
            Console.WriteLine(c.GetCounterValue()); //Expected 2
            c.CountDown(); // value wil be decreased to: 1
            Console.WriteLine(c.GetCounterValue()); //Expected 1
        }
    }

    public class Counter
    {
        private int counterValue = 0; // INCAPSULARE

        public void CountUp() => counterValue++;

        public void CountDown() => counterValue--;

        public int GetCounterValue() => counterValue;
    }
}
