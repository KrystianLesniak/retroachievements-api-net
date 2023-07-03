using System.Net;
using System.Text.Json;

namespace RetroAchievements.Api.Response.Users
{
    public abstract class ResponseBase : IResponse
    {
        public string JsonString { get; private set; }
        public JsonElement JsonElement { get; private set; }
        public HttpStatusCode StatusCode { get; private set; }
        public bool IsSuccess => StatusCode == HttpStatusCode.OK;

        internal ResponseBase(string jsonString, HttpStatusCode statusCode)
        {
            JsonString = jsonString;
            JsonElement = JsonSerializer.Deserialize<JsonElement>(JsonString);
            StatusCode = statusCode;
        }
    }
}
