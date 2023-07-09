namespace RetroAchievements.Api.Requests
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class ApiInputKeyAttribute : Attribute
    {
        public string Key { get; private set; }
        public CustomOption Option { get; private set; }

        public ApiInputKeyAttribute(string key, CustomOption option = CustomOption.None)
        {
            this.Key = key;
            Option = option;
        }
    }

    internal enum CustomOption
    {
        None = 0,
        DateTimeToUnixSeconds = 10,
        DateTimeToShortDate = 11,
    }
}