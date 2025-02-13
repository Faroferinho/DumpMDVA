﻿using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta_MdVA
{
    internal class Conductor
    {
        public static Dictionary<String, CartItem> shoppingCart = new Dictionary<string, CartItem> ();

        public static bool changeForm(int formIndex)
        {
            bool capableOfChangeForm = false;
            Form emporium = null;
            Form cart = null;

            switch(formIndex)
            {
                case 0:
                    Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is Cart).Hide();
                    showConfirmAgeForm();
                    capableOfChangeForm = true;
                    break;
                case 1:
                    Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is ConfirmAge).Hide();
                    if (cart != null)
                    {
                        Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Cart).Hide();
                    }

                    if (emporium == null)
                    {
                        emporium = new Emporium();
                        emporium.Show();
                    }
                    else
                    {
                        emporium.Show();
                    }
                    capableOfChangeForm = true;
                    break;
                case 2:
                    Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Emporium).Close();
                    if (cart == null)
                    {
                        cart = new Cart();
                        cart.Show();
                    }
                    else
                    {
                        cart.Show();
                    }
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

        public static bool addToShoppingCart(Product p, int q)
        {
            bool added = false;

            CartItem toAdd = new CartItem(p, q);

            if (!checkIfOnShoppingCart(p.getID()))
            {
                shoppingCart.Add(p.getID(), toAdd);
            }
            /*MessageBox.Show($"Carrinho:\n" +
                            $"Quantidade de Itens: {shoppingCart.Count}");*/

            return added;
        }

        public static bool checkIfOnShoppingCart(String newItemID)
        {
            bool toReturn = false;

            foreach (KeyValuePair<String, CartItem> currElement in shoppingCart)
            {
                if (currElement.Key == newItemID)
                {
                    MessageBox.Show("Existe no ShoppingList");
                    shoppingCart[newItemID].updateQuantity();
                    toReturn = true;
                    break;
                }
            }
            return toReturn;
        }
    }
}
