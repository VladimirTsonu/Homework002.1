// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom (int number)
{
     int firstNumber = number / 10000;
     int secondNumber = number / 1000 - firstNumber * 10;
     int thirdNumber = (number % 100) / 10;
     int fourNumber = number % 10;
     Console.WriteLine(firstNumber);
     Console.WriteLine(secondNumber);
     Console.WriteLine(thirdNumber);
     Console.WriteLine(fourNumber);
     if (firstNumber == fourNumber &&  secondNumber == thirdNumber )
     {
        Console.WriteLine($"Your number {number} is palindrome ");
     }
        else
        {
            Console.WriteLine($"Your number {number} is not palindrome");
        }
}

   Console.WriteLine("Enter your number: ");
   int user_number = Convert.ToInt32(Console.ReadLine());

   if (user_number > 9999 && user_number < 100000)
       Palindrom(user_number);
   else
      Console.WriteLine("Your number is not 5 digit");  