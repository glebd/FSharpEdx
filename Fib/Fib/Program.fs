open System

let readvalue : int =
  let canparse, keyin = Int32.TryParse(Console.ReadLine())
  if canparse then keyin
  else 0

let checkvalue (argv : string[]) : int =
  if argv.Length > 0 then
    let couldparse, consolein = Int32.TryParse(argv.[0])
    if couldparse then
      consolein
    else
      readvalue
  else
    readvalue

let fibonacci n =
  let mutable first = 0
  let mutable second = 1
  let mutable temp = 0
  for index = 1 to n do
    temp <- first + second
    first <- second
    second <- temp
  first

let rec fibonaccirecursive n =
  if n = 0 then 0
  elif n <= 2 then 1
  else fibonaccirecursive (n - 1) + fibonaccirecursive (n - 2)

[<EntryPoint>]
let main argv =
  let input = checkvalue argv
  let calc = fibonaccirecursive input
  Console.WriteLine(calc)
  Console.ReadKey() |> ignore
  0 // return an integer exit code
