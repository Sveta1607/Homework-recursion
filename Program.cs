// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
/*
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
*/
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*
        {
        Console.WriteLine(Akkerman(3, 5));
        }

        int Akkerman(int n, int m) 
        {
            if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
            if (n == 0) return m + 1;
            if (m == 0) return Akkerman(n - 1, m);
            return Akkerman(n - 1, Akkerman(n, m - 1));
        }

*/


//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


char[] charArray = "Hello, World!!!".ToCharArray();
        {
        Console.WriteLine(GetReversArray(charArray.Length-1, charArray));
        }

        string GetReversArray(int index, char[] array)
         {
            if(index < 0) return "";
            return array[index] + GetReversArray(--index, array);
        }
    
   