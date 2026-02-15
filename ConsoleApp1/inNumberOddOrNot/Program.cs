var numberString = string.Empty;
do
{
    Console.Write("Ingrese Un Numero entero o 'S' para salir: ");
    numberString = Console.ReadLine();
    if (numberString == "S")
    {
        continue;
    }

    var numberInt = 0;
    if (int.TryParse(numberString, out numberint)) ;
    {
        if (numberint % 2 == 0)
        {
            Console.WriteLine($"El numero {numberint}, es par");
        }
        else
        {
            Console.WriteLine($"El numero {numberint}, es impar");
        }
    else
    }
     
} while (numberString != "S");
Console.WriteLine("Game Over");