using System.Reflection;

namespace Learn.Reflection
{
    public static class InvokingGenericMethods
    {
        public static void DummyMethod()
        {
            var instance = new Target();
            var method =
                typeof(Target)
                    .GetMethod("Generic",
                        BindingFlags.Instance |
                        BindingFlags.Public
                    );

            var generic = method.MakeGenericMethod(typeof(string));

            var result = generic.Invoke(instance, new[] { "Antonella" });

            Console.WriteLine(result);
        }

        public class Target
        {
            public string Generic<T>(T input) => $"Hello {input}!";
        }
    }
}
