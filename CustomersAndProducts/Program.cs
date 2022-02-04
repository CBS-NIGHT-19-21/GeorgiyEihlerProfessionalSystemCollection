
/*
 Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими 
продукции. Из коллекции можно получать категории товаров, которые купил покупатель или по 
категории определить покупателей.
 
 */
using CustomersAndProducts.DataCollection;

var database = new CustomersCollection();

database.AddCategory("Georgiy", CategoryesEnum.Games);
database.AddCategory("Georgiy", CategoryesEnum.Programs);
database.AddCategory("Lena", CategoryesEnum.Hardwares);
database.AddCategory("Lena", CategoryesEnum.Games);
database.AddCategory("Lena", CategoryesEnum.Games);

Printer(database.GetCustomers(), "Покупатели");
Printer(database.GetCategoryes("Lena"), "Категории");
Printer(database.GetCustomersByCategotyes(CategoryesEnum.Games), "Покупатели категории");



void Printer<T>(List<T> printer, string namePrinter = "default Printer")
{
    Console.WriteLine($"\n{new string ('*', 20)}{namePrinter}{new string('*', 20)}\n");
   
    foreach (var item in printer)
    {
        Console.WriteLine(item);
    }
}

