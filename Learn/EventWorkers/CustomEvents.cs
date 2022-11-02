using static Learn.CustomDelegates;

namespace Learn.EventWorkers
{
    public class CustomEvents
    {
        public event WorkPerformedHandler WorkPerfomed;
        // WorkPerformedHandler => delegate
        // WorkPerformed => event name

        public void EventsWork()
        {
            Console.Read();
        }
    }
}