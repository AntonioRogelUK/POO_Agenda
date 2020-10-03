using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Agenda
{
    public class Agenda
    {
        //variables
        private List<Contacto> variableContactos;

        //propiedades
        public List<Contacto> PropiedadContactos { get { return variableContactos; } }

        //constructor
        public Agenda()
        {
            variableContactos = new List<Contacto>();
        }

        //metodos
        public void AgregarContacto(Contacto parametroContacto) 
        {
            variableContactos.Add(parametroContacto);
        }

        public void EliminarContacto(Contacto parametroContacto) 
        {
            variableContactos.Remove(parametroContacto);
        }
    }
}
