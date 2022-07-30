using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AporteApp2
{
    public class dispositi : sujeto
    {
        protected string _descripcion;
        //si es celular o table
        protected string _modelo;
        protected string _orden;

        public string descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
                this.notificar();
            }
        }

        public string modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                _modelo = value;
                this.notificar();
            }
        }

        public string orden
        {
            get
            {
                return _orden;
            }
            set
            {
                _orden = value;
                this.notificar();
            }
        }
    }
}