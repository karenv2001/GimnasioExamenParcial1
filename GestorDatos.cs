using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioExamenParcial1
{
    public class GestorDatos
    {
        public List<Instructor> Instructores { get; set; } = new List<Instructor>();
        public List<Clase> Clases { get; set; } = new List<Clase>();
        public List<Participante> Participantes { get; set; } = new List<Participante>();

        // INSERTAR
        public void InsertarInstructor(Instructor i)
        {
            Instructores.Add(i);
        }

        public void InsertarClase(Clase c)
        {
            Clases.Add(c);
        }

        public void InsertarParticipante(Participante p)
        {
            Participantes.Add(p);
        }

        // SELECCIONAR
        public List<Instructor> ObtenerInstructores()
        {
            return Instructores;
        }

        public List<Clase> ObtenerClases()
        {
            return Clases;
        }

        public List<Participante> ObtenerParticipantes()
        {
            return Participantes;
        }

        // ELIMINAR
        public void EliminarInstructor(int id)
        {
            Instructores.RemoveAll(i => i.IdInstructor == id);
        }

        public void EliminarClase(int id)
        {
            Clases.RemoveAll(c => c.IdClase == id);
            Participantes.RemoveAll(p => p.IdClase == id); // elimina participantes asociados
        }

        public void EliminarParticipante(int id)
        {
            Participantes.RemoveAll(p => p.IdParticipante == id);
        }
    }
}
