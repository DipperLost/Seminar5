int[] array = new int[10];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 10000);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 > 0)
    {
        count = count + array[i];
        count++;
    }
}
Console.WriteLine("сумма элементов, стоящих на нечётных позициях"
 + " " + count);