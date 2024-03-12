using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Produtos
{
    public partial class FrmShowProducts : Form
    {
        List<Product> products = new List<Product>();
        int bttnIndex = 0;

        public FrmShowProducts()
        {
            InitializeComponent();

            String ids = DBConector.readEntry("Id_Product", "Products");
            List<String> auxIds = ids.Split('§').ToList();
            for (int i = 0; i < auxIds.Count-1; i++)
            {
                if (auxIds[i] != null)
                {
                    Product nPrd = new Product(auxIds[i]);
                    
                    products.Add(nPrd);

                    addButtonToForm(nPrd, i);
                }
            }
        }

        private void addButtonToForm(Product prdct, int index)
        {
            Button bttnList = new Button()
            {
                Location = new Point(200 * index, 40),
                Text = prdct.getInfo(1) + "\n" + prdct.getInfo(3),
                Width = 120,
                Height = 155,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
               
                Image = prdct.getPicture(),
                
            };

            bttnList.Click += changePage;

            flwLytPnlProducts.Controls.Add(bttnList);
        }
        
        private void changePage(object sender, EventArgs e)
        {
            MessageBox.Show($"Clicou no botão {((Button)(sender)).TabIndex}");
        }



        private void lblTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os berros da cidade de Pandemonio serão ouvidos pelos quatro cantos da Terra");
        }

        private void FrmShowProducts_Resize(object sender, EventArgs e)
        {
        }
    }
}
