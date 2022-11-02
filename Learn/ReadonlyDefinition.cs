namespace Learn
{
    public class ReadonlyDefinition
    {
        //a class called check is defined within which the read only field is defined to store the string
        public class Check
        {
            public readonly string Name = "Welcome to C Sharp";
            public readonly double Kg = 10.50;
            public int Age = 23;
            public bool IsMature { get; } = true;

            public void ChangeVars(string name, double kg)
            {
                // Name = name + "22"; //Compile ERROR: because readonly cannot be instantiated here (but in ctor or init-only setter 
                Age = 24;
                //IsMature = false; // ERROR: IsMature is readonly !!
            }

        }
    }
}
