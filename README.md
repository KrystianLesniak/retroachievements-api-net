<h1 align="center">RetroAchievements API .NET - Work In Progress ⏳</h1>

<p align="center">
  <i>A C# .NET library that lets you get achievement, user, and game data from RetroAchievements.</i>
  <br /><br />
</p>

<hr />

## Features

✅ No external dependencies.  
✅ Aligns 1:1 with the RAWeb API.  
✅ Correctly maps types and properties from RAWeb PHP calls.  

<hr />

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

# Project Status - Work In Progress ⏳
#### Users
- ✅ GetAchievementsEarnedBetweenAsync(string user, DateTime from, DateTime to) - Get a list of achievements earned by a user between two dates.
- ✅ GetAchievementsEarnedOnDayAsync(string user, DateTime date) - Get a list of achievements earned by a user on a given date.
- ⏳ GetGameInfoAndUserProgressAsync() - Get metadata about a game as well as a user's progress on that game.
- ✅ GetUserAwardsAsync() - Get a list of a user's site awards/badges.
- ⏳ GetUserClaimsAsync() - Get a list of set claims made over the lifetime of a user.
- ⏳ GetUserCompletedGamesAsync() - Get hardcore and softcore completion metadata about games a user has played.
- ⏳ GetUserGameRankAndScoreAsync() - Get metadata about how a user has performed on a given game.
- ⏳ GetUserPointsAsync() - Get a user's total hardcore and softcore points.
- ⏳ GetUserProgressAsync() - Get a user's progress on a list of specified games.
- ⏳ GetUserRecentAchievementsAsync() - Get a list of achievements recently earned by the user.
- ⏳ GetUserRecentlyPlayedGamesAsync() - Get a list of games a user has recently played.
- ⏳ GetUserSummaryAsync() - Get a user's profile metadata. 

#### Games
- ⏳ GetAchievementCountAsync() - Get the list of achievement IDs for a game.
- ⏳ GetAchievementDistributionAsync() - Get how many players have unlocked how many achievements for a game.
- ⏳ GetGameAsync() - Get basic metadata about a game.
- ⏳ GetGameExtendedAsync() - Get extended metadata about a game.
- ⏳ GetGameRankAndScoreAsync() - Get a list of either the latest masters or highest points earners for a game.
- ⏳ GetGameRatingAsync() - Get how users have rated a game.

#### Achievements
- ⏳ GetAchievementUnlocksAsync() - Get a list of users who have earned an achievement.

#### Consoles
- ⏳ GetConsoleIdsAsync() - Get the complete list of console ID and name pairs on the site.
- ⏳ GetGameListAsync() - Get the complete list of games for a console.

#### Feed
- ✅ GetAchievementOfTheWeekAsync() - Get comprehensive metadata about the current Achievement of the Week.
- ✅ GetActiveClaimsAsync() - Get all active set claims on the site.
- ✅ GetClaimsAsync(ClaimKind claimKind)- Get all claims of other kinds on the site.
- ✅ GetTopTenUsersAsync()-  Get the current top ten users on the site.

#### Tickets
- ⏳ GetTicketDataAsync() - Get details for a specific ticket.
- ⏳ GetOpenTicketsAsync() - Get open tickets, starting at the most recent.
- ⏳ GetGamesWithMostTicketsAsync() - Get games with the most open tickets.
- ⏳ GetUserTicketDataAsync() -  Get ticket statistics for the specified user.
- ⏳ GetGameTicketDataAsync() -  Get ticket statistics for the specified game.
- ⏳ GetAchievementTicketDataAsync() -  Get ticket statistics for the specified achievement.

<br />

[External To-Do](docs/ToDo.md)


## Different usages

TODO



## About
This project is heavily inspired and based on the [RetroAchievements/retroachievements-api-js](https://github.com/RetroAchievements/retroachievements-api-js) project.