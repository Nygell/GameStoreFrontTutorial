using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GenresClient
{
    private readonly Genre[] genres =
    [
        new Genre
        {
            Id = 1,
            Name = "Fighting"
        },
        new Genre
        {
            Id = 2,
            Name = "Roleplaying"
        },
        new Genre
        {
            Id = 3,
            Name = "Sports"
        }
    ];

    public Genre[] GetGenres() => genres;
}
