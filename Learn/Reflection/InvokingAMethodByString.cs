using System.Diagnostics;
using System.Reflection;

namespace Learn.Reflection
{
    public static class InvokingAMethodByString
    {
        public static void DummyMethod()
        {
            var instance = new Target();
            var method =
                typeof(Target)
                    .GetMethod("One",
                        BindingFlags.Instance |
                        BindingFlags.Public
                    );

            method.Invoke(instance, parameters: null);
        }

        public class Target
        {
            public void One() => Console.WriteLine("One");
        }
    }
}
