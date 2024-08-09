    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    namespace ShoppingCart.Model
    {
        internal class Product
        {
            private int _id;
            private string _name;
            private double _price;
            private double discountPercentage;

            public Product(int id, string name, double price, double discount) 
            {
                _id = id;
                _name = name;
                _price = price;
                discountPercentage = discount;
            }

            public int getId{ get { return _id; } }
            public string getName { get{ return _name; } }
            public double getPrice { get{ return _price; } }
            public double getDiscountedPercentage {get { return discountPercentage; } }
        
            public double CalculateDisscountedPrice()
            {
                double discountedValue = this._price * (1 - discountPercentage/100);
                return discountedValue; 
            }

        }
    }
