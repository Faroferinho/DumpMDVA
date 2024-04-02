namespace Beta_MdVA
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(140, 45);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(227, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Confirmar Idade";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Body
            // 
            this.pnl_Body.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Body.BackgroundImage = global::Beta_MdVA.Properties.Resources.Border;
            this.pnl_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Body.Controls.Add(this.pictureBox1);
            this.pnl_Body.Controls.Add(this.lbl_Year);
            this.pnl_Body.Controls.Add(this.lbl_Month);
            this.pnl_Body.Controls.Add(this.lbl_Day);
            this.pnl_Body.Controls.Add(this.bttn_Check);
            this.pnl_Body.Controls.Add(this.cmbBx_Year);
            this.pnl_Body.Controls.Add(this.cmbBx_Month);
            this.pnl_Body.Controls.Add(this.cmbBx_Day);
            this.pnl_Body.Controls.Add(this.lbl_Title);
            this.pnl_Body.ForeColor = System.Drawing.Color.White;
            this.pnl_Body.Location = new System.Drawing.Point(12, 12);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(512, 730);
            this.pnl_Body.TabIndex = 1;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.Location = new System.Drawing.Point(398, 187);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(31, 17);
            this.lbl_Year.TabIndex = 7;
            this.lbl_Year.Text = "Ano";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Month.Location = new System.Drawing.Point(239, 187);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(33, 17);
            this.lbl_Month.TabIndex = 6;
            this.lbl_Month.Text = "Mês";
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Day.Location = new System.Drawing.Point(76, 187);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(27, 17);
            this.lbl_Day.TabIndex = 5;
            this.lbl_Day.Text = "Dia";
            // 
            // bttn_Check
            // 
            this.bttn_Check.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Check.BackgroundImage = global::Beta_MdVA.Properties.Resources.Botão_Vermelho_Teste;
            this.bttn_Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttn_Check.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttn_Check.FlatAppearance.BorderSize = 3;
            this.bttn_Check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bttn_Check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Check.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_Check.Location = new System.Drawing.Point(156, 629);
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
            this.cmbBx_Year.Location = new System.Drawing.Point(353, 207);
            this.cmbBx_Year.Name = "cmbBx_Year";
            this.cmbBx_Year.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_Year.TabIndex = 3;
            // 
            // cmbBx_Month
            // 
            this.cmbBx_Month.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBx_Month.FormattingEnabled = true;
            this.cmbBx_Month.Location = new System.Drawing.Point(199, 207);
            this.cmbBx_Month.Name = "cmbBx_Month";
            this.cmbBx_Month.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_Month.TabIndex = 2;
            // 
            // cmbBx_Day
            // 
            this.cmbBx_Day.BackColor = System.Drawing.Color.White;
            this.cmbBx_Day.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBx_Day.FormattingEnabled = true;
            this.cmbBx_Day.Location = new System.Drawing.Point(40, 207);
            this.cmbBx_Day.Name = "cmbBx_Day";
            this.cmbBx_Day.Size = new System.Drawing.Size(121, 21);
            this.cmbBx_Day.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Beta_MdVA.Properties.Resources.Bipartition_Line;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(25, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ConfirmAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(238)))));
            this.BackgroundImage = global::Beta_MdVA.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(533, 754);
            this.Controls.Add(this.pnl_Body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Body.ResumeLayout(false);
            this.pnl_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

