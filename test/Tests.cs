//using Xunit;
//using OmdbRest;
//
//namespace Tests
//{
//    public class Tests
//    {
//        [Fact]
//        public void GetById()
//        {
//            var x = Client.GetById("tt1490017");
//            Assert.Equal(x.Title,"The LEGO Movie");
//        }
//
//        [Fact]
//        public void GetByTitle()
//        {
//            var x = Client.GetByTitle("Star Wars");
//            Assert.Equal(x.Title,"Star Wars: Episode IV - A New Hope");
//        }
//
//        [Fact]
//        public void GetByTitleAndYear()
//        {
//            var x = Client.GetByTitleAndYear("Matrix",1999);
//            Assert.Equal(x.Title,"The Matrix");
//        }
//
//        [Fact]
//        public void SearchByText()
//        {
//            var x = Client.SearchByText("Fast and Furious");
//            var s = x.Search[1];
//            Assert.Equal(s.Title, "The Fast and the Furious: Tokyo Drift");
//        }
//
//        [Fact]
//        public void SearchByTextAndYear()
//        {
//            var x = Client.SearchByTextAndYear("Godfather", 1974);
//            var s = x.Search[0];
//            Assert.Equal(s.Title, "The Godfather: Part II");
//        }
//    }
//}
