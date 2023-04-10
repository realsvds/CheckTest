// See https://aka.ms/new-console-template for more information
//Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

//1. Создать репозиторий на GitHub
//2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
//3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
//4. Написать программу, решающую поставленную задачу
//5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)


string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);