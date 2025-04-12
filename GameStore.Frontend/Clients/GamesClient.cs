using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games =
    [
        new GameSummary
        {
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99m,
            ReleaseDate = new DateOnly(1992, 7, 15)
        },
        new GameSummary
        {
            Id = 2,
            Name = "Final Fantasy XIV",
            Genre = "Roleplaying",
            Price = 59.99m,
            ReleaseDate = new DateOnly(2010, 9, 30)
        },
        new GameSummary
        {
            Id = 3,
            Name = "Fifa 23",
            Genre = "Sports",
            Price = 69.99m,
            ReleaseDate = new DateOnly(2022, 9, 30)
        }
    ];

    private readonly Genre[] genres = new GenresClient().GetGenres();

    public GameSummary[] GetGames() => [.. games];

    public void AddGame(GameDetails game)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);

        var genre = genres.First(g => g.Id == int.Parse(game.GenreId));
        var gameSummary = new GameSummary{
            Id = games.Count + 1,
            Name = game.Name,
            Genre = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
        
        games.Add(gameSummary);
    }
}
