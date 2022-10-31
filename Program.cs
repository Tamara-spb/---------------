// Написать программу, которая из массива массива строк формирует массив из строк, 
// длина которых меньше равно 3 символов. Первоначальный массив можно ввести с помощью комбинации, 
// либо нажать на начало выполнения алгоритма.

string[] array1 = new string[] {"123", "Russia", "hello", "[-2", "world", "computer science"};
string[] array2 = new string[array1.Length];
void countGetStringsWithThreeOrLessCharacters(string[] array1, string[] array2)
{
    int countGetStringsWithThreeOrLessCharacters = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[countGetStringsWithThreeOrLessCharacters] = array1[i];
        countGetStringsWithThreeOrLessCharacters++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array2[i]} \t");
    }
    
}

countGetStringsWithThreeOrLessCharacters(array1, array2);
PrintArray(array2);

