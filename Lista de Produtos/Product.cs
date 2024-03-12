using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Produtos
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

            name = defineValues(1);
            quantity = int.Parse(defineValues(2));
            value = decimal.Parse(defineValues(3));
            picture = Image.FromFile(defineValues(4));
        }

        private String defineValues(int columnIndex)
        {
            String returnString = "";

            switch (columnIndex)
            {
                case 1:
                    returnString = DBConector.readEntry("name", "Products", $"ID_Product = \"{identificator}\"").Replace("§", "");
                    break;
                case 2:
                    returnString = DBConector.readEntry("quantity", "Products", $"ID_Product = \"{identificator}\"").Replace("§", "");
                    break;
                case 3:
                    returnString = DBConector.readEntry("value", "Products", $"ID_Product = \"{identificator}\"").Replace("§", "");
                    break;
                case 4:
                    returnString = DBConector.readEntry("picture", "Products", $"ID_Product = \"{identificator}\"").Replace("§", "");

                    break;
                default:
                    returnString = identificator;
                    break;
            }

            return returnString;
        }

        public String getInfo(int index)
        {
            String infoRequested = "";

            switch (index)
            {
                case 0:
                    infoRequested = identificator;
                    break;
                case 1:
                    infoRequested = name;
                    break;
                case 2:
                    infoRequested = "" + quantity;
                    break;
                case 3:
                    infoRequested = "" + value;
                    break;
            }

            return infoRequested;
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
    }
}
