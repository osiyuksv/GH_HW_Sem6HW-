// вывести сколько чисел > 0 из M введённых с клавиатуры 
// пользователем чисел (число M задаёт сам пользователь)

Console.WriteLine("Введите число M - скольо раз будут задаваться числа пользователем");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int CountPositiveNum = 0;

for (int i = 0; i < count; i++)
{
  Console.WriteLine("Введите произольное положительное или отрицательное число");
  int num = Convert.ToInt32(Console.ReadLine());
  if(num > 0) CountPositiveNum = CountPositiveNum + 1;
}
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел равно {CountPositiveNum}");
