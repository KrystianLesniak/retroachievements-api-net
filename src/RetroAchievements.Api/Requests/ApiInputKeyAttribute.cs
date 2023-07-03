namespace RetroAchievements.Api.Requests
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class ApiInputKeyAttribute : Attribute
    {
        public string Key { get; private set; }

        public ApiInputKeyAttribute(string key)
        {
            this.Key = key;
        }
    }
}