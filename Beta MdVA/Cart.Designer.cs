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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_CartList = new System.Windows.Forms.Panel();
            this.bttn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_WorkSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_WorkSpace
            // 
            this.pnl_WorkSpace.Controls.Add(this.button1);
            this.pnl_WorkSpace.Controls.Add(this.bttn);
            this.pnl_WorkSpace.Controls.Add(this.pnl_CartList);
            this.pnl_WorkSpace.Controls.Add(this.lbl_Title);
            this.pnl_WorkSpace.Location = new System.Drawing.Point(12, 12);
            this.pnl_WorkSpace.Name = "pnl_WorkSpace";
            this.pnl_WorkSpace.Size = new System.Drawing.Size(496, 595);
            this.pnl_WorkSpace.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(184, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(128, 37);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Carrinho";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_CartList
            // 
            this.pnl_CartList.Location = new System.Drawing.Point(15, 40);
            this.pnl_CartList.Name = "pnl_CartList";
            this.pnl_CartList.Size = new System.Drawing.Size(468, 505);
            this.pnl_CartList.TabIndex = 2;
            // 
            // bttn
            // 
            this.bttn.Location = new System.Drawing.Point(73, 551);
            this.bttn.Name = "bttn";
            this.bttn.Size = new System.Drawing.Size(98, 41);
            this.bttn.TabIndex = 3;
            this.bttn.Text = "Cancelar Compra";
            this.bttn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Finalizar Compra";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(520, 619);
            this.Controls.Add(this.pnl_WorkSpace);
            this.Name = "Cart";
            this.Text = "Form3";
            this.pnl_WorkSpace.ResumeLayout(false);
            this.pnl_WorkSpace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_WorkSpace;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_CartList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttn;
    }
}