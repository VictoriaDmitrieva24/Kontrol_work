// Написать программу, которая из имеющегося массива строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

char[] delimiterChars = { ',', '.', ':', '"', ' ' };
string text = "hello, 2, world, ^-)";
string[] words = text.Split(delimiterChars);

for (int i = 0; i < words.Length; i++)
{
string result = string.Empty;
if (words[i].Length <= 3) 
{
    result = result + words[i];
    Console.Write(result + " ");
}
}
