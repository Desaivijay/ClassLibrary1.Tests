using Xunit;
using tmdb_web_application.Models;

public class MovieViewModelTests
{
    [Fact]
    public void MovieViewModel_PropertiesAreSetCorrectly()
    {
        // Arrange
        var movie = new MovieViewModel
        {
            Title = "Test Movie",
            Overview = "This is a test movie.",
            ReleaseDate = "2023-08-11"
        };

        // Act - No specific action, just setting properties

        // Assert
        Assert.Equal("Test Movie", movie.Title);
        Assert.Equal("This is a test movie.", movie.Overview);
        Assert.Equal("2023-08-11", movie.ReleaseDate);
    }
}