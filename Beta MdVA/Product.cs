using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta_MdVA
{
    internal class Product
    {
        String identificator;
        String name;
        int quantity;
        decimal value;
        Image picture;

        public Product(String Id) 
        {
            identificator = Id;

            defineValues();
        }

        private void defineValues()
        {
            String infoFormDB = DBConector.readEntry( "*", "Products", $"ID_Product = \'{identificator}\'" );
            List<String> infoSorted = infoFormDB.Split('§').ToList();

            name = infoSorted[1];
            quantity = int.Parse(infoSorted[2]);
            value = decimal.Parse(infoSorted[3]);
            picture = Image.FromFile(infoSorted[4]);
        }

        public String getName()
        {
            return name;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public decimal getValue()
        {
            return getValue(1);
        }

        public decimal getValue(int quantity)
        {
            if (verifyStockAvailable(quantity))
            {
                return (quantity * value);
            }
            else
            {
                return 0;
            }
        }

        public Image getPicture()
        {
            return picture;
        }

        public bool verifyStockAvailable(int quantityRequested)
        {
            if(quantityRequested > quantity)
            {
                return false;
            }else if(quantityRequested < 0)
            {
                return false;
            }

            return true;
        }
    }
}
