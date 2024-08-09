using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    internal class Order
    {
        private int _id;
        private DateTime _dateTime;
        private List<LineItem> _lineItems;

        public Order(int id, DateTime dateTime, List<LineItem> lineItems)
        {
            _id = id;
            _dateTime = dateTime;
            _lineItems = lineItems;
        }

        public int getID {  get { return _id; } }
        public DateTime getDateTime { get { return _dateTime; } }
        public List<LineItem> getLineItems { get { return _lineItems; } }

        public double CalculateOrderPrices()
        {   double totalPrice = 0;
            foreach (LineItem lineItem in _lineItems)
            {
                totalPrice += lineItem.CalculateGetLineItemCost();
            }
            return totalPrice;
        }
    }
}
