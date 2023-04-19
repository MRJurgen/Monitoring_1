
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());
string [] a = new string [n];
int count =0;
for (int i = 0; i < n; i++)
{
    Console.Write($"a[{i}] = ");
    a[i] = Console.ReadLine();
    if (a[i].Length <=3)
    {
        count++;
    }
}
string [] b = new string [count];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < count; j++)
    {
        if (a[i].Length <=3)
        {
            b[j]=a[i];
            i++;
        }
        
    }
}
foreach (var item in b)
{
    Console.Write(item+" ");
}
