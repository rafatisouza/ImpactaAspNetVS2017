using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Dominios
{
    public class Frete
    {
        private Cliente cliente;
        private UF sP;
        private int v;

        public Frete(Cliente cliente, UF sP, int v)
        {
            this.cliente = cliente;
            this.sP = sP;
            this.v = v;
        }

        public Frete(Cliente cliente, decimal valorProduto, UF uF)
        {
            Cliente = cliente;
            ValorProduto = valorProduto;
            UF = uF;            
            Calcular();
        }

        public Cliente Cliente{ get; set; }
        public decimal ValorProduto { get; set; }
        public UF UF { get; set; }
        public decimal ValorFrete { get; private set; }
        public decimal ValorTotal { get; private set; }

        private void Calcular()
        {
            //switch (UF)
            //{
            //    case UF.SP:
            //        break;
            //    case UF.MG:
            //        break;
            //    case UF.RJ:
            //        break;
            //    case UF.AM:
            //        break;
            //    case UF.Outros:
            //        break;
            //    default:
            //        break;
            //}

            switch (UF.ToString().ToUpper())
            {
                case "SP":
                    ValorFrete = 0.20m;
                    break;
                case "RJ":
                case "ES":
                    ValorFrete = 0.30m;
                    break;
                case "MG":
                    ValorFrete = 0.35m;
                    break;
                case "AM":
                    ValorFrete = 0.6m;
                    break;

                default:
                    ValorFrete = 0.7m;
                    break;
            }
           
            ValorTotal = ((1 + ValorFrete) * ValorProduto);
        }

    }
}
