﻿namespace Beta_MdVA
{
    partial class ConfirmAge
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.bttn_Check = new System.Windows.Forms.Button();
            this.cmbBx_Year = new System.Windows.Forms.ComboBox();
            this.cmbBx_Month = new System.Windows.Forms.ComboBox();
            this.cmbBx_Day = new System.Windows.Forms.ComboBox();
            this.pnl_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(107, 11);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(300, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Confirmador de Idade";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Body
            // 
            this.pnl_Body.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Body.Controls.Add(this.lbl_Year);
            this.pnl_Body.Controls.Add(this.lbl_Month);
            this.pnl_Body.Controls.Add(this.lbl_Day);
            this.pnl_Body.Controls.Add(this.bttn_Check);
            this.pnl_Body.Controls.Add(this.cmbBx_Year);
            this.pnl_Body.Controls.Add(this.cmbBx_Month);
            this.pnl_Body.Controls.Add(this.cmbBx_Day);
            this.pnl_Body.Controls.Add(this.lbl_Title);
            this.pnl_Body.Location = new System.Drawing.Point(12, 12);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(512, 634);
            this.pnl_Body.TabIndex = 1;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(442, 148);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(26, 13);
            this.lbl_Year.TabIndex = 7;
            this.lbl_Year.Text = "Ano";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Location = new System.Drawing.Point(253, 148);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(27, 13);
            this.lbl_Month.TabIndex = 6;
            this.lbl_Month.Text = "Mês";
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Location = new System.Drawing.Point(48, 148);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(23, 13);
            this.lbl_Day.TabIndex = 5;
            this.lbl_Day.Text = "Dia";
            // 
            // bttn_Check
            // 
            this.bttn_Check.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Check.Location = new System.Drawing.Point(158, 521);
            this.bttn_Check.Name = "bttn_Check";
            this.bttn_Check.Size = new System.Drawing.Size(196, 86);
            this.bttn_Check.TabIndex = 4;
            this.bttn_Check.Text = "Verificar";
            this.bttn_Check.UseVisualStyleBackColor = false;
            this.bttn_Check.Click += new System.EventHandler(this.bttn_Check_Click);
            // 
            // cmbBx_Year
            // 
            this.cmbBx_Year.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBx_Year.FormattingEnabled = true;
            this.cmbBx_Year.Location = new System.Drawing.Point(388, 164);
            this.cmbBx_Year.Name = "cmbBx_Year";
            this.cmbBx_Year.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_Year.TabIndex = 3;
            // 
            // cmbBx_Month
            // 
            this.cmbBx_Month.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBx_Month.FormattingEnabled = true;
            this.cmbBx_Month.Location = new System.Drawing.Point(204, 164);
            this.cmbBx_Month.Name = "cmbBx_Month";
            this.cmbBx_Month.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_Month.TabIndex = 2;
            // 
            // cmbBx_Day
            // 
            this.cmbBx_Day.BackColor = System.Drawing.Color.White;
            this.cmbBx_Day.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBx_Day.FormattingEnabled = true;
            this.cmbBx_Day.Location = new System.Drawing.Point(3, 164);
            this.cmbBx_Day.Name = "cmbBx_Day";
            this.cmbBx_Day.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_Day.TabIndex = 1;
            // 
            // ConfirmAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(536, 658);
            this.Controls.Add(this.pnl_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Body.ResumeLayout(false);
            this.pnl_Body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.ComboBox cmbBx_Year;
        private System.Windows.Forms.ComboBox cmbBx_Month;
        private System.Windows.Forms.ComboBox cmbBx_Day;
        private System.Windows.Forms.Button bttn_Check;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Month;
    }
}

