using System;
using System.IO;
namespace Sstema_De_Centro_Educativo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CLASE PADRE
            Console.WriteLine("-----------CLON SUPERFICIAL--------------");
            Padres padres = new Padres();
            padres.NOMBRE = "Natiely";
            padres.Apellido = "Lara";
            padres.CursoAlunmos = "Tercero de bachiller";
            Console.WriteLine("DATOS ORIGINALES");
            Console.WriteLine(" Nombre: " + padres.NOMBRE);
            Console.WriteLine(" Apellido: " + padres.Apellido);
            Console.WriteLine(" Curso Alumnos: " + padres.CursoAlunmos);
            Console.WriteLine();

           
            Padres padreclon = padres.Clone() as Padres;
            padreclon.NOMBRE = "Nayely";
            padreclon.Apellido = "Cabrera";
            padreclon.CursoAlunmos = "Octavo de bachiller";
            Console.WriteLine("DATOS FALSOS");
            Console.WriteLine(" Nombre: " + padres.NOMBRE);
            Console.WriteLine(" Apellido: " + padres.Apellido);
            Console.WriteLine(" Curso Alumnos: " + padres.CursoAlunmos);
            Console.WriteLine();

            Padres padreclon11 = padres.Clone() as Padres;
            padreclon11.NOMBRE = "Adeiny";
            padreclon11.Apellido = "Sosa";
            padreclon11.CursoAlunmos = "Universitaria";
            Console.WriteLine("DATOS FALSOS 0.1");
            Console.WriteLine(" Nombre: " + padres.NOMBRE);
            Console.WriteLine(" Apellido: " + padres.Apellido);
            Console.WriteLine(" Curso Alumnos: " + padres.CursoAlunmos);
            Console.WriteLine();

            Padres padreclon22 = padres.Clone() as Padres;
            padreclon22.NOMBRE = "Javier";
            padreclon22.Apellido = "Tejeda";
            padreclon22.CursoAlunmos = "Universitari0";
            Console.WriteLine("DATOS FALSOS 0.2");
            Console.WriteLine(" Nombre: " + padres.NOMBRE);
            Console.WriteLine(" Apellido: " + padres.Apellido);
            Console.WriteLine(" Curso Alumnos: " + padres.CursoAlunmos);
            padres.Datos1();
            Console.WriteLine();



            Console.WriteLine("-----------CLON PROFUNDO--------------");
            Alumnos alumnos = new Alumnos(){ Nombre = "Alaia"};
            alumnos.papa = new Padres();
            alumnos.papa.NOMBRE = "Alvaro";
            alumnos.papa.TELEFONO = 829265;
            alumnos.Semestre = "Quinto cuatrimestre";
            Console.WriteLine();
            Alumnos alumnosClon = alumnos.Clone() as Alumnos;
            alumnosClon.papa = new Padres();
            alumnosClon.papa.NOMBRE = "Yael";
            alumnosClon.papa.TELEFONO = 80956235;
            alumnosClon.Semestre = "Primero";
            Console.WriteLine();
            Alumnos alumnosClon11 = alumnos.Clone() as Alumnos;
            alumnosClon11.papa = new Padres();
            alumnosClon11.papa.NOMBRE = "Elian";
            alumnosClon11.papa.TELEFONO = 5555555;
            alumnosClon11.Semestre = "Bachiller";
            Console.WriteLine();
            Alumnos alumnosClon22 = alumnos.Clone() as Alumnos;
            alumnosClon22.papa = new Padres();
            alumnosClon22.papa.NOMBRE = "Nicolas";
            alumnosClon22.papa.TELEFONO = 232323;
            alumnosClon22.Semestre = "Primaria";
            Console.WriteLine();

            Console.WriteLine("ALUMNO ORIGINAL:  " +alumnos.papa.NOMBRE);
            Console.WriteLine("ALUMNO CLONADO: " +alumnosClon.papa.TELEFONO);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Nombre);
            Console.WriteLine("ALUMNO CLONADO: " + alumnosClon.papa.NOMBRE);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.TELEFONO);
            Console.WriteLine("ALUMNO CLONADO: " + alumnosClon.Semestre);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Semestre);
            Console.WriteLine();


            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.NOMBRE);
            Console.WriteLine("ALUMNO CLONADO: " + alumnosClon11.papa.TELEFONO);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Nombre);
            Console.WriteLine("ALUMNO CLONADO: " + alumnosClon11.papa.NOMBRE);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.TELEFONO);
            Console.WriteLine("ALUMNO CLONADO: " + alumnosClon11.Semestre);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Semestre);
            Console.WriteLine();

            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.NOMBRE);
            Console.WriteLine("ALUMNO CLONADO: " + alumnosClon22.papa.TELEFONO);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Nombre);
            Console.WriteLine("ALUMNO CLONADO: " + alumnosClon22.papa.NOMBRE);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.TELEFONO);
            Console.WriteLine("ALUMNO CLONADO: " + alumnosClon22.Semestre);
            Console.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Semestre);
            alumnos.Datos();


            TextWriter archivo;

            archivo = new StreamWriter("archivo.txt");
            archivo.WriteLine("-----------CLON SUPERFICIAL--------------");
            archivo.WriteLine("DATOS ORIGINALES");
            archivo.WriteLine(" Nombre: " + padres.NOMBRE);
            archivo.WriteLine(" Apellido: " + padres.Apellido);
            archivo.WriteLine(" Curso Alumnos: " + padres.CursoAlunmos);
            archivo.WriteLine();

            archivo.WriteLine("DATOS FALSOS");
            archivo.WriteLine(" Nombre: " + padres.NOMBRE);
            archivo.WriteLine(" Apellido: " + padres.Apellido);
            archivo.WriteLine(" Curso Alumnos: " + padres.CursoAlunmos);
            archivo.WriteLine();

            archivo.WriteLine("DATOS FALSOS 0.1");
            archivo.WriteLine(" Nombre: " + padres.NOMBRE);
            archivo.WriteLine(" Apellido: " + padres.Apellido);
            archivo.WriteLine(" Curso Alumnos: " + padres.CursoAlunmos);
            archivo.WriteLine();

            archivo.WriteLine("DATOS FALSOS 0.2");
            archivo.WriteLine(" Nombre: " + padres.NOMBRE);
            archivo.WriteLine(" Apellido: " + padres.Apellido);
            archivo.WriteLine(" Curso Alumnos: " + padres.CursoAlunmos);
            archivo.WriteLine();


            archivo.WriteLine("-----------CLON PROFUNDO--------------");
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.NOMBRE);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon.papa.TELEFONO);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Nombre);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon.papa.NOMBRE);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.TELEFONO);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon.Semestre);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Semestre);
            archivo.WriteLine();


            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.NOMBRE);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon11.papa.TELEFONO);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Nombre);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon11.papa.NOMBRE);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.TELEFONO);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon11.Semestre);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Semestre);
            archivo.WriteLine();

            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.NOMBRE);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon22.papa.TELEFONO);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Nombre);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon22.papa.NOMBRE);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.papa.TELEFONO);
            archivo.WriteLine("ALUMNO CLONADO: " + alumnosClon22.Semestre);
            archivo.WriteLine("ALUMNO ORIGINAL:  " + alumnos.Semestre);

            archivo.Close();

      

            Console.WriteLine("Se ha guardado los archivos");
            Console.ReadKey();
        }
    }
}
