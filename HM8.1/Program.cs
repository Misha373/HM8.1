Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Завдання 1:");
int[] array = new int [10];

Random random = new Random ();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 10);
}

for (int i = 0;i < array.Length; i++)
{
    if (i%2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.WriteLine();
Console.WriteLine("Завдання 2:");
int sum = 0;
for (int i = 0;i<array.Length; i++)
{
    sum = sum + array[i];
}
if(sum >= 0)
{
    Console.WriteLine($"Сумма чисел масиву array, є невідємним числом, і сума = {sum}");
}
else
{
    Console.WriteLine($"Сумма чисел масиву array, є відємним числом, і сума = {sum}");
}
Console.WriteLine("Завдання 3:");
int[,] array3 = new int[9, 9];
for (int i = 1;i<= array3.GetLength(0); i++)
{
    Console.Write("|");
for(int j = 1;j<= array3.GetLength(1); j++)
    {
        Console.Write($"{i*j} ");
    }
    Console.Write("|");
    Console.WriteLine();
}
Console.WriteLine("Завдання 4:");
int[,] array4 = new int[5, 5];

for (int i = 0; i < array4.GetLength(0); i++)
{
    for(int j = 0; j< array4.GetLength(1); j++)
    {
        array4[i,j] = random.Next(-20, 20);
    }
    
}
int MaximumNumber = array4[0,0];
int Maximumcoordinates1 = 0;
int Maximumcoordinates2 = 0;
int MinimumNumber = array4[0, 0];
int Minimumcoordinates1 = 0;
int Minimumcoordinates2 = 0;

for (int i = 0; i < array4.GetLength(0); i++)
{
    for (int j = 0; j < array4.GetLength(1); j++)
    {
        if (MaximumNumber < array4[i, j])
        {
            MaximumNumber = array4[i, j];
            Maximumcoordinates1 = i;
            Maximumcoordinates2 = j;

        }
        if (MinimumNumber > array4[i, j])
        {
            MinimumNumber = array4[i, j];
            Minimumcoordinates1 = i;
            Minimumcoordinates2 = j;
        }
    }
}
Console.WriteLine($"Найбільше число є: {MaximumNumber}, з координатами: {Maximumcoordinates1}, {Maximumcoordinates1}");
Console.WriteLine($"Найменше число є: {MinimumNumber}, з координатами: {Minimumcoordinates1}, {Minimumcoordinates2}");