// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int CubeTheNumber (int number)
{  
    int result =0;
    int coef = 3;
   for (int i = 1; i <= number; i++)
   {
        result = Convert.ToInt32(Math.Pow(i,coef));
        Console.Write($"{result}, ");
   }
   return result;
}
Console.WriteLine("Enter your number: ");
int user_number = Convert.ToInt32(Console.ReadLine());
CubeTheNumber (user_number);


 