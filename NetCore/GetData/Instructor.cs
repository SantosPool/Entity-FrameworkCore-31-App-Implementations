using System;
using System.Collections.Generic;
namespace GetData
{
    public class Instructor
    {
        public int InstructorId{get;set;}
        public string Nombre{get;set;}
        public string Apellidos{get;set;}
        public string Grado{get;set;}
        public byte[] FotoPerfil{get;set;}
        public List<CursoInstructor> InstructorLink {get;set;}
    }
}