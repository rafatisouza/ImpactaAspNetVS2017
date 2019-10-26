using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpactaAspNet.capitulo01.Variaveis
{
    public partial class Form1 : Form
    {
        int x = 32;
        int y = 16;
        int w = 45;
        int z = 32;
        public Form1()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6, c = 10;
            var d = 13;
            //string nome = "Vitor";
            //var endereco = "R. Tal, 45";
            //decimal valor = 20.29M;
            //var aprovado = true;
            //var nascimento = new DateTime(1986,04,30);


            resultadolistBox.Items.Add("a = " + a);
            resultadolistBox.Items.Add(string.Concat("b = ", b));
            resultadolistBox.Items.Add(string.Format("c = {0}", c));
            resultadolistBox.Items.Add($"d = {d}" );
            resultadolistBox.Items.Add($"c * d = {c *d}" );
            resultadolistBox.Items.Add($"c * d = {d / a}");
            resultadolistBox.Items.Add($"d modulo a = {d % a} ");


            //MessageBox.Show(nascimento.ToString());

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            x -= 3;
            resultadolistBox.Items.Add($"x = {x}");
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;
            a = 5;
            resultadolistBox.Items.Add("Explo de pré-incremento");
            resultadolistBox.Items.Add($"a = {a}");
            resultadolistBox.Items.Add($"2 ++a = {2 + ++a}");
            

            a = 5;
            resultadolistBox.Items.Add("Explo de pós-incremento");
            resultadolistBox.Items.Add($"2 + a++ = {2 + a++}");
            resultadolistBox.Items.Add($"a = {a}");


        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirItens();
            resultadolistBox.Items.Add($"w <= x + {x < y}");
            resultadolistBox.Items.Add($"x == z + {x == z}");
            resultadolistBox.Items.Add($"x != z + {x != z}");

        }

        private void ExibirItens()
        {
            resultadolistBox.Items.Add("x = " + x);
            resultadolistBox.Items.Add("y = " + y);
            resultadolistBox.Items.Add("w = " + w);
            resultadolistBox.Items.Add("z = " + z);
            resultadolistBox.Items.Add(new string('-', 50));
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirItens();

            resultadolistBox.Items.Add($"w <= x || y == 16 + {w <= x || y == 16}");
            resultadolistBox.Items.Add($"x == z && z = x = + {x == z && z != x}");
            resultadolistBox.Items.Add($"!(y > w) = + {!(y > w)}");

        }

        //private void TernarioToolStripMenuItem_Click(object sender, EventArgs e) {
        //    int ano;

        //    ano = 2014;
        //    resultadolistBox.Items
        //        .Add($"O ano {ano} é bissexto? {(ano % 4 == 0 ? "Sim" : "Não")}");
        //}

        private void TernarioToolStripMenuItem_Click_1(object sender, EventArgs e) {
            int ano;

            ano = 2014;
            resultadolistBox.Items
                .Add($"O ano {ano} é bissexto? {(ano % 4 == 0 ? "Sim" : "Não")}");


            ano = 2020;
            resultadolistBox.Items
                .Add($"O ano {ano} é bissexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}");

        }
    }
}
