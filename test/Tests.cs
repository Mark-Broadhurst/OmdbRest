using Xunit;
using OmdbRest;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void GetById()
        {
            var x = Client.GetById("tt1490017");
            Assert.True(x.Title == "The Lego Movie");
        }

        [Fact]
        public void GetByTitle()
        {
            var x = Client.GetByTitle("Star Wars");
            Assert.True(x.Title == "Star Wars: Episode IV - A New Hope");
        }

        [Fact]
        public void GetByTitleAndYear()
        {
            var x = Client.GetByTitleAndYear("Matrix",1999);
            Assert.True(x.Title == "The Matrix");
        }

        [Fact]
        public void SearchByText()
        {
            var x = Client.SearchByText("Fast and Furious");

        }

        [Fact]
        public void SearchByTextAndYear()
        {
            var x = Client.SearchByTextAndYear("Misson Imposible", 2000);

        }
    }
}
