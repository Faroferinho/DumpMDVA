using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta_MdVA
{
    internal class CartItem
    {
        private Product product;
        private int quantity;

        public CartItem(Product prod, int quant) {
            product = prod;
            quantity = quant;
        }
        public CartItem(Product prod)
        {
            product = prod;
            quantity = 1;
        }

        public Product getProduct()
        {
            return product;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public decimal getValue()
        {
            return product.getValue(quantity);
        }

        public bool updateProduct(Product newProd)
        {
            bool toReturn = false;

            if(product != null)
            {
                product = newProd;
                toReturn = true;
            }

            return toReturn;
        }

        public bool updateProduct(String newId)
        {
            bool toReturn = false;
            String id = DBConector.readEntry("ID_Product", "Product");
            List<String> idList = id.Split().ToList();

            if (newId != null)
            {
                for(int i = 0; i < idList.Count; i++)
                {
                    if(newId == idList[i])
                    {
                        product = new Product(newId);
                        toReturn = true;
                        break;
                    }
                }
            }

            return toReturn;
        }

        public bool updateQuantity()
        {
            bool toReturn = false;

            if (product.getQuantity() > (quantity))
            {
                quantity++;
            }

            return toReturn;
        }
        public bool updateQuantity(int incrementable)
        {
            bool toReturn = false;

            if(product.getQuantity() > (quantity + incrementable) && (quantity + incrementable) > 0)
            quantity += incrementable;

            return toReturn;
        }

        public bool setQuantity(int newQuantity)
        {
            bool toReturn = false;

            if(quantity != null)
            {
                quantity = newQuantity;
                toReturn = true;
            }

            return toReturn;
        }
    }
}
