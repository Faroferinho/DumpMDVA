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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bttn_Add = new System.Windows.Forms.Button();
            this.bttn_Delete = new System.Windows.Forms.Button();
            this.pnl_WorkSpace.SuspendLayout();
            this.pnl_CartList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.pnl_CartList.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.bttn_Delete);
            this.panel1.Controls.Add(this.bttn_Add);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 130);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(257, 70);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 25);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ThousandsSeparator = true;
            // 
            // bttn_Add
            // 
            this.bttn_Add.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.bttn_Add.Location = new System.Drawing.Point(362, 65);
            this.bttn_Add.Name = "bttn_Add";
            this.bttn_Add.Size = new System.Drawing.Size(30, 30);
            this.bttn_Add.TabIndex = 3;
            this.bttn_Add.Text = "+";
            this.bttn_Add.UseVisualStyleBackColor = true;
            // 
            // bttn_Delete
            // 
            this.bttn_Delete.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.bttn_Delete.Location = new System.Drawing.Point(212, 65);
            this.bttn_Delete.Name = "bttn_Delete";
            this.bttn_Delete.Size = new System.Drawing.Size(30, 30);
            this.bttn_Delete.TabIndex = 4;
            this.bttn_Delete.Text = "-";
            this.bttn_Delete.UseVisualStyleBackColor = true;
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
            this.pnl_CartList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_WorkSpace;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_CartList;
        private System.Windows.Forms.Button bttn_Purchase;
        private System.Windows.Forms.Button bttn_Cancel;
        private System.Windows.Forms.Button bttn_AddItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bttn_Delete;
        private System.Windows.Forms.Button bttn_Add;
    }
}