namespace Basit_Mvc.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer = new Customer();
        public List<Order> Orders = new List<Order>();
    }
}
