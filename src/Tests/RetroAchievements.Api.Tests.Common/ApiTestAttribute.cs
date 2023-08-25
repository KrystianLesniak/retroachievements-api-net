using NUnit.Framework;

namespace RetroAchievements.Api.Tests.Common
{
    public class ApiTestAttribute : CategoryAttribute
    {
        public ApiTestAttribute() : base("ApiTest") { }
    }
}
