module Tests

open System.Linq
open Xunit
open OmdbRest

[<Theory>]
[<InlineData("tt1490017", "The LEGO Movie")>]
[<InlineData("tt0034583", "Casablanca")>]
[<InlineData("tt3896198", "Guardians of the Galaxy Vol. 2")>]
let GetById (id :string, title :string) = 
    let x = Client.GetById(id);
    Assert.Equal(title, x.Title);


[<Fact>]
let GetByTitle () = 
    let x = Client.GetByTitle "Star Wars"
    Assert.Equal("Star Wars: Episode IV - A New Hope", x.Title)

[<Fact>]
let GetByTitleAndYear () =
    let x = Client.GetByTitleAndYear "Matrix" 1999
    Assert.Equal("The Matrix", x.Title)

[<Fact>]
let SearchByText () =
    let x = Client.SearchByText "Fast and Furious"
    let s = x.Search.First()
    Assert.Equal("The Fast and the Furious", s.Title)

[<Fact>]
let SearchByTextAndYear () =
    let x = Client.SearchByTextAndYear "Godfather" 1974
    let s = x.Search.First()
    Assert.Equal("The Godfather: Part II", s.Title)
