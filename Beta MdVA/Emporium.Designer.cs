namespace Beta_MdVA
{
    partial class Emporium
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_MainBody = new System.Windows.Forms.Panel();
            this.pnl_Products = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_MainBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_MainBody
            // 
            this.pnl_MainBody.BackColor = System.Drawing.Color.Transparent;
            this.pnl_MainBody.BackgroundImage = global::Beta_MdVA.Properties.Resources.Border;
            this.pnl_MainBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_MainBody.Controls.Add(this.pnl_Products);
            this.pnl_MainBody.Controls.Add(this.lbl_Title);
            this.pnl_MainBody.ForeColor = System.Drawing.Color.White;
            this.pnl_MainBody.Location = new System.Drawing.Point(12, 12);
            this.pnl_MainBody.Name = "pnl_MainBody";
            this.pnl_MainBody.Size = new System.Drawing.Size(512, 730);
            this.pnl_MainBody.TabIndex = 0;
            // 
            // pnl_Products
            // 
            this.pnl_Products.AutoScroll = true;
            this.pnl_Products.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Products.Location = new System.Drawing.Point(12, 61);
            this.pnl_Products.Name = "pnl_Products";
            this.pnl_Products.Size = new System.Drawing.Size(486, 645);
            this.pnl_Products.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(138, 21);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(241, 37);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Lista de Produtos";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Emporium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = global::Beta_MdVA.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(533, 754);
            this.Controls.Add(this.pnl_MainBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Emporium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pnl_MainBody.ResumeLayout(false);
            this.pnl_MainBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MainBody;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Products;
    }
}