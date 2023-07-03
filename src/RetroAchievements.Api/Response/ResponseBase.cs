using System.Net;
using System.Text.Json;

namespace RetroAchievements.Api.Response.Users
{
    public abstract class ResponseBase : IResponse
    {
        public string ResponseString { get; private set; }
        public JsonElement JsonElement { get; private set; }
        public HttpStatusCode StatusCode { get; private set; }
        public bool IsSuccess => StatusCode == HttpStatusCode.OK;

        internal ResponseBase(string responseString, HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            ResponseString = responseString;

            JsonElement = JsonSerializer.Deserialize<JsonElement>(ResponseString);
        }
    }
}
