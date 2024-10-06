// Matrixin baş diaqonalından yuxarıda olan ədədlərin cəmindən aşağ ıda olan ədədlərin cəminin fərqi.

int[,] matrix =
{
    {1,2,3,4 },
    {5,6,7,8},
    {9,0,1,2 },
    {3,4,5,6 }
};

int firstSum = 0;
int secondSum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i < j)
        {
            firstSum += matrix[i, j];
        }
        else if (i > j)
        {
            secondSum += matrix[i, j];
        }
    }
}
int result = firstSum - secondSum;
Console.WriteLine(result);

