using System.Text;

namespace kr
{
    class Program {
        public static void Main()
        {
            Order order = new Order();

            // Добавление товаров в заказ
            order.Add(new Food("Бананчики", 4, 5, 1));
            order.Add(new NonFood("Утюг", 52, 2, 5));
            order.Add(new Food("Хлеб", 21, 10, 2));
            order.Add(new Food("Масло", 16, 7, 0));
            order.SortProduct();

            // Вывод информации о товарах с истекающим сроком годности через 1 месяц
            List<Product> expiringProducts = order.GetExpiringNextMonth();
            Console.WriteLine("Срок годности истекает (следующий месяц):");
            foreach (Product product in expiringProducts)
            {
                Console.WriteLine(product.ToString());
            }

            // Вывод общей стоимости заказа
            Console.WriteLine($"Общая стоимость: {order.Total}");

            // Вывод информации о всех товарах в заказе
            Console.WriteLine(order.ToString());
            Console.ReadLine();
        }

    }
 
}