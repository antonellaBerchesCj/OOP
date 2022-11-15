using System.Diagnostics;
using System.Reflection;

namespace Learn.Reflection
{
    public static class RetrievingAllPublicMembers
    {
        public static void DummyMethod()
        {
            var instance = new Target();
            var members =
                typeof(Target)
                    .GetMembers(
                        BindingFlags.Instance |
                        BindingFlags.Public |
                        BindingFlags.DeclaredOnly
                    )
                    .Where(x =>
                        !x.Name.StartsWith("get_") &&
                        !x.Name.StartsWith("set_")
                    )
                    .ToList();

            foreach (var member in members)
                Console.WriteLine(member.Name);
        }

        public class Target
        {
            public void Zero() { }
            public string One { get; set; }
            public string Two { get; set; }
        }
    }
}
