using System.Security.Cryptography.X509Certificates;
using AnononimMetods;
namespace Task1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var anon = new Anononim();

            string[] colors = { "красный", "orange", "желтый", "green", "deep sky blue", "синий", "purple", "unknown" };

            foreach (var color in colors)
            {
                try
                {
                    string rgb = anon.colorHandler(color);
                    Console.WriteLine($"{color}: {rgb}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{color}: {ex.Message}");
                }
            }

            Console.WriteLine("Нажмите любую кнопку дя выхода");
            Console.ReadKey();
        }
    }

    }
