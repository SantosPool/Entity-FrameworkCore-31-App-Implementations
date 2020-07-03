
using System;
using System.Collections.Generic;


namespace GetData
{
    public class Curso
    {
        public int CursoId{get; set;}
        public string Titulo{get;set;}
        public string Descripcion{get;set;}
        public DateTime FechaPublicacion{get;set;}
        //public byte[] FotoPublicacion{get;set;}
        public Precio PrecioPromocion{get;set;}
        public List<Comentario> ComentarioLista{get;set;}
        public List<CursoInstructor> InstructorLink{get;set;}
    }
}