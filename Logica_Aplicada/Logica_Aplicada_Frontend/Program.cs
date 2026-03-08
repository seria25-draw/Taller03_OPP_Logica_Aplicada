using Logica_Aplicada_Backend;

Console.Write("Ingrese orden de la matriz: ");

int n;
string? input;

while (true)
{
    input = Console.ReadLine();

    if (input is null)
    {
        Console.Write("No input detected. Please enter a number: ");
        continue;
    }

    if (int.TryParse(input, out n))
        break;

    Console.Write("Entrada inválida. Ingrese un número entero: ");
}

var matrix = new MatrixOperations(n);

Console.WriteLine("\nMatriz generada:\n");
matrix.ShowMatrix();

Console.WriteLine("\nLa sumatoria es: " + matrix.GetSum());
Console.WriteLine("El valor máximo es: " + matrix.GetMax());
Console.WriteLine("El valor mínimo es: " + matrix.GetMin());

//factores descomposicion

Console.WriteLine("### Descomposición en Factores ###");

Console.Write("Ingrese el número a descomponer: ");
int numero = int.Parse(Console.ReadLine()!);

var factor = new FactorDecomposition(numero);

Console.WriteLine(factor.ShowFactors());