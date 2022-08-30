int[] array = new int[123];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 1000);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(10 <= array[i]&& array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine(count);