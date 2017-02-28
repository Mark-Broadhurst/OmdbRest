namespace OmdbRest

type ResultType = 
    | Movie
    | Series
    | Episode

type SearchResults = {
        Search: Search list
    }
and Search = {
      Title: string
      Year: int
      imdbID: string
      Type: string
      Poster: string
    }
type Result = {
        Title: string
        Year: int
        Rated: string
        Released: string
        Runtime: string
        Genre: string
        Director: string
        Writer: string
        Actors: string
        Plot: string
        Language: string
        Country: string
        Awards: string
        Poster: string
        Metascore: int
        ImdbRating: double
        ImdbVotes: string
        ImdbID: string
        Type: string
        Response: bool
    }
type Error = {
        Response: bool
        Error: string
    }