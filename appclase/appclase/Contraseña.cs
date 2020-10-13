using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appclase
{
    class Contraseña
    {
        //variables
        string pin;
        string usuario;


        public string Pin
        {
            get
            { 
                return pin;
            }
            set 
            { 
                pin = value; 
            }
        }
        public string Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }


        //constructores 
        public Contraseña()
        {
            pin = "";
            usuario = "";
        }
        public Contraseña(string pin, string usuario)
        {
            this.pin = pin;
            this.usuario = usuario;
        }

        public override string ToString()
        {
            return "Pin" + pin + "usuario" + usuario;
        }



    }
}
