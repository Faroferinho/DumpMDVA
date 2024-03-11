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
        public FrmShowProducts()
        {
            InitializeComponent();

            String ids = DBConector.readEntry("Id_Product", "Products");
            List<String> auxIds = ids.Split('§').ToList();
            
            //MessageBox.Show("Texto: " + ids + "\n" + "Tamanho: " + auxIds.Count, "IDs");

            for (int i = 0; i < auxIds.Count; i++)
            {
                MessageBox.Show($"Indice: {i}\nTexto: {auxIds[i]}", "Ids");
                if (auxIds[i] != null)
                {
                    Product nPrd = new Product(auxIds[i]);

                    if (auxIds[i] != null)
                    {
                        MessageBox.Show($"Id: {nPrd.getInfo(0)} \n" +
                                $"  Nome: {nPrd.getInfo(1)} \n" +
                                $"  Quantidade: {nPrd.getInfo(2)} \n" +
                                $"  Valor: {nPrd.getInfo(3)} \n" +
                                $"  Imagem: {nPrd.getPicture().ToString()} \n");
                    }
                    

                    products.Add(nPrd);
                }
            }

            for (int i = 0; i < products.Count; i++)
            {
                
            }
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os berros da cidade de Pandemonio serão ouvidos pelos quatro cantos da Terra");
        }
    }
}
