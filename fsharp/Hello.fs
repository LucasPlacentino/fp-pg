// firt time using F#

open System // System class library

let printGreeting name =
    printfn $"What's up {name}?"

let from whom =
    sprintf "from %s" whom // calls func `sprintf` with args "..." & whom (which was an arg of func `from`)

[<EntryPoint>] // explicit program entry point
let main argv =
    printGreeting "John"
    
    let message = from "F#" // calls fun `from` with arg "F#" and sets returned value to `message`
    printfn "Hello world %s" message // calls func `printfn` with args "..." & message
    
    0 // return integer exit code
