using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Usuario
    {
        public string Nombre { get; set; }

        public double Saldo { get; set; }

        public Usuario(string nombre, double saldo) {

            this.Nombre = nombre;
            this.Saldo = saldo;

        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine(Nombre + " " + Saldo);
        }

    }
}
