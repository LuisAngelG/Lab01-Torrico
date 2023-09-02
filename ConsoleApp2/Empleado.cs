using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Empleado: Usuario
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, double saldo, double sueldo): base(nombre, saldo) {
            this.Nombre = nombre;
            this.Saldo = saldo;
            this.Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine(Nombre + " " + Saldo + " " + Sueldo);
        }
    }
}
