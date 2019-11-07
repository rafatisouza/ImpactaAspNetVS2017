using System;
using System.Collections.Generic;

namespace Oficina.Dominios
{
    //ToDo: 00 - Classe ou abstração
    public abstract class Veiculo 
    {
        //ToDo: OO - Encapsulamento
        public string Placa {
            get {
                return placa.ToUpper();
            }
            set {
                placa = value.ToUpper();                
            }
        }
        private string placa;
        public Modelo Modelo { get; set; }
        public Cor Cor { get; set; }
        public Combustivel Combustivel { get; set; }
        public Cambio Cambio { get; set; }
        public int Ano { get; set; }
        public string Observacao { get; set; }
        

        protected List<string> ValidarBase() {
            var erros = new List<string>();
            if (string.IsNullOrEmpty(Placa))
            {
                erros.Add("Placa obrigatia");
            }
            if (!Enum.IsDefined(typeof(Cambio), Cambio))
            {
                erros.Add($"O câmbio {Cambio} não é válido");
            }

            return erros;
        }

        public abstract List<string> Validar(); 

    }
}
