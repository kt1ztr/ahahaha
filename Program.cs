Console.Clear();
    Console.Write("Укажите количество элементов массива ");
    int len = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[len];
    FillArray(array);
    Console.Write("Введенный массив -------> ");
    PtintArray(array);
    Console.Write("Обработанный массив, состоящий из элементов <|= трем символам --> ");
    PtintArray(Array3symb(array));         
void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение ({i+1} элемента)..");
        array[i] = Console.ReadLine();
    }
}
   void PtintArray(string[] array)
{
    int i = 0;
    for (i = 0; i < array.Length-1; i++)  
    {
        Console.Write(array[i] + " / ");
    }
    Console.WriteLine(array[i]);
}

string[] Array3symb(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)  
    {
        if (array[i].Length < 4)
        {
            array[count] = array[i];
            count++;
        }
    }
    string[] array_res = new string[count];
    for (int j = 0; j < count; j++) 
    {
        array_res[j] = array[j];
    }
    return array_res;
}