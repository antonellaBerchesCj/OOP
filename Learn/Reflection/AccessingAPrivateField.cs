using System.Reflection;

namespace Learn.Reflection
{
    // https://khalidabuhakmeh.com/common-usecases-for-dotnet-reflection
    public class AccessingAPrivateField
    {
        public static void DummyMethod()
        {
            var instance = new Target();
            var field =
                typeof(Target)
                    .GetField("secret",
                        BindingFlags.Instance |
                        BindingFlags.NonPublic
                    );

            var value = (string)field.GetValue(instance);

            Console.WriteLine(value);
        }

        public class Target
        {
            private string secret = "42";
        }
    }
}
