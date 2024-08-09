using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Model
{
    internal class LineItem 
    {
        private int _id;
        private int _quantity;
        private Product _product;

        public LineItem(int id, int quantity, Product product) 
        {
            _id = id;
            _quantity = quantity;
            _product = product;
        }

        public int getId{ get{ return _id; } }
        public int getQuantity { get { return _quantity; } }
        public Product getProduct { get { return _product; } }

        public double CalculateGetLineItemCost()
        {
            double totalCost = _product.CalculateDisscountedPrice() * _quantity;
            return totalCost;
        }

    }
}
