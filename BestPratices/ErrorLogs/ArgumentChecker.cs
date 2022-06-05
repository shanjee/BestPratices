using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace BestPratices.ErrorLogs
{
    public static partial class ArgumentChecker
    {
        public static T NotNull<T>([NotNull] this T? value, [CallerArgumentExpression("value")] string name = "")
            where T : class =>
            value ?? throw new ArgumentNullException(name);

        public static string NotNullOrWhiteSpace([NotNull] this string? value, [CallerArgumentExpression("value")] string name = "") =>
            string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, name), name)
                : value;

        public static int NotNegative(this int value, [CallerArgumentExpression("value")] string name = "") =>
            value < 0
                ? throw new ArgumentOutOfRangeException(name, value, string.Format(CultureInfo.CurrentCulture, name))
                : value;
    }

    public record Person
    {
        public Person(string name, int age, Uri link) =>
            (this.Name, this.Age, this.Link) = (name.NotNullOrWhiteSpace(), age.NotNegative(), link.NotNull().ToString());

        // Compiled to:
        // this.Name = ArgumentChecker.NotNullOrWhiteSpace(name, "name");
        // this.Age = ArgumentChecker.NotNegative(greeting, "greeting");
        // this.Link = ArgumentChecker.NotNull(link, "link").ToString();

        public string Name { get; }
        public int Age { get; }
        public string Link { get; }

        public void SayGreeting(string greeting)
        {
            ArgumentNullException.ThrowIfNull(greeting);
            Console.WriteLine($"{Name} - {greeting}");
        }
    }
}
