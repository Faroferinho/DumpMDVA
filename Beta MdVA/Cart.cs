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
                BackColor = Color.Transparent,
            };

            Label productName = new Label()
            {
                Text = $"{pair.Value.getProduct().getName()}",
                Location = new Point(131 + (319 / 2), 30),
                BackColor = Color.Transparent,
                ForeColor = Color.White,
            };

            NumericUpDown quantity = new NumericUpDown()
            {
                Location = new Point(230, 75),
                TextAlign = HorizontalAlignment.Center,
                Size = new Size(80, 70),
                Value = pair.Value.getQuantity(),
                Tag = pair.Key,
                Minimum = 1,
                Maximum = pair.Value.getProduct().getQuantity(),
            };

            Button bttnAdd = new Button()
            {
                Location = new Point(326, 70),
                Text = "+",
                Size = new Size(30, 30),
                Tag = pair.Key,
                BackColor = Color.Transparent,
            };

            Button bttnTake = new Button()
            {
                Location = new Point(184, 70),
                Text = "-",
                Size = new Size(30, 30),
                Tag = pair.Key,
                BackColor = Color.Transparent,
            };

            productName.Location = new Point(131 + (299 / 2) - (productName.Width / 2), 30);

            quantity.ValueChanged += changeDictionary;

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
            Control localControl = ((Control) sender);

            Conductor.shoppingCart[$"{localControl.Tag}"].updateQuantity();

            foreach (Control controlFromForm in this.Controls) 
            {
                if(controlFromForm is Panel)
                {
                    foreach (Control controlFromPanel in controlFromForm.Controls)
                    {
                        if (controlFromPanel is Panel)
                        {
                            foreach(Control controlFromSecondPanel in controlFromPanel.Controls)
                            {
                                if (controlFromSecondPanel is Panel)
                                {
                                    foreach(Control controlFromBody in controlFromSecondPanel.Controls)
                                    {
                                        if(controlFromBody is NumericUpDown && controlFromBody.Tag == localControl.Tag)
                                        {
                                            ((NumericUpDown)controlFromBody).Value = Conductor.shoppingCart[$"{localControl.Tag}"].getQuantity();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void decrementQuantity(object sender, EventArgs e)
        {
            Control localControl = ((Control)sender);

            Conductor.shoppingCart[$"{localControl.Tag}"].updateQuantity(-1);

            foreach (Control controlFromForm in this.Controls)
            {
                if (controlFromForm is Panel)
                {
                    foreach (Control controlFromPanel in controlFromForm.Controls)
                    {
                        if (controlFromPanel is Panel)
                        {
                            foreach (Control controlFromSecondPanel in controlFromPanel.Controls)
                            {
                                if (controlFromSecondPanel is Panel)
                                {
                                    foreach (Control controlFromBody in controlFromSecondPanel.Controls)
                                    {
                                        if (controlFromBody is NumericUpDown)
                                        {
                                            ((NumericUpDown)controlFromBody).Value = Conductor.shoppingCart[$"{localControl.Tag}"].getQuantity();

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
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

        private void bttn_Purchase_Click(object sender, EventArgs e)
        {
            Conductor.changeForm(3);
        }

        private void changeDictionary(object sender, EventArgs e)
        {
            Conductor.shoppingCart["" + ((Control)sender).Tag].setQuantity(int.Parse("" + ((NumericUpDown)sender).Value));

        }
    }
}