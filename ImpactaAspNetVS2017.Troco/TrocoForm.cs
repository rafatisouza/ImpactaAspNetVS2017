using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpactaAspNetVS2017.Troco {
    public partial class TrocoForm : Form {
        public TrocoForm() {
            InitializeComponent();
        }

        private void TrocoForm_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void CalcularButton_Click(object sender, EventArgs e) {
            decimal valorCompra, valorPago;
            valorPago = decimal.Parse(ValorPagoTextBox.Text);
            valorCompra = decimal.Parse(ValorCompraTextBox.Text);
            var troco = (valorPago - valorCompra);
            TrocoTextBox.Text = troco.ToString("c2");

            var moedas = new decimal[] {1, 0.5m, 0.25m, 0.10m, 0.05m, 0.01m};
            for (int i = 0; i < moedas.Length; i++) {
                MoedaslistView.Items[i].Text = "0";
                if (troco >= moedas[i]) {                                    
                    MoedaslistView.Items[i].Text = Math.Floor(troco/moedas[i]).ToString();                    
                }
                troco %= moedas[i];
            }
            //var moeda1Real = (int)(troco/1);
            //troco %= 1;

            //var moeda050 = (int)(troco / 0.5m);
            //troco %= 0.5m;

            //var moeda25 = (int)(troco / 0.25m);
            //troco %= 0.25m;

            //var moeda10 = (int)(troco / 0.10m);
            //troco %= 0.10m;

            //var moeda005 = (int)(troco / 0.05m);
            //troco %= 0.5m;

            //var moeda001 = (int)(troco / 0.01m);
            //troco %= 0.1m;

            //Todo: refatorar para usar vetor e for.
            //MoedaslistView.Items[0].Text = moeda1Real.ToString();
            //MoedaslistView.Items[1].Text = moeda050.ToString();
            //MoedaslistView.Items[2].Text = moeda25.ToString();
            //MoedaslistView.Items[3].Text = moeda10.ToString();
            //MoedaslistView.Items[4].Text = moeda005.ToString();
            //MoedaslistView.Items[5].Text = moeda001.ToString();

        }
    }
}
