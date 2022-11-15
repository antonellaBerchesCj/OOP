using ReflectionMagic;

namespace Learn.Reflection
{
    // > dotnet add package ReflectionMagic
    /*
     * When using this package, we need to be aware that misspellings will not be caught at compile time. 
     * It’s dynamic so there are no compiler assurances. We’re living on the edge!
     */
    public static class UsingReflectionMagic
    {
        public static void DummyMethod()
        {
            var instance = new Target();
            Console.WriteLine(instance.AsDynamic().secret);
        }
        public class Target
        {
            private string secret = "42";
        }
    }
}
