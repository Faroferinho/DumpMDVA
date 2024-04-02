namespace Beta_MdVA
{
    partial class ConfirmPurchase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.bttn_Debit = new System.Windows.Forms.Button();
            this.bttn_Credit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bttn_Credit);
            this.panel1.Controls.Add(this.bttn_Debit);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 595);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(118, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(256, 37);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Confirmar Compra";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttn_Debit
            // 
            this.bttn_Debit.Location = new System.Drawing.Point(53, 213);
            this.bttn_Debit.Name = "bttn_Debit";
            this.bttn_Debit.Size = new System.Drawing.Size(125, 75);
            this.bttn_Debit.TabIndex = 3;
            this.bttn_Debit.Text = "Débito";
            this.bttn_Debit.UseVisualStyleBackColor = true;
            // 
            // bttn_Credit
            // 
            this.bttn_Credit.Location = new System.Drawing.Point(321, 213);
            this.bttn_Credit.Name = "bttn_Credit";
            this.bttn_Credit.Size = new System.Drawing.Size(125, 75);
            this.bttn_Credit.TabIndex = 4;
            this.bttn_Credit.Text = "Crédito";
            this.bttn_Credit.UseVisualStyleBackColor = true;
            // 
            // ConfirmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(520, 619);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmPurchase";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button bttn_Credit;
        private System.Windows.Forms.Button bttn_Debit;
    }
}