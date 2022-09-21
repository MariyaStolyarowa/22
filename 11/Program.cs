//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
int A;
Console.Clear();
Console.Write("Введите число: ");
A=Convert.ToInt32(Console.ReadLine());
if (A<100)
{Console.Write("Третьей цифры нет"); 
}
else if (A>=100 && A<1000)
{Console.Write(A%10);}
else if (A>=1000)
{{while (A>=1000)
{A=A/10;}}
Console.Write(A%10);}