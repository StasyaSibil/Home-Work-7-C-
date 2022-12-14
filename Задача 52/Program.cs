// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

var arr = CreateArray(3,4);
var res = "Среднее арифметическое каждого столбца:";

for (int i = 0; i < arr.GetLength(0); i++)
{
    double sum = 0;
    var count = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i,j];
        count = count + 1;
    }

    res = res + $" {sum/count};";
}

Console.WriteLine(res);

double[,] CreateArray(int m, int n)
{
    var res = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        var line = Line(n);
        for (int x = 0; x < line.Length; x++)
        {
            res[i, x] = line[x];
        }
    }

    return res;
}

double[] Line(int count)
{
    var res = new double[count];
    for (int i = 0; i < count; i++)
    {
        res[i] = new Random().NextDouble() * 100;
    }

    return res;
}
