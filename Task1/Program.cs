using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var colorGetter = RGBColor();
            Console.WriteLine(colorGetter("red"));
            Console.WriteLine(colorGetter("green"));
        }
            public static Func<string, string> RGBColor()
        {
            Func<string, string> colorHandler = delegate (string x)
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
                    default:
                        {
                            throw new Exception("Данный цвет не распознан");
                        }
                }

            };
            return colorHandler;
        }

    }

    }
