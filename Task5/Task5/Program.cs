using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

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
        step *= 10;
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
        newEvenNumber = step * ((number9 % 100) / 10) + newEvenNumber;
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
        int fourthPair = number11 % 100;
        int sumOfPairs = firstPair + secondPair + thirdPair + fourthPair;

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
    Console.Write("Enter your first 5-digit number:");
    int firts5Digit = int.Parse(Console.ReadLine());

    if (!(firts5Digit >= 10000 && firts5Digit <= 99999))
    {
        goto l12;
    }

l12_2:
    Console.Write("Enter your second 5-digit number:");
    int second5Digit = int.Parse(Console.ReadLine());

    int lastDigitOfFirst = firts5Digit % 10;

    int sumRes = FinalResults(firts5Digit, second5Digit, lastDigitOfFirst);

    if (!(second5Digit >= 10000 && second5Digit <= 99999))
    {
        goto l12_2;
    }
    else
    {
        Console.WriteLine($"Your final result is:{sumRes}");
    }
    static int FinalResults(int firts5Digit, int second5Digit, int lastDigitOfFirst)
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

        int sumRes = (sum12 + product12) * 10 + lastDigitOfFirst;

        return sumRes;

    }

}
{
    //13) 3 dene 5 reqemli eded var.
    //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
    // Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.
    Console.WriteLine("############");
l13:
    Console.Write("Enter your first 5-digit number:");
    int firstDigit5 = int.Parse(Console.ReadLine());



    if (!(firstDigit5 >= 10000 && firstDigit5 <= 99999))
    {
        goto l13;
    }
l13_2:
    Console.Write("Enter your second 5-digit number:");
    int secondDigit5 = int.Parse(Console.ReadLine());

    if (!(secondDigit5 >= 10000 && secondDigit5 <= 99999))
    {
        goto l13_2;
    }

l13_3:
    Console.Write("Enter your third 5-digit number:");
    int thirdDigit5 = int.Parse(Console.ReadLine());
    int finalResult = Three5Digits(firstDigit5, secondDigit5, thirdDigit5);

    if (!(thirdDigit5 >= 10000 && thirdDigit5 <= 99999))
    {
        goto l13_3;
    }
    else
    {
        Console.WriteLine($"Your final result is:{finalResult}");
    }


    static int Three5Digits(int firstDigit5, int secondDigit5, int thirdDigit5)
    {
        int sum13 = GetFirstAndLastDigitSum(firstDigit5) + GetFirstAndLastDigitSum(secondDigit5) + GetFirstAndLastDigitSum(thirdDigit5);
        int finalResult = sum13 / 2;
        return finalResult + sum13;

    }

    static int GetFirstAndLastDigitSum(int num13)
    {
        int lastDigit = num13 % 10;
        int firstDigit;
        while (num13 >= 10)
        {
            num13 /= 10;
        }
        firstDigit = num13;

        return firstDigit * 10 + lastDigit;

    }

    {
    /*
     14) 4 dene eded daxil et. 
    Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
Neticenin 60 % tap.
Cavabin axirina 60 artir.
Neticeden 18% cix.
    */
    l14:
        Console.Write("Enter your first 6-digit number:");
        int first6Digit = int.Parse(Console.ReadLine());

        

        if (!(first6Digit >= 100000 && first6Digit <= 999999))
        {
            Console.WriteLine("Please enter a 6-digit number.");
            goto l14;
        }
    l_14:
        Console.Write("Enter your second 6-digit number:");
        int second6Digit = int.Parse(Console.ReadLine());

        if (!(second6Digit >= 100000 && second6Digit <= 999999))
        {
            Console.WriteLine("Please enter a 6-digit number.");
            goto l_14;
        }
    l__14:
        Console.Write("Enter your third 6-digit number:");
        int third6Digit = int.Parse(Console.ReadLine());

        if (!(third6Digit >= 100000 && third6Digit <= 999999))
        {
            Console.WriteLine("Please enter a 6-digit number.");
            goto l__14;
        }
    l___14:
        Console.Write("Enter your fourth 7-digit number:");
        int fourth7Digit = int.Parse(Console.ReadLine());

        if (!(fourth7Digit >= 1000000 && fourth7Digit <= 9999999))
        {
            Console.WriteLine("Please enter a 7-digit number.");
            goto l___14;
        }
        int finalSum14 = NewNumbersSum(first6Digit, second6Digit, third6Digit,fourth7Digit);

        Console.WriteLine($"Your final result is:{finalSum14}");



        static int NewNumbersSum(int first6Digit, int second6Digit, int third6Digit,int fourth7Digit)
        {
            int sum14 = CountFirst3Numbers(first6Digit) + CountFirst3Numbers(second6Digit) + CountFirst3Numbers(third6Digit);
            int sevenDigitNum = Last4DigitsOf7(fourth7Digit);
            int sumsOfNum = sum14 + sevenDigitNum;
            int sumAndProduct = sumsOfNum - First3NumbersOf7(fourth7Digit);

            int find60Percent = (sumAndProduct * 60) / 100;

            int add60ToTheEnd = find60Percent * 10 + 60;

            int finalEnd = add60ToTheEnd - (add60ToTheEnd * 18) / 100;

            return finalEnd;

        }

        static int CountFirst3Numbers(int num14)
        {
            int firstDigitOf6 = num14 / 100000;
            int secondDigitOf6 = (num14 / 10000) % 10;
            int thirdDigitOf6 = (num14 / 1000) % 10;

            return (firstDigitOf6 * 100) + (secondDigitOf6 * 10) + thirdDigitOf6;

        }
        static int Last4DigitsOf7(int seventhNum)
        {
            //1234567
            int fourthtDigitOf7 = (seventhNum / 1000) % 10;
            int fifthtDigitOf7 = (seventhNum / 10000) % 10;
            int sixthtDigitOf7 = (seventhNum / 100000) % 10;
            int seventhDigitOf7 = (seventhNum / 1000000) % 10;
            
            return (fourthtDigitOf7*1000)+(fifthtDigitOf7*100)+(sixthtDigitOf7*10)+seventhDigitOf7;

        }
        static int First3NumbersOf7(int seventhNum)
        {
            int firstDigitOf7=seventhNum % 10;
            int secondDigitOf7=(seventhNum/100) % 10;
            int thirdDigitof7 = (seventhNum / 1000) % 10;

            return firstDigitOf7 * secondDigitOf7 * thirdDigitof7;
        }


    }

    {
        /*
         5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 
        2 denesi 6 reqemli . 
        1 denesi 7 reqemli olsun.
     3 reqemli ededlerin cemini tap 
        cavabin axirdan 2 denesini kvadratini tap.
     Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
     Cavabdan 7 reqemli ededin son 5 reqemini cix.
     Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
     Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
     Cavabin axirina 11 artir.
     Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
     Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.\
        
         */


    }

}



