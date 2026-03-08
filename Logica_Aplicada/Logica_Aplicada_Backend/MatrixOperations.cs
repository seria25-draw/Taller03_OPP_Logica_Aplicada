namespace Logica_Aplicada_Backend;

public class MatrixOperations
{
    // campos
    private int[,] _matrix;
    private int _n;

    // constructores
    public MatrixOperations()
    {
        _n = 1;
        _matrix = new int[_n, _n];
        FillMatrix();
    }

    // constructor con parámetro
    public MatrixOperations(int n)
    {
        _n = ValidateN(n);
        _matrix = new int[_n, _n];
        FillMatrix();
    }

    // propiedades
    public int N
    {
        get => _n;
        set
        {
            _n = ValidateN(value);
            _matrix = new int[_n, _n];
            FillMatrix();
        }
    }

    // métodos
    public void ShowMatrix()
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                Console.Write($"{_matrix[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    public int GetSum()
    {
        int sum = 0;

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                sum += _matrix[i, j];
            }
        }

        return sum;
    }

    public int GetMax()
    {
        int max = _matrix[0, 0];

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                if (_matrix[i, j] > max)
                {
                    max = _matrix[i, j];
                }
            }
        }

        return max;
    }

    public int GetMin()
    {
        int min = _matrix[0, 0];

        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                if (_matrix[i, j] < min)
                {
                    min = _matrix[i, j];
                }
            }
        }

        return min;
    }

    // métodos privados
    private void FillMatrix()
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                _matrix[i, j] = (i + 1) - j;
            }
        }
    }

    private int ValidateN(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException($"El orden de la matriz: {n}, no es válido.");
        }

        return n;
    }
}
