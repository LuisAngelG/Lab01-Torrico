using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cliente: Usuario
    {
        public double LitrosCargados { get; set; }

        public Cliente (string nombre, double saldo, double litros): base (nombre, saldo) {

            this.LitrosCargados = litros;
            this.Nombre = nombre;
            this.Saldo = saldo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine(Nombre + " " + Saldo + " " + LitrosCargados);
        }

    }
}
