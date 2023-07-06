using RetroAchievements.Api.Response.Users;
using System.Net;
using System.Text.Json;

namespace RetroAchievements.Api.Internal.Json
{
    internal class ResponseBuilder
    {
        internal async Task<T> FromResponseAsync<T>(Stream content, HttpStatusCode status) where T : BaseRetroAchievementsResponse
        {

            BaseRetroAchievementsResponse? responseInstance;

            if (status == HttpStatusCode.OK)
            {
                responseInstance = await JsonSerializer.DeserializeAsync<T>(content);

                responseInstance ??= BaseRetroAchievementsResponse.Create(await ReadStreamToStringAsync(content), status);
            }
            else
            {
                responseInstance = BaseRetroAchievementsResponse.Create(await ReadStreamToStringAsync(content), status);
            }

            responseInstance.StatusCode = status;

            return (T)responseInstance;
        }

        internal T FromResponse<T>(Stream content, HttpStatusCode status) where T : BaseRetroAchievementsResponse
        {

            BaseRetroAchievementsResponse? responseInstance;

            if (status == HttpStatusCode.OK)
            {
                responseInstance = JsonSerializer.Deserialize<T>(content);

                responseInstance ??= BaseRetroAchievementsResponse.Create(ReadStreamToString(content), status);
            }
            else
            {
                responseInstance = BaseRetroAchievementsResponse.Create(ReadStreamToString(content), status);
            }

            responseInstance.StatusCode = status;

            return (T)responseInstance;
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
