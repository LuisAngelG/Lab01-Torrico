using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Grifos
    {
        public List<Usuario> Grifo { get; set; }

        public Grifos(List<Usuario> a) {
            Grifo = a;
        }

        private int count = 0;

        public void MostrarUsuarios(List<Usuario> usuarios) {

            foreach (var usuario in usuarios)
            {
                Console.WriteLine(count++);

                usuario.MostrarInformacion();
            }

            
                       
        }

    }
}
