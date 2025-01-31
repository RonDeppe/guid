using System.Text.RegularExpressions;

class Program
{
    static int _amount = 1;
    static string _separator = "\n";
    static bool _compact = false;

    static void Main(string[] args)
    {
        CheckFlags(args);

        Console.WriteLine(string.Join(_separator, GenerateGuids()));
    }

    static IEnumerable<string> GenerateGuids()
    {
        // Determine the GUID format once instead of recalculating on each iteration
        Func<string> method = _compact ? () => Guid.NewGuid().ToString("N") : () => Guid.NewGuid().ToString();

        for (int i = 0; i < _amount; i++)
        {
            yield return method();
        }
    }


    static void CheckFlags(string[] args)
    {
        var argHandlers = new Dictionary<string, Action<string>>
        {
            { "--amount", value => int.TryParse(value, out _amount) },
            { "--separator", value => _separator = ParseEscapeSequences(value) },
            { "-c", _ => _compact = true }
        };

        for (int i = 0; i < args.Length; i++)
        {
            // Check if the argument exists in argHandlers
            if (argHandlers.TryGetValue(args[i], out var handler))
            {
                // Provide the next argument to the handler if available
                handler(i + 1 < args.Length ? args[i + 1] : null);
            }
        }
    }

    // Parses escape sequences (e.g., "\n" becomes a newline).
    static string ParseEscapeSequences(string input)
    {
        if (input == null) return string.Empty;

        return Regex.Unescape(input);
    }
}
