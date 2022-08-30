double[] array = new double[5];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элемент массива: ");
double number = Convert.ToDouble(Console.ReadLine());
    array[i] = number;
}
Console.WriteLine('[' + string.Join("; ", array) + ']');
double Max = array[0];
for(int i = 1; i < array.Length; i++)
{
    if(array[i] > Max);
        array[i] = Max;
}
Console.WriteLine("максимальный элемент массива"
 + " " + Max);
double Min = array[0];
for(int i = 1; i < array.Length; i++)
{
    if(array[i] < Min);
        Min = array[i];
}
Console.WriteLine("минимальный элемент массива"
 + " " + Min);
double result = Max - Min;
Console.WriteLine("разница между максимальным и минимальным элементов массива"
 + " " + result);