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
    public partial class Emporium : Form
    {
        List<string> IDList = new List<string>();

        public Emporium()
        {
            InitializeComponent();

            pnl_MainBody.BackColor = Color.FromArgb(50, 0, 0, 0);
            pnl_Products.BackColor = Color.FromArgb(50, 0, 0, 0);
            lbl_Title.BackColor = Color.FromArgb(0, 0, 0, 0);

            restartList();
            generateButtons();


        }

        public void restartList()
        {
            String aux = DBConector.readEntry("ID_Product", "Products");
            
            if (aux != ("§"))
            {
                IDList = aux.Split('§').ToList();
            }
        }

        public void generateButtons()
        {
            int auxX = 0;
            int auxY = 0;

            for (int i = 0; i < (IDList.Count - 1); i++)
            {
                if (auxX > 2)
                {
                    auxX = 0;
                    auxY++;
                }

                Product newProd = new Product(IDList[i]);

                Button createItem = new Button()
                {
                    Text = $"{newProd.getName()}\n{newProd.getValue()}",
                    Location = new Point(5 + auxX * 160, 5 + auxY * 160),
                    Size = new Size(125, 125),
                    BackColor = Color.Transparent,
                    BackgroundImage = newProd.getPicture(),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Tag = newProd,
                    FlatStyle = FlatStyle.Flat,
                };

                createItem.FlatAppearance.BorderSize = 0;
                createItem.FlatAppearance.MouseOverBackColor = Color.Transparent;
                createItem.FlatAppearance.MouseDownBackColor = Color.Transparent;

                createItem.Click += CreateItem_Click;

                pnl_Products.Controls.Add(createItem);

                auxX++;
            }
        }

        private void CreateItem_Click(object sender, EventArgs e)
        {
            Product p = ((Product)((Control)sender).Tag);

            FormManager.addToShoppingCart(p, 1);
        }
    }
}
