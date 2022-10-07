// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System
let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = a / b
[<EntryPoint>]
let main argumentos =
    let val1 = Console.ReadLine()
    let val2 = Console.ReadLine()
    let num1 = Convert.ToInt32(val1)
    let num2 = Convert.ToInt32(val2)
    let res = suma num1 num2
    let res2 = resta num1 num2
    let res3 = multiplicacion num1 num2
    let res4 = division num1 num2
    Console.WriteLine("La suma de "+val1+" y "+val2+" es: "+res.ToString())
    Console.WriteLine("La resta de "+val1+" y "+val2+" es: "+res2.ToString())
    Console.WriteLine("La multiplicacion de "+val1+" y "+val2+" es: "+res3.ToString())
    Console.WriteLine("La division de "+val1+" y "+val2+" es: "+res4.ToString())
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
