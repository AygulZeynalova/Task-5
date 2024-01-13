using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                //1) verilmiş 4 reqemli ededin reqemlerinin cemini tap
                Console.Write("Enter a 4-digit number: ");
                int number = int.Parse(Console.ReadLine());


                if (number >= 1000 && number <= 9999)
                {
                    int sum = SumOfDigits(number);
                    Console.WriteLine($"The sum of the digits is: {sum}");
                }
                else
                {
                    Console.WriteLine("Please enter a 4-digit number.");
                }
            }
            static int SumOfDigits(int num)
            {
                int sum = 0;

                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }

                return sum;
            }

            {
                // verilmiş 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600= 1+2+3
                Console.Write("Enter a 6-digit number:");
                int number1 = int.Parse(Console.ReadLine());
                int sum1 = SumOfDigits1(number1);

                if (number1 >= 100000 && number1 <= 999999)
                {
                    Console.WriteLine($"The sum of digits is:{sum1}");
                }
                else
                {
                    Console.WriteLine("Please enter a 6-digit number.");
                }

            }
            static int SumOfDigits1(int num1)
            {
                int sum1 = 0;

                while (num1 > 0)
                {
                    sum1 += num1 % 10;
                    num1 /= 10;
                }
                return sum1;
            }
            {
                //verilmiş 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
                Console.Write("Enter a 9-digit number:");
                int number2 = int.Parse(Console.ReadLine());
                int sum2 = SumOfDigits2(number2);
                if (number2 >= 100000000 && number2 <= 999999999)
                {
                    Console.WriteLine($"The sum of digits is:{sum2}");
                }
                else
                {
                    Console.WriteLine("Please enter a 9-digit number.");
                }
                static int SumOfDigits2(int num2)
                {

                    int sixthDigit = (num2 / 100000) % 10;
                    int fifthDigit = (num2 / 10000) % 10;
                    int fourthDigit = (num2 / 1000) % 10;

                    int sum2 = fourthDigit + fifthDigit + sixthDigit;

                    return sum2;
                }

            }

            {
                //verilmiş 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
                Console.Write("Enter a 5-digit number:");
                int number3 = int.Parse(Console.ReadLine());
                int sum3 = SumOfDigits3(number3);

                if (number3 >= 10000 && number3 <= 99999)
                {
                    int square = sum3 * sum3;

                    Console.WriteLine($"The sum of the first and last digits is: {sum3}");
                    Console.WriteLine($"The square of the sum is: {square}");
                }
                else
                {
                    Console.WriteLine("Please enter a 5-digit number.");
                }
            }

            static int SumOfDigits3(int num3)
            {
                int firstNum = num3 / 10000;
                int lastNum = num3 % 10;
                int sum3 = firstNum + lastNum;

                return sum3;
            }
            //verilmiş 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            Console.Write("Enter a 6-digit number:");
            int number4 = int.Parse(Console.ReadLine());
            int result = FirstDigitToEnd(number4);

            if (number4 >= 100000 && number4 <= 999999)
            {

                Console.WriteLine($"Your new number is:{result}");
            }
            else
            {
                Console.WriteLine("Please enter a 6-digit number.");
            }
            static int FirstDigitToEnd(int num4)
            {
                int firstDigit = num4 / 100000;
                int remainingDigits = num4 % 100000;


                int result = remainingDigits * 10 + firstDigit;

                return result;

            }
            {
                //verilmiş 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
                Console.Write("Enter an 8-digit number:");
                int number5 = int.Parse(Console.ReadLine());
                int result1 = CancelTheFirstAndLastDigits(number5);

                if (number5 >= 10000000 && number5 <= 99999999)
                {
                    Console.WriteLine($"Your new number is: {result1}");
                }
                else
                {
                    Console.WriteLine("Please enter an 8-digit number.");
                }
            }

            static int CancelTheFirstAndLastDigits(int num5)
            {
                int lastNumb = num5 / 10;
                int firstNumb = lastNumb % 10000000;
                return firstNumb;
            }
            {
                //verilmiş 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
                Console.Write("Enter a 4-digit number: ");
                int number6 = int.Parse(Console.ReadLine());


                if (number6 >= 1000 && number6 <= 9999)
                {
                    int reversed = ReversedNumber(number6);
                    Console.WriteLine($"The new number is:{reversed}");
                }
                else
                {
                    Console.WriteLine("Please enter a 4-digit number.");
                }
              
            }
            static int ReversedNumber(int num6)
            {
                int reversed = 0;
                while (num6 > 0)
                {
                    int remainder = num6 % 10;
                    reversed = reversed * 10 + remainder;
                    num6 /= 10;
                }
                reversed = reversed * 10 + 8;
                return reversed;
            }//yeniden bax
            {
                //verilmiş ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap
                //ədəd verilməyib.5 rəqəmli ədəd ilə yazdım.
                Console.Write("Enter a 5-digit number:");
                int number7 = int.Parse(Console.ReadLine());
                if (number7 >= 10000 && number7 <= 99999)
                {
                    int result2 = CreateANewNumber(number7);
                    Console.WriteLine($"Your result is:{result2}");
                }
                else
                {
                    Console.WriteLine("Please enter a 5-digit number.");
                }
                static int CreateANewNumber(int num7)

                {
                    int thirdFromTheEnd = (num7 / 100) % 10;
                    int lastDigit = num7 % 10;
                    int result2 = thirdFromTheEnd + lastDigit;

                    return result2;
                }

            }
           
            
        }
    }
}
