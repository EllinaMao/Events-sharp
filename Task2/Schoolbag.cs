using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Задание 2
Создайте класс рюкзак. Характеристики рюкзака:
■ Цвет рюкзака;
■ Фирма производитель;
■ Ткань рюкзака;
■ Вес рюкзака;
■ Объём рюкзака;
■ Содержимое рюкзака (список объектов, у каждого
объекта кроме названия нужно учитывать занимаемый объём).
Создайте методы для заполнения характеристик.
Создайте событие для добавления объекта в рюкзак.
Реализуйте анонимный метод в качестве обработчика
события добавления объекта. Если при попытке добавления может быть превышен объём рюкзака, нужно
генерировать исключение.
*/
    internal class Schoolbag
    {
        public string Color { get; set; }
        public string FirmName { get; set; }
        public string Fabric { get; set; }
        public double Weight { get; set; }
        public double FilledVolume { get; set; }
        public double MaxVolume { get; set; }
        List<Item> Items { get; set; }

        public event EventHandler<Item>? ItemAdded;
        public Schoolbag()
        {
            Color = string.Empty;
            FirmName = string.Empty;
            Fabric = string.Empty;
            Weight = 0;
            FilledVolume = 0;
            MaxVolume = 0;
            Items = new List<Item>();

        }

        public Schoolbag(string color, string firmName, string fabric, double weight, double maxVolume)
        {
            Color = color;
            FirmName = firmName;
            Fabric = fabric;
            Weight = weight;
            MaxVolume = maxVolume;
            FilledVolume = 0;
            Items = new List<Item>();

        }

        public override string ToString()
        {
            return $"Цвет:{Color}, Название фирмы{FirmName}, Материал, Вес, Объем рюкзака, Вещи в рюкзаке: {string.Join(" ", Items)}";
        }


        public void AddItem(Item item)
        {
            try
            {

            if (item.Volume + FilledVolume > MaxVolume)
                throw new InvalidOperationException("Превышен объём рюкзака!");

            Items.Add(item);
            FilledVolume += item.Volume;

            ItemAdded?.Invoke(this, item);
            }
            catch (InvalidOperationException ex) {
                Console.WriteLine(ex);
            }
        }
    }

} 


