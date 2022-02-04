using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersAndProducts.DataCollection
{
    public class CustomersCollection
    {
        private Dictionary<string, List<CategoryesEnum>> _customers { get; } = 
            new Dictionary<string, List<CategoryesEnum>>();

        
        public void AddCategory(string customer, CategoryesEnum categoryes)
        {
            if(_customers.Keys.Any(x=> x.ToLower() == customer.ToLower()))
            {
                AddCategoryse(customer, categoryes);
                return;
            }
            _customers.Add(customer, new List<CategoryesEnum> { categoryes });
        }

        private void AddCategoryse(string customer, CategoryesEnum categoryes)
        {
            if(!_customers[customer].Any(x=> x == categoryes))
            {
                _customers[customer].Add(categoryes);
            }
        }

        public List<string> GetCustomers() =>
            _customers.Keys.ToList();
        public List<CategoryesEnum> GetCategoryes(string customers) =>
            _customers[customers];
        public List<string> GetCustomersByCategotyes(CategoryesEnum cat)  =>
            _customers.Where(x => x.Value.Any(y => y == cat)).Select(z => z.Key).ToList();
    }
}
