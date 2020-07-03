using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace GetData
{
    class Program
    {
        static void Main(string[] args)
        {
            //111Console.WriteLine("Hola Bienvenido a ASP Net core con React-Hooks");
            using(var db= new AppVentaCursosContext())
            {
                //pide data y no guarda en memeria en entity
                //Devuelve Iquerable
                // var cursos= db.Curso.AsNoTracking();

                // foreach(var curso in cursos)
                //     Console.WriteLine($"{curso.Titulo} ---{curso.Descripcion}");


                // var cursos= db.Curso.Include(p=> p.PrecioPromocion).AsNoTracking();
                // foreach(var curso in cursos)
                //     Console.WriteLine($"{curso.Titulo} ---- {curso.PrecioPromocion.PrecioActual}");

                // var cursos=db.Curso.Include(c=>c.ComentarioLista).AsNoTracking();
                // foreach(var curso in cursos){
                //     Console.WriteLine($"{curso.Titulo}");
                //     foreach(var comentario in curso.ComentarioLista)
                //         Console.WriteLine($"**********{comentario.ComentarioTexto}");
                // }

                var cursos= db.Curso.Include(ci => ci.InstructorLink).ThenInclude(ci => ci.Instructor).AsNoTracking();
                   foreach(var curso in cursos){
                       Console.WriteLine($"{curso.Titulo}");
                       foreach(var inslink in curso.InstructorLink)
                            Console.WriteLine($"*****{inslink.Instructor.Nombre}");
                   } 
            }
        }
    }
}
