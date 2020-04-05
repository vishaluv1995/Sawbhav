using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineItem
{
    class LineItemN
    {
        private int _id;
        private string _productName;
        private int _quantity;
        private double _price;
        private static double _finaltooal;

        public LineItemN(int id, string productName, int quantity, Double price)
        {
            _id = id;
            _productName = productName;
            _quantity = quantity;
            _price = price;
        }

        public double CalculateTotal()
        {
            double total;
            total = _quantity * _price;
            _finaltooal = _finaltooal + total;
            return total;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public double FinalTotal
        {
            get
            {
                return _finaltooal;
            }
        }
    }
}
