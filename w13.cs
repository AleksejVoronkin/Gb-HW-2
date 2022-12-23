//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.(можно использовать индексацию строк)
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

      
Console.WriteLine("Введите число!");
    int a = Convert.ToInt32(Console.ReadLine());
if (a > 100)
{
    string str = a.ToString();
Console.Write("третья цифра этого числа = ");
Console.WriteLine(str[2]);
        }
else {Console.WriteLine("третьей цифры нет");
}