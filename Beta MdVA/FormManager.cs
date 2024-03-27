using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta_MdVA
{
    internal class FormManager
    {
        public Dictionary<String, object> shoppingCart = new Dictionary<String, Dictionary<Product, int>>();

        public static bool changeForm(int formIndex)
        {
            bool capableOfChangeForm = false;
            Form product;

            switch(formIndex)
            {
                case 0:
                    showConfirmAgeForm();
                    capableOfChangeForm = true;
                    break;
                case 1:
                    Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is ConfirmAge).Hide();
                    product = new ProductList();
                    product.Show();
                    capableOfChangeForm = true;
                    break;
                case 2:
                    capableOfChangeForm = true;
                    break;
                case 3:
                    capableOfChangeForm = true;
                    break;
                default:
                    MessageBox.Show("Não existe");
                    break;
            }

            return capableOfChangeForm;
        }

        public static void showConfirmAgeForm()
        {
            Form formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is ConfirmAge);

            if (formToShow != null)
            {
                formToShow.Show();
            }
            else
            {
                formToShow = new ConfirmAge();
            }
        }
    }
}
