using System.Collections.Generic;
using System.Linq;

namespace GimnasioExamenParcial1
{
    public class GestorDatos
    {
        public List<Instructor> Instructores { get; set; } = new List<Instructor>();
        public List<Clase> Clases { get; set; } = new List<Clase>();
        public List<Participante> Participantes { get; set; } = new List<Participante>();

        // INSERTAR
        public void InsertarInstructor(Instructor i) => Instructores.Add(i);
        public void InsertarClase(Clase c) => Clases.Add(c);
        public void InsertarParticipante(Participante p) => Participantes.Add(p);

        // SELECCIONAR / OBTENER
        public List<Instructor> ObtenerInstructores() => Instructores;
        public List<Clase> ObtenerClases() => Clases;
        public List<Participante> ObtenerParticipantes() => Participantes;

        // ELIMINAR
        public void EliminarInstructor(int id) => Instructores.RemoveAll(i => i.IdInstructor == id);
        public void EliminarClase(int id)
        {
            Clases.RemoveAll(c => c.IdClase == id);
            Participantes.RemoveAll(p => p.IdClase == id); // también elimina participantes asociados
        }
        public void EliminarParticipante(int id) => Participantes.RemoveAll(p => p.IdParticipante == id);

        // UTILIDADES
        public int SiguienteIdInstructor() => (Instructores.Any() ? Instructores.Max(i => i.IdInstructor) + 1 : 1);
        public int SiguienteIdClase() => (Clases.Any() ? Clases.Max(c => c.IdClase) + 1 : 1);
        public int SiguienteIdParticipante() => (Participantes.Any() ? Participantes.Max(p => p.IdParticipante) + 1 : 1);
    }
}
