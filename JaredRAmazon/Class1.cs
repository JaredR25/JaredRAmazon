using System;
using System.Collections.Generic;
using System.Text;

namespace JaredRAmazon
{
    public class Product
    {
        public Product() { }

        private string _name = "";

        public string ProductID { get; init; } = "";
        public string ProductName
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name)) MessageBox.Show("Must have a name");
                _name = value;
            }
        }
        public string ProductDescription { get; set; } = "";
        public string ProductBrand { get; set; } = "";
        public string ProductPrice { get; set; } = "";

    }
}
