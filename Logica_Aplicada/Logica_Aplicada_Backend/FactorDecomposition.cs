using System;
using System.Collections.Generic;
using System.Text;

namespace Logica_Aplicada_Backend;

public class FactorDecomposition
{
    // campo
    private int _number;

    // constructor
    public FactorDecomposition(int number)
    {
        Number = number;
    }

    // propiedad
    public int Number
    {
        get => _number;
        set => _number = ValidateNumber(value);
    }

    // metodo para descomponer
    public List<int> GetFactors()
    {
        List<int> factores = new List<int>();
        int n = _number;
        int divisor = 2;

        while (n > 1)
        {
            while (n % divisor == 0)
            {
                factores.Add(divisor);
                n /= divisor;
            }
            divisor++;
        }

        return factores;
    }

    public string ShowFactors()
    {
        List<int> factores = GetFactors();
        string resultado = string.Join(" x ", factores);

        return $"{_number} = {resultado}";
    }
    private int ValidateNumber(int number)
    {
        if (number <= 1)
        {
            throw new ArgumentException($"El número {number} no es válido.");
        }

        return number;
    }
}
