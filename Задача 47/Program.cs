// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

var res = Result(3 , 4);

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine($"{res[i, 0]} {res[i, 1]} {res[i, 2]} {res[i, 3]}");
}

double[,] Result(int m, int n)
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