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
        public Cart()
        {
            InitializeComponent();

            pnl_WorkSpace.BackColor = Color.FromArgb(50, 0, 0, 0);

            foreach (KeyValuePair<String, CartItem> currentPair in Conductor.shoppingCart)
            {
                
            }
        }

        private void createItem(KeyValuePair<String, CartItem> pair)
        {
            Panel body = new Panel()
            {
                Location = new Point(18, 18),
                Size = new Size(450, 130)
            };

            PictureBox image = new PictureBox()
            {
                Image = pair.Value.getProduct().getPicture(),
                Size = new Size(115, 115),
            };

            Label productName = new Label()
            {
                Text = pair.Value.getProduct().getName(),
            };

            NumericUpDown quantity = new NumericUpDown()
            {

            };
        }

        private void bttn_Cancel_Click(object sender, EventArgs e)
        {
            Conductor.changeForm(0);
        }

        private void bttn_AddItem_Click(object sender, EventArgs e)
        {
            Cart.ActiveForm.Hide();
            Conductor.changeForm(1);
        }
    }
}