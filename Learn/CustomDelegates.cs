namespace Learn
{
    public class CustomDelegates
    {
        // delegate definition, pipeline
        public delegate int WorkPerformedHandler(int hours, WorkType type);
        public void InstanceDelegate()
        {
            // delegate instance invoked (del1, del2 are pieplines)
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            //DoWork(del2);

            // add del2 and del3 to the del1 invocation list
            //del1 += del2;
            //del1 += del3;

            // or
            del1 += del2 + del3; // output: wp1: 9, wp2: 9, wp3: 9

            var finalHours = del1(9, WorkType.GoToMeetings);
            Console.WriteLine(finalHours); // output: 12 (the last delegate wins) -- only one return type, because we assign only one value (finalHours)

            
            Console.Read();
        }

        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.GoToMeetings);
        }


        // handler methods
        static int WorkPerformed1(int hours, WorkType type)
        {
            Console.WriteLine("WorkPerfomed1 called " + hours.ToString());
            return hours;
        }
        static int WorkPerformed2(int hours, WorkType type)
        {
            Console.WriteLine("WorkPerfomed2 called " + hours.ToString());
            return hours + 2;
        }
        static int WorkPerformed3(int hours, WorkType type)
        {
            Console.WriteLine("WorkPerfomed3 called " + hours.ToString());
            return hours + 3;
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
