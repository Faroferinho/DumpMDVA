using Lista_de_Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta_MdVA
{
    public partial class ProductList : Form
    {
        List<string> IDList = new List<string>();

        public ProductList()
        {
            InitializeComponent();

            pnl_MainBody.BackColor = Color.FromArgb(50, 0, 0, 0);
            pnl_Products.BackColor = Color.FromArgb(50, 0, 0, 0);
            lbl_Title.BackColor = Color.FromArgb(0, 0, 0, 0);

            restartList();

            for(int i = 0; i < IDList.Count; i++)
            {
                Product newProd = new Product(IDList[i]);
            }
        }

        public void restartList()
        {
            String aux = DBConector.readEntry("Products");
            if (aux != null)
            {
                IDList = aux.Split('§').ToList();
            }
        }
    }
}
