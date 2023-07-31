# RetroAchievements API .NET

_A C# .NET library that lets you get achievement, user, and game data from RetroAchievements._
<br><br>
![GitHub Workflow Status (with event)](https://img.shields.io/github/actions/workflow/status/KrystianLesniak/retroachievements-api-net/publish.yml?label=verification)
[![Coverage Status](https://coveralls.io/repos/github/KrystianLesniak/retroachievements-api-net/badge.svg)](https://coveralls.io/github/KrystianLesniak/retroachievements-api-net)
[![GitHub](https://img.shields.io/github/license/KrystianLesniak/retroachievements-api-net)](https://github.com/KrystianLesniak/retroachievements-api-net/blob/main/LICENSE)
[![Nuget](https://img.shields.io/nuget/dt/RetroAchievements.Api) ![Nuget](https://img.shields.io/nuget/vpre/RetroAchievements.Api)](https://www.nuget.org/packages/RetroAchievements.Api/)


## Features

✅ No external dependencies.  
✅ Aligns 1:1 with the RAWeb API.  
✅ Correctly maps types and properties from RAWeb PHP calls.  

******

# Getting started

Learn how to authenticate and start pulling data from RetroAchievements.

## Installation

Install `RetroAchievements.Api` NuGet via Package Manager or run the following dotnet CLI command:

```bash
dotnet add package RetroAchievements.Api
```

## How to begin making API calls

To use any endpoint method in the API, you must first be authorized by RetroAchievements. Fortunately, this is a fairly straightforward process.

1. Visit [your control panel](https://retroachievements.org/controlpanel.php) on the RA website.

2. Find the "Keys" section on the page. Copy the web API key value. **Do not expose your API key anywhere publicly.**

3. You can now create your authorization object using your web API key.

```csharp
string userName = "<your username on RA>";
string webApiKey = "<your web API key>";

var authData = new RetroAchievementsAuthenticationData(userName, webApiKey);
```

4. Now create the RetroAchievementsHttpClient object. It is a disposable object intended to be instantiated once per application, not per use.<br> Authentication Data object is an optional parameter, but if it is not provided, it must be provided for each API method call.

```csharp
using RetroAchievementsHttpClient client = new RetroAchievementsHttpClient(authData);
```

5. Call an Extension Methods on RetroAchievementsHttpClient object to call an API and return response.

```csharp
var response = await client.GetAchievementsEarnedOnDayAsync("SomeUserName", DateTime.Now);

//Or

var request = new GetAchievementsEarnedOnDayRequest("SomeUserName", DateTime.Now);
var response2 = await client.SendAsync(request);
```

6. **Here's a full example of API Call:**

```csharp
using RetroAchievements.Api;
class Program
{
    static string userName = "<your username on RA>";
    static string webApiKey = "<your web API key>";
    // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
    static RetroAchievementsHttpClient client = new RetroAchievementsHttpClient(new RetroAchievementsAuthenticationData(userName, webApiKey));

    static async Task Main()
    {
        //GetAchievementsEarnedOnDay API Call
        
        var response = await client.GetAchievementsEarnedOnDayAsync("SomeUserName", DateTime.Now);
        //Or
        var request = new GetAchievementsEarnedOnDayRequest("SomeUserName", DateTime.Now);
        var response2 = await client.SendAsync(request);
    }
}
```

# Requests List
#### Users
- GetAchievementsEarnedBetween(string user, DateTime from, DateTime to) - Get a list of achievements earned by a user between two dates.
- GetAchievementsEarnedOnDay(string user, DateTime date) - Get a list of achievements earned by a user on a given date.
- ❌ GetGameInfoAndUserProgress() - Temporary disabled: [#46](https://github.com/RetroAchievements/retroachievements-api-js/issues/46) - Get metadata about a game as well as a user's progress on that game.
- GetUserAwards(string username) - Get a list of a user's site awards/badges.
- GetUserClaims(string username) - Get a list of set claims made over the lifetime of a user.
- GetUserAllGamesProgress(string username) - Get hardcore and softcore completion metadata about games a user has played.
- GetUserGameRankAndScore(string username, int gameId) - Get metadata about how a user has performed on a given game.
- GetUserPoints(string username) - Get a user's total points.
- GetUserRankAndScore(string username) - Get a user's total points and rank.
- GetUserGamesProgress(string username, int[] gameIds) - Get a user's progress on a list of specified games.
- GetUserRecentAchievements(string username, IEnumerable<int> gameIds) - Get a list of achievements recently earned by the user.
- ❌ GetUserRecentlyPlayedGames() - Temporary disabled: [#46](https://github.com/RetroAchievements/retroachievements-api-js/issues/46) - Get a list of games a user has recently played.
- ❌ GetUserSummary() - Temporary disabled: [#46](https://github.com/RetroAchievements/retroachievements-api-js/issues/46) - Get a user's profile metadata. 

#### Games
- GetAchievementIdentifiers(int gameId) - Get the list of achievement IDs for a game.
- GetAchievementDistribution(int gameId, bool hardcoreOnly, bool unofficialAchievements) - Get how many players have unlocked how many achievements for a game.
- GetGameData(int gameId) - Get basic metadata about a game.
- GetGameExtendedData(int gameId) - Get extended metadata about a game.
- GetGameRankAndScore(int gameId, RankType rankType) - Get a list of either the latest masters or highest points earners for a game.
- GetGameRating(int gameId) - Get how users have rated a game.

#### Achievements
- GetAchievementUnlocks(int achievementId, int offset, int count) - Get a list of users who have earned an achievement.

#### Consoles
- GetConsoleIds() - Get the complete list of console ID and name pairs on the site.
- GetGamesList(int consoleId, bool onlyWithAchievements, bool getHashes) - Get the complete list of games for a console.

#### Feed
- GetAchievementOfTheWeek() - Get comprehensive metadata about the current Achievement of the Week.
- GetActiveClaims() - Get all active set claims on the site.
- GetClaims(ClaimKind claimKind)- Get all claims of other kinds on the site.
- GetTopTenUsers()-  Get the current top ten users on the site.

#### Tickets
- GetTicketData(int ticketId) - Get details for a specific ticket.
- GetOpenTickets(int offset, int count) - Get open tickets, starting at the most recent.
- GetGamesWithMostTickets(int offset, int count) - Get games with the most open tickets.
- GetUserTicketData(string username) -  Get ticket statistics for the specified user.
- GetGameTicketData(int gameId) -  Get ticket statistics for the specified game.
- GetAchievementTicketData(int achievementId) -  Get ticket statistics for the specified achievement.

## Different usages

### With IHttpClientFactory as Typed Client
TODO: Provide example


## About
This project is heavily inspired and based on the [RetroAchievements/retroachievements-api-js](https://github.com/RetroAchievements/retroachievements-api-js) project.
