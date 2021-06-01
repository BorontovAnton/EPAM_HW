using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SEL_FW.dto
{
    class Product
    {
        public string productName { get; set; }
        public string categoryId { get; set; }
        public string supplierId { get; set; }
        public string unitPrice { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitsInStock { get; set; }
        public string unitsOnOrder { get; set; }
        public string reorderLevel { get; set; }

        public Product()
        {
            productName = "Gobies in tomato";
            categoryId = "Seafood";
            supplierId = "Exotic Liquids";
            unitPrice = "100";
            quantityPerUnit = "1000";
            unitsInStock = "10";
            unitsOnOrder = "5";
            reorderLevel = "1";
        }
    }

}