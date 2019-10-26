namespace ImpactaAspNetVS2017.Troco {
    partial class TrocoForm {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocoForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.ValorCompraTextBox = new System.Windows.Forms.TextBox();
            this.ValorPagoTextBox = new System.Windows.Forms.TextBox();
            this.TrocoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moedasImageList = new System.Windows.Forms.ImageList(this.components);
            this.MoedaslistView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.TrocoTextBox);
            this.groupBox1.Controls.Add(this.ValorPagoTextBox);
            this.groupBox1.Controls.Add(this.ValorCompraTextBox);
            this.groupBox1.Controls.Add(this.CalcularButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da &compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor &pago";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Troco";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(9, 118);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(291, 20);
            this.CalcularButton.TabIndex = 6;
            this.CalcularButton.Text = "C&alcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // ValorCompraTextBox
            // 
            this.ValorCompraTextBox.Location = new System.Drawing.Point(96, 16);
            this.ValorCompraTextBox.Name = "ValorCompraTextBox";
            this.ValorCompraTextBox.Size = new System.Drawing.Size(169, 20);
            this.ValorCompraTextBox.TabIndex = 1;
            // 
            // ValorPagoTextBox
            // 
            this.ValorPagoTextBox.Location = new System.Drawing.Point(96, 49);
            this.ValorPagoTextBox.Name = "ValorPagoTextBox";
            this.ValorPagoTextBox.Size = new System.Drawing.Size(169, 20);
            this.ValorPagoTextBox.TabIndex = 3;
            // 
            // TrocoTextBox
            // 
            this.TrocoTextBox.Location = new System.Drawing.Point(96, 82);
            this.TrocoTextBox.Name = "TrocoTextBox";
            this.TrocoTextBox.ReadOnly = true;
            this.TrocoTextBox.Size = new System.Drawing.Size(169, 20);
            this.TrocoTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.MoedaslistView);
            this.groupBox2.Location = new System.Drawing.Point(325, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moedas";
            // 
            // moedasImageList
            // 
            this.moedasImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("moedasImageList.ImageStream")));
            this.moedasImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.moedasImageList.Images.SetKeyName(0, "1.png");
            this.moedasImageList.Images.SetKeyName(1, "5.png");
            this.moedasImageList.Images.SetKeyName(2, "10.png");
            this.moedasImageList.Images.SetKeyName(3, "25.png");
            this.moedasImageList.Images.SetKeyName(4, "50.png");
            this.moedasImageList.Images.SetKeyName(5, "100.png");
            // 
            // MoedaslistView
            // 
            this.MoedaslistView.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 5;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 4;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 3;
            listViewItem4.Checked = true;
            listViewItem4.StateImageIndex = 2;
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 1;
            listViewItem6.StateImageIndex = 0;
            this.MoedaslistView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.MoedaslistView.LargeImageList = this.moedasImageList;
            this.MoedaslistView.Location = new System.Drawing.Point(3, 16);
            this.MoedaslistView.Name = "MoedaslistView";
            this.MoedaslistView.Size = new System.Drawing.Size(457, 406);
            this.MoedaslistView.StateImageList = this.moedasImageList;
            this.MoedaslistView.TabIndex = 0;
            this.MoedaslistView.UseCompatibleStateImageBehavior = false;
            // 
            // TrocoForm
            // 
            this.AcceptButton = this.CalcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrocoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrocoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TrocoTextBox;
        private System.Windows.Forms.TextBox ValorPagoTextBox;
        private System.Windows.Forms.TextBox ValorCompraTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList moedasImageList;
        private System.Windows.Forms.ListView MoedaslistView;
    }
}

