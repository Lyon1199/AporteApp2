using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteApp2
{
    public class reparar : Observador
    {
        protected dispositi dispositi;
        protected string soporte = "";

        public reparar(dispositi dispositivos)
        {
            this.dispositi = dispositivos;
            dispositivos.agrega(this);
            actualizacion();
        }

        protected void actualizacion()
        {
            soporte = "Descripción " + dispositi.descripcion +
            " orden: " + dispositi.orden;
            _ = "modelo" + dispositi.modelo;


        }

        public void actualiza()
        {
            actualizacion();
            this.rehacer();
        }

        public void rehacer()
        {
            Console.WriteLine(soporte);
        }
    }
}