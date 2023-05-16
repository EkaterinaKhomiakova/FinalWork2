﻿using System;
using System.Linq;

namespace FinalTest
{
    class Program
    {
        static void Main()
        {
            PrintCaption();
            string[] input = GetArray();
            string[] output = GetArrayOfSpecificStrings(input);
            PrintResult(input, output);
        }
        static void PrintCaption()
        {
            Console.WriteLine("Формирование из заданного строкового массива \n" +
                              "нового массива, содержащего только строки исходного \n" +
                              "массива длиной 3 и менее символа.\n");
        }
        static string[] GetDefaultArray()
        {
            return new string[] {"Li", "Stgotr", "5R", "Licr43", "$#@"};
        }
        static string[] GetArray()
        {
            Console.WriteLine("Введите одной строкой группы символов.\n" +
                              "Разделите группы пробелами. " +
                              "В противном \nслучае будет использован " +
                              "массив по умолчанию.\n");
            string? input = Console.ReadLine();
            if(input != null && input != string.Empty)
            {
                string[] result = input
                                 .Split(" ")
                                 .Select(x => x)
                                 .ToArray();
                return result;
            }
            else
                return GetDefaultArray();
        }
        static string[] GetArrayOfSpecificStrings(string[] input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].Length < 4)
                    counter++;
            }

            int j = 0;
            string[] result = new string[counter];
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i].Length < 4)
                {
                    result[j] = input[i];
                    j++;
                }
            }
            return result;
        }
        static void PrintResult(string[] input, string[] output)
        {
            Console.WriteLine($"\n[{string.Join(", ",input)}] -> [{string.Join(", ", output)}]\n");
        }
    }
}