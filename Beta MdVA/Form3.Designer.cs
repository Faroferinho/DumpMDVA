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
            this.pnl_WorkSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_WorkSpace
            // 
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
            this.lbl_Title.Location = new System.Drawing.Point(178, 0);
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
    }
}