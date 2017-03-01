using System.Linq;
using Xunit;
using OmdbRest;

namespace Tests
{
    public class Tests
    {
        [Theory]
        [InlineData("tt1490017", "The LEGO Movie")]
        [InlineData("tt0034583", "Casablanca")]
        [InlineData("tt3896198", "Guardians of the Galaxy Vol. 2")]
        public void GetById(string id, string title)
        {
            var x = Client.GetById(id);
            Assert.Equal(title, x.Title);
        }

        [Fact]
        public void GetByTitle()
        {
            var x = Client.GetByTitle("Star Wars");
            Assert.Equal("Star Wars: Episode IV - A New Hope", x.Title);
        }

        [Fact]
        public void GetByTitleAndYear()
        {
            var x = Client.GetByTitleAndYear("Matrix",1999);
            Assert.Equal("The Matrix", x.Title);
        }

        [Fact]
        public void SearchByText()
        {
            var x = Client.SearchByText("Fast and Furious");
            var s = x.Search.First();
            Assert.Equal("The Fast and the Furious", s.Title);
        }

        [Fact]
        public void SearchByTextAndYear()
        {
            var x = Client.SearchByTextAndYear("Godfather", 1974);
            var s = x.Search.First();
            Assert.Equal("The Godfather: Part II", s.Title);
        }
    }
}
