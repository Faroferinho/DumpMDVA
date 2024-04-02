namespace Beta_MdVA
{
    partial class Cart
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
            this.pnl_WorkSpace = new System.Windows.Forms.Panel();
            this.bttn_AddItem = new System.Windows.Forms.Button();
            this.bttn_Purchase = new System.Windows.Forms.Button();
            this.bttn_Cancel = new System.Windows.Forms.Button();
            this.pnl_CartList = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_WorkSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_WorkSpace
            // 
            this.pnl_WorkSpace.Controls.Add(this.bttn_AddItem);
            this.pnl_WorkSpace.Controls.Add(this.bttn_Purchase);
            this.pnl_WorkSpace.Controls.Add(this.bttn_Cancel);
            this.pnl_WorkSpace.Controls.Add(this.pnl_CartList);
            this.pnl_WorkSpace.Controls.Add(this.lbl_Title);
            this.pnl_WorkSpace.Location = new System.Drawing.Point(12, 12);
            this.pnl_WorkSpace.Name = "pnl_WorkSpace";
            this.pnl_WorkSpace.Size = new System.Drawing.Size(512, 634);
            this.pnl_WorkSpace.TabIndex = 0;
            // 
            // bttn_AddItem
            // 
            this.bttn_AddItem.Location = new System.Drawing.Point(204, 590);
            this.bttn_AddItem.Name = "bttn_AddItem";
            this.bttn_AddItem.Size = new System.Drawing.Size(98, 41);
            this.bttn_AddItem.TabIndex = 5;
            this.bttn_AddItem.Text = "Adicionar Item";
            this.bttn_AddItem.UseVisualStyleBackColor = true;
            this.bttn_AddItem.Click += new System.EventHandler(this.bttn_AddItem_Click);
            // 
            // bttn_Purchase
            // 
            this.bttn_Purchase.Location = new System.Drawing.Point(387, 590);
            this.bttn_Purchase.Name = "bttn_Purchase";
            this.bttn_Purchase.Size = new System.Drawing.Size(98, 41);
            this.bttn_Purchase.TabIndex = 4;
            this.bttn_Purchase.Text = "Finalizar Compra";
            this.bttn_Purchase.UseVisualStyleBackColor = true;
            this.bttn_Purchase.Click += new System.EventHandler(this.bttn_Purchase_Click);
            // 
            // bttn_Cancel
            // 
            this.bttn_Cancel.Location = new System.Drawing.Point(31, 590);
            this.bttn_Cancel.Name = "bttn_Cancel";
            this.bttn_Cancel.Size = new System.Drawing.Size(98, 41);
            this.bttn_Cancel.TabIndex = 3;
            this.bttn_Cancel.Text = "Cancelar Compra";
            this.bttn_Cancel.UseVisualStyleBackColor = true;
            this.bttn_Cancel.Click += new System.EventHandler(this.bttn_Cancel_Click);
            // 
            // pnl_CartList
            // 
            this.pnl_CartList.Location = new System.Drawing.Point(15, 40);
            this.pnl_CartList.Name = "pnl_CartList";
            this.pnl_CartList.Size = new System.Drawing.Size(482, 544);
            this.pnl_CartList.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(197, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(128, 37);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Carrinho";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(536, 658);
            this.Controls.Add(this.pnl_WorkSpace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.pnl_WorkSpace.ResumeLayout(false);
            this.pnl_WorkSpace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_WorkSpace;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_CartList;
        private System.Windows.Forms.Button bttn_Purchase;
        private System.Windows.Forms.Button bttn_Cancel;
        private System.Windows.Forms.Button bttn_AddItem;
    }
}