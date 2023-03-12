// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3. 
// Первоначально массив можно ввести с клавиатуры либо задать на старте выполнение алгоритма.
string[] A;
Console.WriteLine("Введите массив строк/через пробел");
 string stroka = Console.ReadLine();
 A = stroka.Split(' ');
var result = new string[A.Length];
 var realSize = 0;
 foreach (var value in A )
 {
 if (value.Length <= 3)
 {
  result[realSize] = value;
    realSize++;
  }

