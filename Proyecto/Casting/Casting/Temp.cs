using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using System.Drawing;

namespace Casting
{
   public class Temp
    {
     
      public String Nombre;
      public String Apellido;
        String FechaNac;
        String Cedula;
        String Tel;
        String Dir;
        String Tipo;

        public Temp() { }
        public Temp(String Nombre, String Apellido, String FechaNac, String Cedula, String Tel, String Dir, String Tipo) { 
            
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaNac = FechaNac;
            this.Cedula = Cedula;
            this.Tel = Tel;
            this.Dir = Dir;
            this.Tipo = Tipo;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public void setNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public String getApellido()
        {
            return Apellido;
        }

        public void setApellido(String Apellido)
        {
            this.Apellido = Apellido;
        }

        public String getFechaNac()
        {
            return FechaNac;
        }

        public void setFechaNac(String FechaNac)
        {
            this.FechaNac = FechaNac;
        }

        public String getCedula()
        {
            return Cedula;
        }

        public void setCedula(String Cedula)
        {
            this.Cedula = Cedula;
        }

        public String getTel()
        {
            return Tel;
        }

        public void setTel(String Tel)
        {
            this.Tel = Tel;
        }

        public String getDir()
        {
            return Dir;
        }

        public void setDir(String Dir)
        {
            this.Dir = Dir;
        }

        public String getTipo()
        {
            return Tipo;
        }

        public void setTipo(String Tipo)
        {
            this.Tipo = Tipo;
        }
        
        
    }
}
