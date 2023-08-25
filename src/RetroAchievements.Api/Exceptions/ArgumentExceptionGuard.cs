namespace RetroAchievements.Api.Exceptions
{
    internal static class ArgumentExceptionGuard
    {
        public static void ThrowIfEmpty<T>(IEnumerable<T> enumerable, string parameterName)
        {
            if (!enumerable.Any())
                throw new ArgumentException($"{enumerable.GetType().Name} cannot be empty.", parameterName);
        }

        public static void ThrowIfNullOrWhitespace(string stringValue, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(stringValue))
                throw new ArgumentException($"{parameterName} cannot be null or whitespace.", parameterName);
        }

        public static void ThrowIfGreaterThan(int integer, string parameterName, int max)
        {
            if (integer > max)
                throw new ArgumentException($"Parameter '{parameterName}' cannot be greater than {max}.", parameterName);
        }
    }
}
