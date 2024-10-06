// 4x4 ölçülü matrixin elementlərinin cəmini tapın.
int[,] matrix =
{
    {1,2,3,4 },
    {5,6,7,8},
    {9,0,1,2 },
    {3,4,5,6 }
};

int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
}
Console.WriteLine(sum);
