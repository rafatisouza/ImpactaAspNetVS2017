using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpactaAspNetNet.Frete
{
    public partial class FreteForm : Form
    {
        public FreteForm()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();
            if (erros.Count() == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                                "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calcular()
        {
            var percentual = 0m;
            var valor = Convert.ToDecimal(ValortextBox.Text.Trim().ToUpper());
            var nordeste = new List <string>{"BA", "CE", "AL"};
            switch (UFcomboBox.Text)
            {
                case "SP":
                    percentual = 0.20m;
                    break;
                case "RJ":
                case "ES":
                    percentual = 0.30m;
                    break;
                case "MG":
                    percentual = 0.35m;
                    break;
                case "AM":
                    percentual = 0.6m;
                    break;
                case var uf when nordeste.Contains(uf):
                    percentual = 0.4m;
                    break;
                default:
                    percentual = 0.7m;
                    break;                    
            }
            FretetextBox.Text =  percentual.ToString("p2");
            var valorTotal = Convert.ToDecimal(ValortextBox.Text);
            TotaltextBox.Text = ((1 + percentual) * valorTotal).ToString("c");
        }

        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();
            if (string.IsNullOrEmpty(ClentetextBox.Text.Trim()) )
            {
                erros.Add("Nome cliente obrigatório.");
            }
            if (string.IsNullOrEmpty(ValortextBox.Text.Trim()))
            {
                erros.Add("Valor obrigatório.");
            }
            else if (!decimal.TryParse(ValortextBox.Text.Trim(), out decimal valor))
            {
                var teste = decimal.TryParse(ValortextBox.Text.Trim(), out decimal aa);
                erros.Add("Digite apenas números no campo valor");
            }
            if (UFcomboBox.SelectedIndex == -1)
            {                
                erros.Add("Selecione a UF.");
            }

            return erros;
        }

        private void Limparbutton_Click(object sender, EventArgs e) {
            ValortextBox.Clear();
            FretetextBox.Clear();
            TotaltextBox.Clear();
            UFcomboBox.SelectedIndex = -1;
            ClentetextBox.Clear();
        }
    }
}

