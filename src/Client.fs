module OmdbRest.Client

open System.Net.Http
open Newtonsoft.Json
open Newtonsoft.Json.Linq

let client = new HttpClient()

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

let private getResult<'T> search =
    async {
        let url = sprintf "http://www.omdbapi.com/?%s" search
        let! r = client.GetAsync url |> Async.AwaitTask
        let! c = r.Content.ReadAsStringAsync() |> Async.AwaitTask
        let o = JObject(c)
        return o.ToObject<'T>()
    } |> Async.RunSynchronously


let GetById id =
    sprintf "i=%s" id
    |> getResult<Result>

let GetByTitle title =
    sprintf "t=%s" title
    |> getResult<Result>

let GetByTitleAndYear title year =
    sprintf "t=%s&y=%d" title year
    |> getResult<Result>

let SearchByText search =
    sprintf "s=%s" search
    |> getResult<SearchResults>

let SearchByTextAndYear search year =
    sprintf "s=%s&y=%d" search year
    |> getResult<SearchResults>
