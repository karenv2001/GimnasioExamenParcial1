using System;
using System.Linq;
using System.Windows.Forms;

namespace GimnasioExamenParcial1
{
    public partial class Form1 : Form
    {
        GestorDatos gestor = new GestorDatos();

        public Form1()
        {
            InitializeComponent();
            ActualizarTablas();
        }

        private void ActualizarTablas()
        {
            dgvInstructores.DataSource = null;
            dgvClases.DataSource = null;
            dgvParticipantes.DataSource = null;

            dgvInstructores.DataSource = gestor.ObtenerInstructores().ToList();
            dgvClases.DataSource = gestor.ObtenerClases().ToList();
            dgvParticipantes.DataSource = gestor.ObtenerParticipantes().ToList();
        }

        // ----------- INSTRUCTORES -------------
        private void btnInsertarInstructor_Click(object sender, EventArgs e)
        {
            gestor.InsertarInstructor(new Instructor
            {
                IdInstructor = int.Parse(txtIdInstructor.Text),
                Nombre = txtNombreInstructor.Text,
                Especialidad = txtEspecialidad.Text
            });

            ActualizarTablas();
        }

        private void btnEliminarInstructor_Click(object sender, EventArgs e)
        {
            gestor.EliminarInstructor(int.Parse(txtIdInstructor.Text));
            ActualizarTablas();
        }

        // ------------- CLASES -----------------
        private void btnInsertarClase_Click(object sender, EventArgs e)
        {
            gestor.InsertarClase(new Clase
            {
                IdClase = int.Parse(txtIdClase.Text),
                Nombre = txtNombreClase.Text,
                Horario = txtHorario.Text,
                IdInstructor = int.Parse(txtClase_IdInstructor.Text)
            });

            ActualizarTablas();
        }

        private void btnEliminarClase_Click(object sender, EventArgs e)
        {
            gestor.EliminarClase(int.Parse(txtIdClase.Text));
            ActualizarTablas();
        }

        // ----------- PARTICIPANTES ------------
        private void btnInsertarParticipante_Click(object sender, EventArgs e)
        {
            gestor.InsertarParticipante(new Participante
            {
                IdParticipante = int.Parse(txtIdParticipante.Text),
                Nombre = txtNombreParticipante.Text,
                IdClase = int.Parse(txtParticipante_IdClase.Text)
            });

            ActualizarTablas();
        }

        private void btnEliminarParticipante_Click(object sender, EventArgs e)
        {
            gestor.EliminarParticipante(int.Parse(txtIdParticipante.Text));
            ActualizarTablas();
        }
    }
}
