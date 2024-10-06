// Ədədlərdən ibarət arrayda neçə rəqəm olduğunu ekrana çap edin (Məs: {1,77,6,14} arrayında 2 rəqəm var )

int[] arr = { 1, 77, 6, 14,4,5,2 };

int counter = 0;

for (int i =0; i < arr.Length; i++)
{
    if (arr[i] >= 0 && arr[i]<= 9)
    {
        counter++;
    }
}
Console.WriteLine(counter);
