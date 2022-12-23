// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7) {
    Console.WriteLine("Вы ошиблись. Введите цифру, обозначающую день недели (от 1 до 7)");
    a = Convert.ToInt32(Console.ReadLine());
}
 if (a==1) Console.WriteLine("нет, это не выходной");
 if (a==2) Console.WriteLine("нет, это не выходной");
 if (a==3) Console.WriteLine("нет, это не выходной");
 if (a==4) Console.WriteLine("нет, это не выходной");
 if (a==5) Console.WriteLine("нет, это не выходной");
 if (a==6) Console.WriteLine("да, это выходной");
 if (a==7) Console.WriteLine("да, это выходной");