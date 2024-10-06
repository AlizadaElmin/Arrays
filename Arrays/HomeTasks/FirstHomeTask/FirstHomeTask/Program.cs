//İki ədəd verilir. Birinci ədədin ikinci ədəd qüvvətini hesablayan alqoritmin diaqramını qurun.
//(məsələn: k və g verilir kᵍ print olunmalıdır.) (loop ilə həll olunmalıdır.)


int k = 5;
int g = 2;
double result = 1;

if (g == 0) {
    result = 1;
}

else if (g > 0)
{
    for (int i = 0; i < g; i++)
    {
        result *= k;
    }
}

else
{
    g *= -1;
    for (int i = 0; i < g; i++)
    {
        result *= k;
        
    }
    result = 1 / result;
}


Console.WriteLine(result);
