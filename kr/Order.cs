using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr
{
    class Order
    {
        // сам список
        private List<Product> products;

        //дефолтные значения (пустой список по умолчанию)
        public Order()
        {
            products = new List<Product>();
        }

        // метод add 
        public void Add(Product product)
        {
            products.Add(product);
        }

        //метод подсчета итоговой стоимости
        public int Total
        {
            get
            {
                int total = 0;
                foreach (Product product in products)
                {
                    total += product.Price * product.Quantity;
                }
                return total;
            }
        }

        public override string ToString()
        {
            string orderInfo = "Информация:\n";
            foreach (Product product in products)
            {
                orderInfo += product.ToString() + "\n";
            }
            return orderInfo;
        }

        // метод сортировки
        public void SortProduct()
        {
            products.Sort();
        }

        // метод, который чекает инфу на товары < 1 месяца
        public List<Product> GetExpiringNextMonth()
        {
            List<Product> expiringProducts = new List<Product>();
            DateTime nextMonth = DateTime.Now.AddMonths(1);

            foreach (Product product in products)
            {
                if (product is Food food && nextMonth > DateTime.Now.AddMonths(food.ExpiryMonths))
                {
                    expiringProducts.Add(product);
                }
            }

            return expiringProducts;
        }
    }

}
