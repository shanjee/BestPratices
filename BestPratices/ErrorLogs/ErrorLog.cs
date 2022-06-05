using System.Runtime.CompilerServices;

namespace BestPratices.ErrorLogs
{
    internal static class ErrorLog
    {
        public static void RecordError(string messaage, [CallerMemberName] string? caller = null,
            [CallerFilePath] string? filepath = null,
            [CallerLineNumber] int? lineNumber = 0)
        {
            Console.WriteLine($"Calling fnction is: {caller} \n file path: {filepath} \n Error Line Number: {lineNumber} \n");
        }
    }
}
