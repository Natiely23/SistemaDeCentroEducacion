using System;
using System.Collections.Generic;
using System.Text;

namespace Sstema_De_Centro_Educativo
{
    class Alumnos : ICloneable
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Semestre { get; set; }
        public string Aula { get; set; }
        public int Telefono { get; set; }
        public Padres NOMBRE { get; set; }
        public Padres TELEFONO { get; set; }

        public Padres papa;

        public Alumnos()
        {
            papa = new Padres();
        }

        public object Clone()
        {
            Alumnos clonado = this.MemberwiseClone() as Alumnos;
            Padres padre = new Padres();
            padre.NOMBRE = this.papa.NOMBRE;
            padre.TELEFONO = this.papa.TELEFONO;
            clonado.papa = padre;
            return clonado;
        }

        public void Datos()
        {
            Console.WriteLine("Datos de los alumnos clonados");
        }
       
        public void asistencia()
        {
            Console.WriteLine("Asistemcia de los alumnos");
        }
        public void Ayuda()
        {
            Console.WriteLine("Si necesita ayuda, comunicate con la universidad");
        }

      
    }
}
