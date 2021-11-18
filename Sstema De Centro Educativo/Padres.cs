using System;
using System.Collections.Generic;
using System.Text;

namespace Sstema_De_Centro_Educativo
{
    class Padres: ICloneable
    {
        public string NOMBRE { get; set; }
        public int TELEFONO { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Documento { get; set; }
        public string CursoAlunmos { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Datos1()
        {
            Console.WriteLine("Datos de los alumnos clonados");
        }

        public void asistencia1()
        {
            Console.WriteLine("Asistencia");
        }
        public void Ayuda1()
        {
            Console.WriteLine("Si necesita ayuda, Comunicate");
        }
    }
}
