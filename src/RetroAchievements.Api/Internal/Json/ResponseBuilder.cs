using RetroAchievements.Api.Response;
using System.Net;
using System.Text.Json;

namespace RetroAchievements.Api.Internal.Json
{
    internal class ResponseBuilder
    {
        internal static async Task<TResponse> FromResponseAsync<TResponse>(Stream content, HttpStatusCode status) where TResponse : RetroAchievementsResponse, new()
        {
            TResponse? responseInstance;

            if (status == HttpStatusCode.OK)
            {
                try
                {
                    responseInstance = await JsonSerializer.DeserializeAsync<TResponse>(content);
                }
                catch (JsonException)
                {
                    responseInstance = new TResponse() { FailedResponseString = await ReadStreamToStringAsync(content), HttpStatusCode = status };
                }

                responseInstance ??= new TResponse() { FailedResponseString = await ReadStreamToStringAsync(content), HttpStatusCode = status };
            }
            else
            {
                responseInstance = new TResponse() { FailedResponseString = await ReadStreamToStringAsync(content), HttpStatusCode = status };
            }

            responseInstance.HttpStatusCode = status;

            return responseInstance;
        }

        internal static TResponse FromResponse<TResponse>(Stream content, HttpStatusCode status) where TResponse : RetroAchievementsResponse, new()
        {

            TResponse? responseInstance;

            if (status == HttpStatusCode.OK)
            {
                try
                {
                    responseInstance = JsonSerializer.Deserialize<TResponse>(content);
                }
                catch (JsonException)
                {
                    responseInstance = new TResponse() { FailedResponseString = ReadStreamToString(content), HttpStatusCode = status };
                }

                responseInstance ??= new TResponse() { FailedResponseString = ReadStreamToString(content), HttpStatusCode = status };
            }
            else
            {
                responseInstance = new TResponse() { FailedResponseString = ReadStreamToString(content), HttpStatusCode = status };
            }

            responseInstance.HttpStatusCode = status;

            return responseInstance;
        }

        private static string ReadStreamToString(Stream stream)
        {
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }

        private static async Task<string> ReadStreamToStringAsync(Stream stream)
        {
            using StreamReader reader = new(stream);
            return await reader.ReadToEndAsync();
        }
    }
}
