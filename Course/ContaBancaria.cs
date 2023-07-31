using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course {
    internal class ContaBancaria {

        private string _nome;
        private string _numeroConta;
        private double _depInicial;
        private double _saldo;
        public string VerDepInicial { get; private set; }

        public ContaBancaria(string nome, string numeroConta, string verDepInicial, double depInicial) {
            _nome = nome;
            _numeroConta = numeroConta;
            _depInicial = depInicial;
            _saldo = 0;
            VerDepInicial = verDepInicial;
        }

        public ContaBancaria() {
            _nome = "Não informado";
            _numeroConta = "Não informado";
            _depInicial = 0;
            _saldo = 0;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public string NumeroConta {
            get { return _numeroConta; }
            set {
                if (value != null && value.Length > 1) {
                    _numeroConta = value;
                }
            }
        }

        public double DepInicial { 
            get { return _depInicial;  }
            set { 
                if (VerDepInicial == "s" && value > 0) {
                    _saldo = value;
                }
            }
        }

        public void Depositar(double deposito) { 
            _saldo += deposito;
        }

        public void Sacar(double saque) { 
            _saldo -= saque + 5;
        }


        public override string ToString() {
            return "Conta: "
                + _numeroConta
                + ", Titular: "
                + _nome
                + ", Saldo: $ "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }





    }
}
