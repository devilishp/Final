using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kr
{
    abstract class Product : IComparable<Product>
    {   
        // абстрактный класс с полями
        private string name;
        private int price;
        private int quantity;
        // гетеры и сеттеры с условиями
        public string Name { 
                get { return name; }
                set
                 {
                    if (value == string.Empty) throw new ArgumentException("Отстутсвует название.");
                    name = value;
                }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0) throw new ArgumentException("Неверно введены данные");
                price = value;
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0) throw new ArgumentException("Неверно введены данные");
                quantity = value;
            }
        }

        // конструктор
        public Product(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        //Реализация интерфейса
        public int CompareTo(Product other)
        {
            return Price.CompareTo(other.Price);
        }

        //виртуальный метод ToString
        public override string ToString()
        {
            return $"Название товара: {Name}, Цена: {Price}, Количество: {Quantity}";
        }
    }
}
