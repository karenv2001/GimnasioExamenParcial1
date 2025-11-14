namespace GimnasioExamenParcial1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.dgvInstructores = new System.Windows.Forms.DataGridView();
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();

            this.txtIdInstructor = new System.Windows.Forms.TextBox();
            this.txtNombreInstructor = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();

            this.txtIdClase = new System.Windows.Forms.TextBox();
            this.txtNombreClase = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtClase_IdInstructor = new System.Windows.Forms.TextBox();

            this.txtIdParticipante = new System.Windows.Forms.TextBox();
            this.txtNombreParticipante = new System.Windows.Forms.TextBox();
            this.txtParticipante_IdClase = new System.Windows.Forms.TextBox();

            this.btnInsertarInstructor = new System.Windows.Forms.Button();
            this.btnEliminarInstructor = new System.Windows.Forms.Button();

            this.btnInsertarClase = new System.Windows.Forms.Button();
            this.btnEliminarClase = new System.Windows.Forms.Button();

            this.btnInsertarParticipante = new System.Windows.Forms.Button();
            this.btnEliminarParticipante = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.SuspendLayout();

            // ---------------- TABLA INSTRUCTORES ----------------
            this.dgvInstructores.Location = new System.Drawing.Point(20, 20);
            this.dgvInstructores.Size = new System.Drawing.Size(400, 150);

            this.txtIdInstructor.Location = new System.Drawing.Point(20, 180);
            this.txtIdInstructor.Size = new System.Drawing.Size(100, 22);

            this.txtNombreInstructor.Location = new System.Drawing.Point(150, 180);
            this.txtNombreInstructor.Size = new System.Drawing.Size(100, 22);

            this.txtEspecialidad.Location = new System.Drawing.Point(280, 180);
            this.txtEspecialidad.Size = new System.Drawing.Size(100, 22);

            this.btnInsertarInstructor.Location = new System.Drawing.Point(20, 210);
            this.btnInsertarInstructor.Size = new System.Drawing.Size(120, 30);
            this.btnInsertarInstructor.Text = "Insertar Instructor";
            this.btnInsertarInstructor.Click += new System.EventHandler(this.btnInsertarInstructor_Click);

            this.btnEliminarInstructor.Location = new System.Drawing.Point(150, 210);
            this.btnEliminarInstructor.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarInstructor.Text = "Eliminar Instructor";
            this.btnEliminarInstructor.Click += new System.EventHandler(this.btnEliminarInstructor_Click);

            // ---------------- TABLA CLASES ----------------
            this.dgvClases.Location = new System.Drawing.Point(20, 260);
            this.dgvClases.Size = new System.Drawing.Size(400, 150);

            this.txtIdClase.Location = new System.Drawing.Point(20, 420);
            this.txtIdClase.Size = new System.Drawing.Size(100, 22);

            this.txtNombreClase.Location = new System.Drawing.Point(150, 420);
            this.txtNombreClase.Size = new System.Drawing.Size(100, 22);

            this.txtHorario.Location = new System.Drawing.Point(280, 420);
            this.txtHorario.Size = new System.Drawing.Size(100, 22);

            this.txtClase_IdInstructor.Location = new System.Drawing.Point(20, 450);
            this.txtClase_IdInstructor.Size = new System.Drawing.Size(100, 22);

            this.btnInsertarClase.Location = new System.Drawing.Point(150, 450);
            this.btnInsertarClase.Size = new System.Drawing.Size(120, 30);
            this.btnInsertarClase.Text = "Insertar Clase";
            this.btnInsertarClase.Click += new System.EventHandler(this.btnInsertarClase_Click);

            this.btnEliminarClase.Location = new System.Drawing.Point(280, 450);
            this.btnEliminarClase.Size = new System.Drawing.Size(120, 30);
            this.btnEliminarClase.Text = "Eliminar Clase";
            this.btnEliminarClase.Click += new System.EventHandler(this.btnEliminarClase_Click);

            // ---------------- TABLA PARTICIPANTES ----------------
            this.dgvParticipantes.Location = new System.Drawing.Point(450, 20);
            this.dgvParticipantes.Size = new System.Drawing.Size(400, 150);

            this.txtIdParticipante.Location = new System.Drawing.Point(450, 180);
            this.txtIdParticipante.Size = new System.Drawing.Size(100, 22);

            this.txtNombreParticipante.Location = new System.Drawing.Point(580, 180);
            this.txtNombreParticipante.Size = new System.Drawing.Size(100, 22);

            this.txtParticipante_IdClase.Location = new System.Drawing.Point(710, 180);
            this.txtParticipante_IdClase.Size = new System.Drawing.Size(100, 22);

            this.btnInsertarParticipante.Location = new System.Drawing.Point(450, 210);
            this.btnInsertarParticipante.Size = new System.Drawing.Size(150, 30);
            this.btnInsertarParticipante.Text = "Insertar Participante";
            this.btnInsertarParticipante.Click += new System.EventHandler(this.btnInsertarParticipante_Click);

            this.btnEliminarParticipante.Location = new System.Drawing.Point(610, 210);
            this.btnEliminarParticipante.Size = new System.Drawing.Size(150, 30);
            this.btnEliminarParticipante.Text = "Eliminar Participante";
            this.btnEliminarParticipante.Click += new System.EventHandler(this.btnEliminarParticipante_Click);

            // ---------------- FORM ----------------
            this.ClientSize = new System.Drawing.Size(900, 520);

            this.Controls.Add(this.dgvInstructores);
            this.Controls.Add(this.dgvClases);
            this.Controls.Add(this.dgvParticipantes);

            this.Controls.Add(this.txtIdInstructor);
            this.Controls.Add(this.txtNombreInstructor);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.btnInsertarInstructor);
            this.Controls.Add(this.btnEliminarInstructor);

            this.Controls.Add(this.txtIdClase);
            this.Controls.Add(this.txtNombreClase);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtClase_IdInstructor);
            this.Controls.Add(this.btnInsertarClase);
            this.Controls.Add(this.btnEliminarClase);

            this.Controls.Add(this.txtIdParticipante);
            this.Controls.Add(this.txtNombreParticipante);
            this.Controls.Add(this.txtParticipante_IdClase);
            this.Controls.Add(this.btnInsertarParticipante);
            this.Controls.Add(this.btnEliminarParticipante);

            this.Text = "Sistema de Gestión de Gimnasio";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstructores;
        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.DataGridView dgvParticipantes;

        private System.Windows.Forms.TextBox txtIdInstructor;
        private System.Windows.Forms.TextBox txtNombreInstructor;
        private System.Windows.Forms.TextBox txtEspecialidad;

        private System.Windows.Forms.TextBox txtIdClase;
        private System.Windows.Forms.TextBox txtNombreClase;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtClase_IdInstructor;

        private System.Windows.Forms.TextBox txtIdParticipante;
        private System.Windows.Forms.TextBox txtNombreParticipante;
        private System.Windows.Forms.TextBox txtParticipante_IdClase;

        private System.Windows.Forms.Button btnInsertarInstructor;
        private System.Windows.Forms.Button btnEliminarInstructor;
        private System.Windows.Forms.Button btnInsertarClase;
        private System.Windows.Forms.Button btnEliminarClase;
        private System.Windows.Forms.Button btnInsertarParticipante;
        private System.Windows.Forms.Button btnEliminarParticipante;
    }
}
