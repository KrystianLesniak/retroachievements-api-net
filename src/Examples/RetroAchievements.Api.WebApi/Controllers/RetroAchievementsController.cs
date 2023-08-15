using Microsoft.AspNetCore.Mvc;

namespace RetroAchievements.Api.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetroAchievementsController : ControllerBase
    {
        private readonly IRetroAchievementsHttpClient retroAchievementsHttpClient;

        public RetroAchievementsController(IRetroAchievementsHttpClient retroAchievementsHttpClient)
        {
            this.retroAchievementsHttpClient = retroAchievementsHttpClient;
        }

        [HttpGet("getconsoles")]
        public async Task<IEnumerable<(int, string)>> GetConsoles()
        {
            var consoleIdsResponse = await retroAchievementsHttpClient.GetConsoleIdsAsync();

            return consoleIdsResponse.Items.Select(x => (x.Id, x.Name));
        }
    }
}