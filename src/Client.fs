module OmdbRest.Client

open OmdbRest
open System.Net.Http
open Newtonsoft.Json

let private client = new HttpClient()

let private getResult<'T> search =
    async {
        let url = sprintf "http://www.omdbapi.com/?%s" search
        let! r = client.GetAsync url |> Async.AwaitTask
        let! c = r.Content.ReadAsStringAsync() |> Async.AwaitTask
        return JsonConvert.DeserializeObject<'T>(c)
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
