
try
{
    Console.Write("Input x: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Input n: ");
    int n = int.Parse(Console.ReadLine());
    int k = 1;
    int F = 1;
    double P = 1;
    for(int i = 1; i <= k ; i++ )
    {
        F = F * i;
        Console.WriteLine();
    }
    Console.WriteLine($"Factorial of {k} is {F}");
    for (int i = 1;i <= n ; i++)
    {
        if (x != -3) 
        {
            P *= Math.Pow(-1,k) * Math.Pow((x + 3),2)/F;
        }
        Console.WriteLine($"Q = {P}");
    }
}
catch
{
    Console.WriteLine("Erorr");
}