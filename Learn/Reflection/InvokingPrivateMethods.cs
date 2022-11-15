using static Learn.Reflection.InvokingAMethodByString;
using System.Reflection;
using System.Diagnostics;

namespace Learn.Reflection
{
    public static class InvokingPrivateMethods
    {

        public static void DummyMethod()
        {
            var instance = new Target();
            var method =
                typeof(Target)
                    .GetMethod("GetSecret",
                        BindingFlags.Instance |
                        BindingFlags.NonPublic
                    );

            var result = method.Invoke(instance, parameters: null);

            Console.WriteLine(result);
        }
        public class Target
        {
            private string GetSecret() => "42";
        }
    }
}
