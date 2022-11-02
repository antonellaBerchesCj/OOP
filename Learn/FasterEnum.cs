using BenchmarkDotNet.Attributes;
using NetEscapades.EnumGenerators;

namespace Learn
{
    [EnumExtensions]
    public enum Colors
    {
        Black,
        Red,
        SteelBlue
    };

    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public static class FasterEnum
    {
        public const int Length = 2;

        [Benchmark]
        public static string ToStringFast(this Colors value)
            => value switch
            {
                Colors.Black => nameof(Colors.Black),
                Colors.Red => "2nd",
                _ => value.ToString(),
            };

        [Benchmark]
        public static bool IsDefined(Colors value)
             => value switch
             {
                 Colors.Black => true,
                 Colors.Red => true,
                 _ => false,
             };

        [Benchmark]
        public static bool IsDefined(string name)
            => name switch
            {
                nameof(Colors.Black) => true,
                nameof(Colors.Red) => true,
                _ => false,
            };

        [Benchmark]
        public static bool TryParseIgnoreCase(
            [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] string? name,
            out Colors value)
        {
            switch (name)
            {
                case { } s when s.Equals(nameof(Colors.Black), System.StringComparison.OrdinalIgnoreCase):
                    value = Colors.Black;
                    return true;
                case { } s when s.Equals(nameof(Colors.Red), System.StringComparison.OrdinalIgnoreCase):
                    value = Colors.Red;
                    return true;
                case { } s when int.TryParse(name, out var val):
                    value = (Colors)val;
                    return true;
                default:
                    value = default;
                    return false;
            }
        }

        [Benchmark]
        public static bool TryParse(
            [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] string? name,
            out Colors value)
        {
            switch (name)
            {
                case nameof(Colors.Black):
                    value = Colors.Black;
                    return true;
                case nameof(Colors.Red):
                    value = Colors.Red;
                    return true;
                case { } s when int.TryParse(name, out var val):
                    value = (Colors)val;
                    return true;
                default:
                    value = default;
                    return false;
            }
        }

        [Benchmark]
        public static Colors[] GetValues() => new[]
            {
                Colors.Black,
                Colors.Red
            };


        [Benchmark]
        public static string[] GetNames() => new[]
            {
                nameof(Colors.Black),
                nameof(Colors.Red)
            };

    }
}
