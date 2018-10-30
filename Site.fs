namespace WebSharper6

open WebSharper
open WebSharper.Sitelets
open WebSharper.UI
open WebSharper.UI.Server
open WebSharper.UI.Templating

type EndPoint =
    | [<EndPoint "/">] Home

type Index = Templating.Template<"Main.html">

module Site =
    let HomePage ctx =
        Content.Page(
            Index()
                .Doc()
        )

    [<Website>]
    let Main =
        Application.MultiPage (fun ctx endpoint ->
            match endpoint with
            | EndPoint.Home -> HomePage ctx
        )
