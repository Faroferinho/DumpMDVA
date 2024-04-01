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
    public partial class Cart : Form
    {
        int i = 0;

        public Cart()
        {
            InitializeComponent();

            pnl_WorkSpace.BackColor = Color.FromArgb(50, 0, 0, 0);

            foreach (KeyValuePair<String, CartItem> currentPair in Conductor.shoppingCart)
            {
                pnl_CartList.Controls.Add(createItem(currentPair));
                i++;
            }
        }

        private Panel createItem(KeyValuePair<String, CartItem> pair)
        {
            Panel body = new Panel()
            {
                Location = new Point(18, (18 * (i+1)) + (i * 130)),
                Size = new Size(450, 130),
                ForeColor = Color.Black,
                Tag = pair.Key,
            };

            PictureBox image = new PictureBox()
            {
                Image = pair.Value.getProduct().getPicture(),
                Size = new Size(115, 115),
                Location = new Point(8, 8),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            Label productName = new Label()
            {
                Text = $"{pair.Value.getProduct().getName()}",
                Location = new Point(131 + (319 / 2), 30),
            };

            NumericUpDown quantity = new NumericUpDown()
            {
                Location = new Point(230, 75),
                TextAlign = HorizontalAlignment.Center,
                Size = new Size(80, 70),
                Value = pair.Value.getQuantity(),
            };

            Button bttnAdd = new Button()
            {
                Location = new Point(326, 70),
                Text = "+",
                Size = new Size(30, 30),
                Tag = pair.Key,
            };

            Button bttnTake = new Button()
            {
                Location = new Point(184, 70),
                Text = "-",
                Size = new Size(30, 30),
            };

            productName.Location = new Point(131 + (299 / 2) - (productName.Width / 2), 30);

            bttnAdd.Click += incrementQuantity;
            bttnTake.Click += decrementQuantity;

            body.Controls.Add(image);
            body.Controls.Add(productName);
            body.Controls.Add(quantity);
            body.Controls.Add(bttnAdd);
            body.Controls.Add(bttnTake);

            return body;
        }

        private void incrementQuantity(object sender, EventArgs e)
        {
            Control c = ((Control) sender);

            Conductor.shoppingCart[$"{c.Tag}"].updateQuantity();
        }

        private void decrementQuantity(object sender, EventArgs e)
        {

        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            Conductor.shoppingCart = new Dictionary<string, CartItem>();
            Conductor.changeForm(0);
        }

        private void bttn_AddItem_Click(object sender, EventArgs e)
        {
            Cart.ActiveForm.Hide();
            Conductor.changeForm(1);
        }
    }
}