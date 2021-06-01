using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_SEL_FW.dto;

namespace HW_SEL_FW.service
{
    class InitProduct
    {
        public static void ParamProduct(IWebElement productName,
                                            IWebElement categoryId,
                                            IWebElement supplierId,
                                            IWebElement unitPrice,
                                            IWebElement quantityPerUnit,
                                            IWebElement unitsInStock,
                                            IWebElement unitsOnOrder,
                                            IWebElement reorderLevel)
        {
            Product product = new Product();
            productName.SendKeys(product.productName);
            categoryId.SendKeys(product.categoryId);
            supplierId.SendKeys(product.supplierId);
            unitPrice.SendKeys(product.unitPrice);
            quantityPerUnit.SendKeys(product.quantityPerUnit);
            unitsInStock.SendKeys(product.unitsInStock);
            unitsOnOrder.SendKeys(product.unitsOnOrder);
            reorderLevel.SendKeys(product.reorderLevel);
        }
    }
}