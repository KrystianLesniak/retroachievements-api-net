namespace RetroAchievements.Api.Exceptions
{
    internal static class ArgumentExceptionGuard
    {
        public static void ThrowIfEmpty<T>(IEnumerable<T> enumerable, string parameterName)
        {
            if (!enumerable.Any())
                throw new ArgumentException($"{enumerable.GetType().Name} cannot be empty.", parameterName);
        }
    }
}
