using System;
using System.Linq;
using System.Windows.Forms;

namespace GimnasioExamenParcial1
{
    public partial class Form1 : Form
    {
        private readonly GestorDatos gestor = new GestorDatos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Precarga de ejemplo (sólo si no hay instructores)
            if (!gestor.Instructores.Any())
            {
                gestor.InsertarInstructor(new Instructor { IdInstructor = 1, Nombre = "Carlos Ruiz", Especialidad = "Crossfit" });
                gestor.InsertarInstructor(new Instructor { IdInstructor = 2, Nombre = "María López", Especialidad = "Yoga" });
                gestor.InsertarInstructor(new Instructor { IdInstructor = 3, Nombre = "Andrea Torres", Especialidad = "Zumba" });
            }

            ActualizarTablas();
        }

        private void ActualizarTablas()
        {
            // Instructores
            dgvInstructores.DataSource = null;
            dgvInstructores.DataSource = gestor.ObtenerInstructores()
                .Select(i => new { i.IdInstructor, i.Nombre, i.Especialidad })
                .ToList();

            // Clases (mostrar nombre del instructor también)
            dgvClases.DataSource = null;
            var clasesTabla = from c in gestor.ObtenerClases()
                              join ins in gestor.ObtenerInstructores() on c.IdInstructor equals ins.IdInstructor into ii
                              from ins in ii.DefaultIfEmpty()
                              select new
                              {
                                  c.IdClase,
                                  c.Nombre,
                                  c.Horario,
                                  IdInstructor = c.IdInstructor,
                                  InstructorNombre = ins != null ? ins.Nombre : "(sin instructor)"
                              };
            dgvClases.DataSource = clasesTabla.ToList();

            // Participantes (mostrar nombre de la clase)
            dgvParticipantes.DataSource = null;
            var partTabla = from p in gestor.ObtenerParticipantes()
                            join c in gestor.ObtenerClases() on p.IdClase equals c.IdClase into cc
                            from c in cc.DefaultIfEmpty()
                            select new
                            {
                                p.IdParticipante,
                                p.Nombre,
                                p.IdClase,
                                ClaseNombre = c != null ? c.Nombre : "(sin clase)"
                            };
            dgvParticipantes.DataSource = partTabla.ToList();
        }

        // ---------- INSTRUCTORES ----------
        private void btnInsertarInstructor_Click(object sender, EventArgs e)
        {
            // Si el ID está vacío, se autogenera; si no, se valida número y duplicado
            int id;
            if (string.IsNullOrWhiteSpace(txtIdInstructor.Text))
            {
                id = gestor.SiguienteIdInstructor();
            }
            else if (!int.TryParse(txtIdInstructor.Text.Trim(), out id))
            {
                MessageBox.Show("ID Instructor inválido (debe ser número) o vacío para autogenerar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreInstructor.Text))
            {
                MessageBox.Show("Ingrese el nombre del instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gestor.Instructores.Any(i => i.IdInstructor == id))
            {
                MessageBox.Show("Ya existe un instructor con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevo = new Instructor
            {
                IdInstructor = id,
                Nombre = txtNombreInstructor.Text.Trim(),
                Especialidad = txtEspecialidad.Text.Trim()
            };

            gestor.InsertarInstructor(nuevo);
            LimpiarCamposInstructor();
            ActualizarTablas();
        }

        private void btnEliminarInstructor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdInstructor.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un ID válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gestor.EliminarInstructor(id);
            LimpiarCamposInstructor();
            ActualizarTablas();
        }

        private void LimpiarCamposInstructor()
        {
            txtIdInstructor.Clear();
            txtNombreInstructor.Clear();
            txtEspecialidad.Clear();
        }

        // ---------- CLASES ----------
        private void btnInsertarClase_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtIdClase.Text))
            {
                id = gestor.SiguienteIdClase();
            }
            else if (!int.TryParse(txtIdClase.Text.Trim(), out id))
            {
                MessageBox.Show("ID Clase inválido (debe ser número) o vacío para autogenerar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreClase.Text))
            {
                MessageBox.Show("Ingrese el nombre de la clase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtClase_IdInstructor.Text.Trim(), out int idInstructor))
            {
                MessageBox.Show("ID Instructor inválido. Debe indicar un ID numérico del instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!gestor.Instructores.Any(i => i.IdInstructor == idInstructor))
            {
                MessageBox.Show("No existe un instructor con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gestor.Clases.Any(c => c.IdClase == id))
            {
                MessageBox.Show("Ya existe una clase con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevaClase = new Clase
            {
                IdClase = id,
                Nombre = txtNombreClase.Text.Trim(),
                Horario = txtHorario.Text.Trim(),
                IdInstructor = idInstructor
            };

            gestor.InsertarClase(nuevaClase);
            LimpiarCamposClase();
            ActualizarTablas();
        }

        private void btnEliminarClase_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdClase.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un ID de clase válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gestor.EliminarClase(id);
            LimpiarCamposClase();
            ActualizarTablas();
        }

        private void LimpiarCamposClase()
        {
            txtIdClase.Clear();
            txtNombreClase.Clear();
            txtHorario.Clear();
            txtClase_IdInstructor.Clear();
        }

        // ---------- PARTICIPANTES ----------
        private void btnInsertarParticipante_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtIdParticipante.Text))
            {
                id = gestor.SiguienteIdParticipante();
            }
            else if (!int.TryParse(txtIdParticipante.Text.Trim(), out id))
            {
                MessageBox.Show("ID Participante inválido (debe ser número) o vacío para autogenerar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreParticipante.Text))
            {
                MessageBox.Show("Ingrese el nombre del participante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtParticipante_IdClase.Text.Trim(), out int idClase))
            {
                MessageBox.Show("ID Clase inválido para participante. Debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!gestor.Clases.Any(c => c.IdClase == idClase))
            {
                MessageBox.Show("No existe una clase con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gestor.Participantes.Any(p => p.IdParticipante == id))
            {
                MessageBox.Show("Ya existe un participante con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoPart = new Participante
            {
                IdParticipante = id,
                Nombre = txtNombreParticipante.Text.Trim(),
                IdClase = idClase
            };

            gestor.InsertarParticipante(nuevoPart);
            LimpiarCamposParticipante();
            ActualizarTablas();
        }

        private void btnEliminarParticipante_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdParticipante.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un ID de participante válido para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            gestor.EliminarParticipante(id);
            LimpiarCamposParticipante();
            ActualizarTablas();
        }

        private void LimpiarCamposParticipante()
        {
            txtIdParticipante.Clear();
            txtNombreParticipante.Clear();
            txtParticipante_IdClase.Clear();
        }

        private void txtParticipante_IdClase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
