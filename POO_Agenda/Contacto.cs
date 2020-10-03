using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Agenda
{
    public class Contacto
    {
        //variables
        private string variableNombre;
        private string variableTelefonoCelular;
        private string variableTelefonoParticular;
        private string variableCorreoElectronico;
        private DateTime variableFechaRegistro;


        //propiedades
        public string PropiedadNombre { get { return variableNombre; } }
        public string PropiedadTelefonoCelular { get { return variableTelefonoCelular; } }
        public string PropiedadTelefonoParticular { get { return variableTelefonoParticular; } }
        public string PropiedadCorreoElectronico { get { return variableCorreoElectronico; } }
        public DateTime PropiedadFechaRegistro { get { return variableFechaRegistro; } }
        
        //constructor
        public Contacto(string parametroNombre, string parametroTelefonoCelular, 
            string parametroTelefonoParticular, string parametroCorreoElectronico)
        {
            variableNombre = parametroNombre;
            variableTelefonoCelular = parametroTelefonoCelular;
            variableTelefonoParticular = parametroTelefonoParticular;
            variableCorreoElectronico = parametroCorreoElectronico;
            variableFechaRegistro = DateTime.Now;
        }
    }
}
