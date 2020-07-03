namespace GetData
{
    public class Comentario
    {
        public int ComentarioId{get;set;}
        public string Alumno{get;set;}
        public int puntaje {get;set;}
        public string ComentarioTexto{get;set;}
        public int CursoId{get;set;}
        public Curso Curso{get;set;}
    }
}