namespace ImpactaAspNetNet.Frete
{
    partial class FreteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClentetextBox = new System.Windows.Forms.TextBox();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.FretetextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.UFcomboBox = new System.Windows.Forms.ComboBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.Limparbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Frete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // ClentetextBox
            // 
            this.ClentetextBox.Location = new System.Drawing.Point(58, 9);
            this.ClentetextBox.Name = "ClentetextBox";
            this.ClentetextBox.Size = new System.Drawing.Size(264, 20);
            this.ClentetextBox.TabIndex = 1;
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(58, 40);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(121, 20);
            this.ValortextBox.TabIndex = 3;
            // 
            // FretetextBox
            // 
            this.FretetextBox.Location = new System.Drawing.Point(58, 99);
            this.FretetextBox.Name = "FretetextBox";
            this.FretetextBox.ReadOnly = true;
            this.FretetextBox.Size = new System.Drawing.Size(121, 20);
            this.FretetextBox.TabIndex = 7;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(58, 130);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(121, 20);
            this.TotaltextBox.TabIndex = 9;
            // 
            // UFcomboBox
            // 
            this.UFcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UFcomboBox.FormattingEnabled = true;
            this.UFcomboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "AM",
            "Outros"});
            this.UFcomboBox.Location = new System.Drawing.Point(58, 66);
            this.UFcomboBox.Name = "UFcomboBox";
            this.UFcomboBox.Size = new System.Drawing.Size(121, 21);
            this.UFcomboBox.TabIndex = 5;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Calcularbutton.Location = new System.Drawing.Point(58, 156);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(121, 23);
            this.Calcularbutton.TabIndex = 10;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Limparbutton
            // 
            this.Limparbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Limparbutton.Location = new System.Drawing.Point(58, 185);
            this.Limparbutton.Name = "Limparbutton";
            this.Limparbutton.Size = new System.Drawing.Size(121, 23);
            this.Limparbutton.TabIndex = 11;
            this.Limparbutton.Text = "Limpar";
            this.Limparbutton.UseVisualStyleBackColor = true;
            this.Limparbutton.Click += new System.EventHandler(this.Limparbutton_Click);
            // 
            // FreteForm
            // 
            this.AcceptButton = this.Calcularbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Limparbutton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limparbutton);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.UFcomboBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.FretetextBox);
            this.Controls.Add(this.ValortextBox);
            this.Controls.Add(this.ClentetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FreteForm";
            this.Text = "Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClentetextBox;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.TextBox FretetextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.ComboBox UFcomboBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Button Limparbutton;
    }
}

