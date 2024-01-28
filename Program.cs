// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

int M = 8;
int N = 15;
{
            Console.WriteLine(GetNuturalNumber(M , N));
}
        string GetNuturalNumber(int start,int end)
         {
            string result = " ";
            if(end < start) return result;
            if(start == 0) 
            {
                result = GetNuturalNumber(start + 1, end);
            } else
             {
                result = start + GetNuturalNumber(start + 1, end);
            }
            return result;
        }





//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.




//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
