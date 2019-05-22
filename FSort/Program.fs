// Learn more about F# at http://fsharp.org

open System
open Merge
open Quick
[<EntryPoint>]
let main argv =
    let randFunc = 
        let rnd = (new System.Random(int System.DateTime.Now.Ticks)).Next
        rnd
    let randomArr = Array.init 100 randFunc
    let arr  =[5;3;2;1;6;7;8;10;15;11]
    let res = sort randomArr
    printfn "%A" res
    printfn "%d" !c
    printfn "%d" !mcount
    0 // return an integer exit code
