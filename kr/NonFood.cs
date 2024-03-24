using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kr
{
    // класс NonFood наследующий класс Product
    class NonFood : Product
    {
        // поля и геттер сеттер, который выполняет условия
        private int lifespanyears;
        public int LifespanYears
        {
            get { return lifespanyears; }
            set
            {
                if (value <= 0) throw new ArgumentException("Неверно введены данные.");
                lifespanyears = value;
            }
        }

        // Конструктор
        public NonFood(string name, int price, int quantity, byte lifespanYears)
            : base(name, price, quantity)
        {
            LifespanYears = lifespanYears;
        }
        // виртуальный метод ToString
        public override string ToString()
        {
            return $"{base.ToString()}, Срок годности: {LifespanYears} лет";
        }
    }
}
