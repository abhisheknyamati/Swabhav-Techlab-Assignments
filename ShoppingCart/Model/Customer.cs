using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _orders;

        public Customer(int id, string name, List<Order> orders) 
        {
            _id = id;
            _name = name;
            _orders = orders;
        }

        public int getId { get { return _id; } }
        public string getName { get { return _name; }}
        public List<Order> getOrders { get{ return _orders; } }

        public List<Customer> customers = new List<Customer>();
    }
}
