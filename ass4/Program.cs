﻿namespace ass4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("enter number ro check divide on 3 or 4 : ");
            //  int number =int.Parse(Console.ReadLine());
            //    if (number % 3 == 0 && number % 4 == 0) 
            //          Console.WriteLine("yes");
            //    else
            //          Console.WriteLine("no");
            #endregion
            #region Q2
            //Console.WriteLine("enter number to check positive or negative : ");
            //int number = int.Parse(Console.ReadLine());
            //if (number < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("positive");
            #endregion
            #region Q3
            //Console.WriteLine("enter num 1 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter num 2 : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter num 3 : ");
            //int num3 = int.Parse(Console.ReadLine());
            //int max;
            //int min;
            //if (num1 > num2 && num1 > num3)
            //{
            //    max = num1;
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    max = num2;
            //}
            //else { max = num3; }
            //Console.WriteLine($"max element = {max}");
            //if (num1 < num2 && num1 < num3)
            //{
            //    min = num1;
            //}
            //else if (num2 < num1 && num2 < num3)
            //{
            //    min = num2;
            //}
            //else { min = num3; }
            //Console.WriteLine($"max element = {min}");
            #endregion
            #region Q4
            //Console.WriteLine("enter number to check Even or Odd : ");
            //int number = int.Parse(Console.ReadLine());
            //if (number%2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("odd");
            #endregion
            #region Q5
            //Console.WriteLine("enter Character : ");
            //bool isparsed = char.TryParse(Console.ReadLine(), out char character);
            //character = char.ToLower(character);
            //if ((character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')&& isparsed == true)
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else if(isparsed ==true )
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion
            #region Q6
            //Console.WriteLine("enter num to get range");
            //    int num =int.Parse(Console.ReadLine());
            //for (int i = 1; num >= i; i++) {
            //    Console.Write(i);
            //    if(i != num)
            //        Console.Write(",");
            //}
            #endregion
            #region Q7
            //Console.WriteLine("enter num to get multipication");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; 12 >= i; i++)
            //{
            //    Console.Write(i * num);
            //    if (i !=12)
            //        Console.Write(" ");
            //}
            #endregion
            #region Q8
            //Console.WriteLine("enter num to get even within range");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; num >= i; i++)
            //{

            //    if (i%2 == 0)
            //        Console.Write(i);
            //    if(i !=num)
            //        Console.Write(" ");
            //}
            #endregion
            #region Q9
            //Console.WriteLine("enter num 1 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter num 2 power : ");
            //int power = int.Parse(Console.ReadLine());
            //int a =1;
            //for (int i = 1; i <= power; i++) 
            //{
            //   a *= num1;

            //}
            //Console.WriteLine(a);
            #endregion
            #region Q10
            //double[] marks = new double[5];
            //double total = 0;
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Enter mark {i+1}");
            //    marks[i] = int.Parse(Console.ReadLine());
            //    total += marks[i];
            //}

            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;
            //Console.WriteLine($"total = {total}");
            //Console.WriteLine($"average = {average}");
            //Console.WriteLine($"percentage = {percentage}");


            #endregion
            #region Q11
            //Console.WriteLine("enter month number to get number of day");
            //int num = int.Parse(Console.ReadLine());
            //int message = num switch
            //{
            //    2 => 28,
            //    4 | 6 | 9 => 30,
            //    _ => 31
            //};
            //Console.WriteLine(message);
            #endregion
            #region Q12
            //Console.WriteLine("enter num 1 : ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter num 2  : ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter operator : ");
            //char oper =char.Parse(Console.ReadLine());
            //double message = oper switch
            //{
            //    '+' =>num1+num2,
            //    '-' =>num1-num2,
            //    '*' =>num1*num2,
            //    '/' =>num1/num2,


            //};
            //Console.WriteLine(message);
            #endregion
            #region Q13
            //Console.WriteLine("enter ypur string to reverse it");
            //string text =Console.ReadLine();
            //string reverse ="";
            //int l = text.Length;
            //for (int i = 0; i < l; i++) { 
            //    reverse += text[l-i-1];

            //}
            //Console.WriteLine(reverse);
            #endregion
            #region Q14
            //Console.WriteLine("Enter integer num to get reverse");
            //int num =int.Parse(Console.ReadLine());
            //int reverse=0;

            //while (num != 0)
            //{
            //    int reminder = num % 10;
            //    reverse = (reverse * 10) + reminder;
            //    num = num / 10;
            //}
            //Console.WriteLine(reverse);
            #endregion
            #region Q15
            // Console.WriteLine("enter start range");
            // int num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("enter end range");
            // int num2 = int.Parse(Console.ReadLine());
            // for (int i = num1; i <= num2; ++i)
            // {
            //     bool prime = true;
            //     if (i <= 1)
            //         prime = false;
            //     for (int j = 2; j < i; ++j)
            //     {
            //         if (i % j == 0)
            //         {
            //             prime = false;
            //             break;
            //         }
            //     }
            //     if (prime)
            //         Console.Write(i+" ");

            //}
            #endregion
            #region Q16
            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());
            //string binarynum = "";
            //if (number == 0)
            //{
            //    binarynum = "0";
            //}
            //else
            //{
            //    while (number > 0)
            //    {
            //        int reminder = number % 2;
            //        binarynum = reminder + binarynum;
            //        number /= 2;
            //    }
            //    Console.WriteLine(binarynum);
            //}
            #endregion
            #region Q17
            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());


            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do NOT lie on a straight line.");
            //}
            #endregion
            #region Q18
            //Console.WriteLine("enter duration to complete task");
            //double duration = double.Parse(Console.ReadLine());
            //if (duration > 2 && duration < 3)
            //{
            //    Console.WriteLine("they are considered highly efficient");
            //}
            //else if (duration > 3 && duration < 4)
            //{
            //    Console.WriteLine("they are instructed to increase their speed");
            //}
            //else if (duration > 4 && duration < 5)
            //{
            //    Console.WriteLine("You need to leave the company");
            //}
            //else if (duration >= 5)
            //{
            //    Console.WriteLine("You need to leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Time should be at least 2 hours.");
            //}
            #endregion
            #region Q19
            //Console.WriteLine("enter size arry");
            //int n = int.Parse(Console.ReadLine());
            //int[,] identical = new int[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    identical[i, i] = 1;

            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(identical[i, j]);


            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Q20
            //int[] arr = {2,4,5,6,8 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];

            //}
            //Console.WriteLine(sum);
            #endregion
            #region Q21
            //int[] arr1 = { 2, 4, 5, 6, 8 };
            //int [] arr2 = {2,4,5,6,9};
            //int[] merge = new int[arr1.Length + arr2.Length];
            //for (int i = 0; i < arr1.Length; i++) { 
            //merge[i]=arr1[i];
            //}
            //for (int i = 0; i < arr2.Length; i++) { 
            //merge[arr1.Length+i]=arr1[i];
            //}
            //Array.Sort(merge);
            //Console.WriteLine("merged arry");
            //for(int i = 0; i < merge.Length; i++) {
            //   Console.Write(merge[i]+" ");
            //}
            #endregion
            #region Q22
            //int[] arr = { 1,1, 2,2, 3,3, 5, 4, 5, 6, 9 };
            //int []frequency=new int[arr.Length];    
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int k = 1;
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            k++;
            //    }
            //    frequency[i] = k;
            //    Console.WriteLine($"{arr[i]} repeted = {frequency[i]}");

            //}



            #endregion
            #region Q23
            //int[] arr = { 1, 23, 5, 6, 4, 8, 9 };
            //int max = arr[0];
            //int min = arr[1];
            //for (int i = 0; i < arr.Length; i++)
            //{ 
            //    if(arr[i] > max)
            //        max = arr[i];
            //    if(arr[i] < min)
            //        min = arr[i];
            //}
            //Console.WriteLine("max ="+max);
            //Console.WriteLine("min ="+min);
            #endregion  

        }
    }
} 