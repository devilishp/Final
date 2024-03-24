using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr
{
    class Food : Product
    {
        // геттер сеттер на целочисленное значение (int)
        public int ExpiryMonths { get; set; }

        // конструктор, который берет инфу с родительского класса с помощью base
        public Food(string name, int price, int quantity, int expiryMonths) : base(name, price, quantity)
        {
            ExpiryMonths = expiryMonths;
        }

        // виртуальный метод ToString
        public override string ToString()
        {
            return $"{base.ToString()}, Срок годности: {ExpiryMonths} месяцев";
        }
    }
}
