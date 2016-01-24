open System

[<EntryPoint>]
let main argv =
  printf "Enter empty name or age to quit.\n"
  let mutable canContinue = true
  while canContinue do
    printf "Name: "
    let name = Console.ReadLine()
    if name = "" then canContinue <- false
    else
      printf "Age: "
      let parsed, age = Int32.TryParse(Console.ReadLine())
      if parsed = true && age > 0 then
        let group =
          if age >= 20 then "no longer a teenager"
          elif age < 20 && age > 13 then "teenager"
          else "child"
        printf "%s (%d): %s\n" name age group
      else canContinue <- false
  0 // return an integer exit code
