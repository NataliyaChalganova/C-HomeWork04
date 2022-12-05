// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


//Я так и не поняла применение здесь безымянного цикла, который идет с 4 строки. Именно как и откуда просто цикл после "int SumNumber(int numberN)" и как оно работает.
//Подсказал интернет, но понять я не смогла. Иначе ну никак у меня. Математический цикл понятен.


Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
