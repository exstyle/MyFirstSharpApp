// Learn more about F# at http://fsharp.org

open System

//[<EntryPoint>]
//let main argv =
//    printfn "Hello World from F#!"
//    0 // return an integer exit code


[<EntryPoint>]                          
let main argv =  
    let items = argv.Length
    printfn "Passed in %d items: %A" argv.Length argv           
    let s = Console.ReadLine()
    0 // return an integer exit code    4

    //  %d => int
    //  %f => float
    //  %b => Boolean
    //  %s => string
    //  %0 => .ToString()
    //  %A => F# pretty-print representation of the argument. if none exists => %0