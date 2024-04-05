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
        List<Product> products = new List<Product>();

        public Emporium()
        {
            InitializeComponent();

            restartList();
            fillButtonsList();
        }

        public void restartList()
        {
            String aux = DBConector.readEntry("ID_Product", "Products");
            List<string> ids = new List<string>();
            
            if (aux != ("§"))
            {
                ids = (aux.Split('§').ToList());

                foreach (string currID in ids)
                {
                    products.Add(new Product(currID));
                }
            }
        }

        public void fillButtonsList()
        {
            int auxX = 0;
            int auxY = 0;

            for (int i = 0; i < (products.Count - 1); i++)
            {
                if (auxX > 2)
                {
                    auxX = 0;
                    auxY++;
                }

                Product newProd = products[i];

                Button createItem = new Button()
                {
                    Location = new Point(23 + auxX * 160, 5 + auxY * 160),
                    Size = new Size(125, 125),
                    BackColor = Color.Transparent,
                    BackgroundImage = newProd.getPicture(),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ForeColor = Color.Yellow,
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

        private void generatePanel()
        {
            int auxX = 0;
            int auxY = 0;

            foreach (Product productFromList in products)
            {
                Panel item = new Panel();
                PictureBox pctrBx_Image = new PictureBox();
                Label lbl_Info = new Label();

                item.Size = new Size(125, 150);
                item.BackColor = Color.Transparent;

                pctrBx_Image.Size = new Size(125, 125);
                pctrBx_Image.Location = new Point(0, 0);
                pctrBx_Image.Image = (Image)(new Bitmap(productFromList.getPicture(), new Size(125, 125)));
                pctrBx_Image.BackColor = Color.Transparent;

                lbl_Info.Text = $"{productFromList.getName()}\n{productFromList.getValue()}";
                lbl_Info.Font = new Font();
            }
        }

        private void CreateItem_Click(object sender, EventArgs e)
        {
            Product p = ((Product)((Control)sender).Tag);

            Conductor.addToShoppingCart(p, 1);

            Conductor.changeForm(2);
        }
    }
}
