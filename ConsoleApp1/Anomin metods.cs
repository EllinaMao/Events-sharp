using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnononimMetods
{
    public class Anononim
    {        /*Задание 1
        Создайте анонимный метод для получения RGB значения для цвета радуги. Цвет радуги передаётся в качестве
        параметра. Напишите код для тестирования работы метода.
        */
        public Func<string, string> colorHandler = delegate (string x)
        {
            switch (x.ToLower())
            {
                case "red" or "красный":
                    {
                        return "255,0,0";
                    }
                case "orange" or "оранджевый":
                    {
                        return "255,165,0";
                    }
                case "yellow" or "желтый":
                    {
                        return "255,255,0";
                    }
                case "green" or "зеленый":
                    {
                        return "0,128,0";
                    }
                case "deep sky blue" or "голубой":
                    {
                        return "0,191,255";
                    }
                case "blue" or "синий":
                    {
                        return "0,0,255";
                    }
                case "purple" or "фиолетовый":
                    {
                        return "128,0,128";
                    }
                default:
                    {
                        throw new Exception("Данный цвет не распознан");
                    }
            }

        };

        /*
        Задание 3
        Создайте лямбда-выражение для подсчёта количества чисел в массиве, кратных семи. Напишите код для
        тестирования работы лямбды.

        Задание 4
        Создайте лямбда-выражение для подсчёта количества положительных чисел в массиве. Напишите код для
        тестирования работы лямбды.
        */

        public Func<List<int>, Func<int, bool>, int> CountNumbers = delegate (List<int> numbers, Func<int, bool> predicate)
        {
            int count = 0;
            count = numbers.Count(predicate);
            return count;
        };

        public Func<int, bool> Divisible(int divisible)
        {
            return number => number % divisible == 0;
        }




        /*
        Задание 5
        Создайте лямбда-выражение для отображения уникальных отрицательных чисел в массиве. Напишите код
        для тестирования работы лямбды.
        
        тоже анонимный, но в форме лямбды*/
        public Func<List<int>, List<int>> GetNewList = numbers =>
        {
            return numbers.Where(num => num < 0).Distinct().ToList();
        };




        /*
        Задание 6
        Создайте лямбда-выражение для проверки есть ли в
        тексте заданное слово. Напишите код для тестирования
        работы лямбды.*/

        public Func<string, string, bool> IsWord = delegate (string? txt, string? findW)
        {

            if (string.IsNullOrEmpty(findW))
            { 
                return false;
            }
            bool match = Regex.IsMatch(txt, findW, RegexOptions.IgnoreCase);
            return match;
        };










    }
}
