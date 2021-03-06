using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);


            if(productId==2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Yellow sunflowers";
                product.CurrentPrice = 15.96M;


            }

            return product;

        }


        //save method access data store to save user changes

        public bool Save(Product product)
        {
            return true;

        }

    }
}
