using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

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

                
            }
            static int CreateANewNumber(int num7)

            {
               int thirdFromTheEnd = (num7 / 100) % 10;
               int lastDigit = num7 % 10;
               int result2 = thirdFromTheEnd + lastDigit;

                    return result2;
            }

            {
                // 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439
                l8:
                Console.Write("Enter a 9-digit number:");
                int number8 = int.Parse(Console.ReadLine());
               
                if (!(number8 >= 100000000 && number8 <= 999999999))
                {
                    goto l8;
                }
                int step = 1;
                int newNumber8 = 0;

                while (number8 > 0)
                {
                   
                    newNumber8 = step * (number8 % 10) + newNumber8;
                    step*= 10;
                    number8 /= 100;
                    
                }
                Console.WriteLine($"Your new number is:{newNumber8}");

            }

            {
            //10) 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            //sonra cut yerde dayanlarinda bir eded duzlet,
            //sonra onlari topla
            l9:
                Console.Write("Enter a 9-digit number:");
                int number9 = int.Parse(Console.ReadLine());

                if (!(number9 >= 100000000 && number9 <= 999999999))
                {
                    goto l9;
                }
                int step = 1;
                int newOddNumber = 0;
                int newEvenNumber = 0;  

                while (number9 > 0)
                {

                    newOddNumber = step * (number9 % 10) + newOddNumber;
                    newEvenNumber= step * ((number9 % 100)/10) + newEvenNumber;
                    step *= 10;
                    number9 /= 100;
                  
                }
                int finalResult = newEvenNumber + newOddNumber;
               
                Console.WriteLine($"Your new odd number is:{newOddNumber}");
                Console.WriteLine($"Your new even number is:{newEvenNumber}");
                Console.WriteLine($"Your final result is:{finalResult}");


            }

            {
                // 8 reqemli ededin reqemlerini iki -iki qruplashdir.
                //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
                // Sonra cavabin ozunden onun 18 % ni cix;
                l11:
                Console.Write("Enter an 8-digit number:");
                int number11 = int.Parse(Console.ReadLine());
             
                if (number11 >= 10000000 && number11 <= 99999999)
                {
                    /*
                     12345678
                    12,78
                    34,56
                     */
                    
                    int firstPair = (number11 / 1000000) % 100;
                    int secondPair = (number11 / 10000) % 100;
                    int thirdPair = (number11 / 100) % 100;
                    int fourthPair = number11 % 100 ;
                    int sumOfPairs= firstPair + secondPair + thirdPair+fourthPair;

                    Console.WriteLine(firstPair);
                    Console.WriteLine(secondPair);
                    Console.WriteLine(thirdPair);
                    Console.WriteLine(fourthPair);
                    Console.WriteLine($"Your final result is:{sumOfPairs}");

                }
                else
                {
                    goto l11;
                }
           
            }

            {
            //12) 2 dene 5 reqemli eded daxil et.
            //I ededin reqemleri ceminin usutne
            //  II ededin reqemleri hasilini gel.
            // Neticenin axirina I ededin en axiinci reqemini artir.

            l12:
                int firts5Digit;
                firts5Digit = ReadInt("Enter your first 5-digit number:", null);

                if(!(firts5Digit>=10000&&firts5Digit<=99999))
                {
                    goto l12;
                }
              
                l12_2:
                int second5Digit;
                second5Digit = ReadInt("Enter your second 5-digit number:", null);
                int sumRes = FinalResults( firts5Digit, second5Digit);

                if (!(second5Digit >= 10000 && second5Digit <= 99999))
                {
                    goto l12_2;
                }
                else
                {
                    Console.WriteLine($"Your final result is:{sumRes}");
                }
                static int FinalResults(int firts5Digit, int second5Digit)
                {
                    int sum12 = 0;

                    while (firts5Digit > 0)
                    {
                        sum12 += firts5Digit % 10;
                        firts5Digit /= 10;
                        
                    }
                    int product12 = 1;
                    while (second5Digit > 0)
                    {
                        int digit12 = second5Digit % 10;
                        product12 *= digit12;
                        second5Digit /= 10;
                    }
                    int lastDigit = firts5Digit % 10;
                    int sumRes = sum12 + product12 + lastDigit;
                   
                    return sumRes;

                }





            }
            #region Method
            static void Print(string message)
            {
                var backupColor = Console.ForegroundColor;
                var backupBgColor = Console.BackgroundColor;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(message);

                Console.ForegroundColor = backupColor;
                Console.BackgroundColor = backupBgColor;
            }

            static int ReadInt(string caption, string errorMessage)
            {
                var backupColor = Console.ForegroundColor;

            l1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(caption);
                Console.ForegroundColor = backupColor;

                string aStr = Console.ReadLine();

                bool state = int.TryParse(aStr, out int a);

                if (!state)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ForegroundColor = backupColor;
                    goto l1;
                }

                return a;
            }

            static string ReadString(string caption, string errorMessage)
            {
                var backupColor = Console.ForegroundColor;

            l1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(caption);
                Console.ForegroundColor = backupColor;

                string value = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ForegroundColor = backupColor;
                    goto l1;
                }

                return value;
            }

            static double ReadDouble(string caption, string errorMessage)
            {
                var backupColor = Console.ForegroundColor;

            l1:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(caption);
                Console.ForegroundColor = backupColor;

                string aStr = Console.ReadLine();

                bool state = double.TryParse(aStr, out double a);

                if (!state)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ForegroundColor = backupColor;
                    goto l1;
                }

                return a;
            }
           
            #endregion



        } 
           
            
        
    }
}
