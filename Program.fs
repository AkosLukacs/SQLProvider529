// Learn more about F# at http://fsharp.org

open System
open FSharp.Data.Sql

[<Literal>]
let connStr = "Data Source=.\SQL2017; Initial Catalog=HR; Integrated Security=True"

type HR = SqlDataProvider<Common.DatabaseProviderTypes.MSSQLSERVER, connStr>


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let runtimeConnectionString = connStr
    let ctx = HR.GetDataContext runtimeConnectionString
    let employeesFirstName =
        query {
            for emp in ctx.Dbo.Employees do
            select emp.FirstName
        } |> Seq.head

    printfn "Hello %s!" employeesFirstName
    System.Threading.Thread.Sleep 2000
    0 // return an integer exit code
