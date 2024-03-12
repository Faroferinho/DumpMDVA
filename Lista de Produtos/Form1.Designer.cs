namespace Lista_de_Produtos
{
    partial class FrmShowProducts
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowProducts));
            this.flwLytPnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBxBorder = new System.Windows.Forms.GroupBox();
            this.grpBxBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwLytPnlProducts
            // 
            this.flwLytPnlProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flwLytPnlProducts.AutoScroll = true;
            this.flwLytPnlProducts.BackColor = System.Drawing.Color.Transparent;
            this.flwLytPnlProducts.Location = new System.Drawing.Point(0, 50);
            this.flwLytPnlProducts.Name = "flwLytPnlProducts";
            this.flwLytPnlProducts.Size = new System.Drawing.Size(413, 574);
            this.flwLytPnlProducts.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(58, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(299, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Selecione um Produto";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // grpBxBorder
            // 
            this.grpBxBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxBorder.BackColor = System.Drawing.Color.Transparent;
            this.grpBxBorder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpBxBorder.BackgroundImage")));
            this.grpBxBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpBxBorder.Controls.Add(this.flwLytPnlProducts);
            this.grpBxBorder.Controls.Add(this.lblTitle);
            this.grpBxBorder.ForeColor = System.Drawing.Color.Transparent;
            this.grpBxBorder.Location = new System.Drawing.Point(23, 12);
            this.grpBxBorder.Name = "grpBxBorder";
            this.grpBxBorder.Size = new System.Drawing.Size(413, 624);
            this.grpBxBorder.TabIndex = 2;
            this.grpBxBorder.TabStop = false;
            // 
            // FrmShowProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(458, 648);
            this.Controls.Add(this.grpBxBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmShowProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione um Produto";
            this.Resize += new System.EventHandler(this.FrmShowProducts_Resize);
            this.grpBxBorder.ResumeLayout(false);
            this.grpBxBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flwLytPnlProducts;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBxBorder;
    }
}

