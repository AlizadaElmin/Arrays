//Verilmiş ədədin neçə mərtəbəli olduğunu print edən alqoritmin diaqramını qurun.
//(məsələn: 321 ədədi 3 mərtəbəlidir, 23125 ədədi 5 mərtəbəlidir.)

int number = 3243;
int counter = 0;

while(number > 0)
{
    number /= 10;
    counter += 1;
}
Console.WriteLine(counter);
