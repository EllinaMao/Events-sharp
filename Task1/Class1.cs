using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate void Del(string x);
    internal class Class1
    {        /*Задание 1
        Создайте анонимный метод для получения RGB значения для цвета радуги. Цвет радуги передаётся в качестве
        параметра. Напишите код для тестирования работы метода.
        */
        //public Func<string> GetRGB = delegate (string color)

        public static Func<string> RGBColor()
        {
            Func<string> color = delegate (string x)
            {
                switch (x.ToLower())
                {
                    case "red":
                        {
                            return "255,0,0";
                        }
                    case "orange":
                        {
                            return "255,165,0";
                        }
                    case "yellow":
                        {
                            return "255,255,0";
                        }
                    case "green":
                        {
                            return "0,128,0";
                        }
                    case "deep sky blue":
                        {
                            return "0,191,255";
                        }
                    case "blue":
                        {
                            return "0,0,255";
                        }
                    case "purple":
                        {
                            return "128,0,128";
                        }
                };
                return string.Empty;

            };
            return color;
        }
        /*            {switch (color.ToLower())
                {
                    case "red"|| "красный":
                        {
                            return "255,0,0";
                        }
                    case "orange" || "оранжевый":
                        {
                            return "255,165,0";
                        }
                    case "yellow":
                        {
                            return "255,255,0";
                        }
                    case "green":
                        {
                            return "0,128,0";
                        }
                    case "deep sky blue":
                        {
                            return "0,191,255";
                        }
                    case "blue":
                        {
                            return "0,0,255";
                        }
                    case "purple":
                        {
                            return "128,0,128";
                        }*/
    } }
