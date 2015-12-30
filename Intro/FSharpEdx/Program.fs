open System

let cylinderVolume r h = Math.PI * r * r * h

[<EntryPoint>]
let main argv =

  printf "Enter cylinder radius: "
  let r = Console.ReadLine()

  printf "Enter cylinder height: "
  let h = Console.ReadLine()

  printfn "Cylinder volume is %f" (cylinderVolume (float r) (float h))
  0