// Двумерные массивы и рекурсия

string[,] table = new string[2, 5]; // задан двумерный массив - 2 строки, 5 столбцов
table[1, 2] = "слово"; // обращение к элементу находящемуся в первой строке второго столбца
// String.Empty - инициализация строки

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}-");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Создение матрицы заполненной случайными числами

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10); // [1, 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();


// рекурсия, метод для вычисления факториала

// double Factorial (int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return (n * Factorial(n-1));
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }
  
// рекурсия, последовательность Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fib(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fib (n - 1) + Fib (n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fib(i)}");
}