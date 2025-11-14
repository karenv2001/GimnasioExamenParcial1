namespace GimnasioExamenParcial1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvInstructores;
        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.DataGridView dgvParticipantes;

        private System.Windows.Forms.Label lblInsId;
        private System.Windows.Forms.Label lblInsNombre;
        private System.Windows.Forms.Label lblInsEsp;
        private System.Windows.Forms.TextBox txtIdInstructor;
        private System.Windows.Forms.TextBox txtNombreInstructor;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Button btnInsertarInstructor;
        private System.Windows.Forms.Button btnEliminarInstructor;

        private System.Windows.Forms.Label lblClaseId;
        private System.Windows.Forms.Label lblClaseNombre;
        private System.Windows.Forms.Label lblClaseHorario;
        private System.Windows.Forms.Label lblClaseInstructorId;
        private System.Windows.Forms.TextBox txtIdClase;
        private System.Windows.Forms.TextBox txtNombreClase;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtClase_IdInstructor;
        private System.Windows.Forms.Button btnInsertarClase;
        private System.Windows.Forms.Button btnEliminarClase;

        private System.Windows.Forms.Label lblPartId;
        private System.Windows.Forms.Label lblPartNombre;
        private System.Windows.Forms.Label lblPartClaseId;
        private System.Windows.Forms.TextBox txtIdParticipante;
        private System.Windows.Forms.TextBox txtNombreParticipante;
        private System.Windows.Forms.TextBox txtParticipante_IdClase;
        private System.Windows.Forms.Button btnInsertarParticipante;
        private System.Windows.Forms.Button btnEliminarParticipante;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.dgvInstructores = new System.Windows.Forms.DataGridView();
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.lblInsId = new System.Windows.Forms.Label();
            this.lblInsNombre = new System.Windows.Forms.Label();
            this.lblInsEsp = new System.Windows.Forms.Label();
            this.txtIdInstructor = new System.Windows.Forms.TextBox();
            this.txtNombreInstructor = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.btnInsertarInstructor = new System.Windows.Forms.Button();
            this.btnEliminarInstructor = new System.Windows.Forms.Button();
            this.lblClaseId = new System.Windows.Forms.Label();
            this.lblClaseNombre = new System.Windows.Forms.Label();
            this.lblClaseHorario = new System.Windows.Forms.Label();
            this.lblClaseInstructorId = new System.Windows.Forms.Label();
            this.txtIdClase = new System.Windows.Forms.TextBox();
            this.txtNombreClase = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtClase_IdInstructor = new System.Windows.Forms.TextBox();
            this.btnInsertarClase = new System.Windows.Forms.Button();
            this.btnEliminarClase = new System.Windows.Forms.Button();
            this.lblPartId = new System.Windows.Forms.Label();
            this.lblPartNombre = new System.Windows.Forms.Label();
            this.lblPartClaseId = new System.Windows.Forms.Label();
            this.txtIdParticipante = new System.Windows.Forms.TextBox();
            this.txtNombreParticipante = new System.Windows.Forms.TextBox();
            this.txtParticipante_IdClase = new System.Windows.Forms.TextBox();
            this.btnInsertarParticipante = new System.Windows.Forms.Button();
            this.btnEliminarParticipante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstructores
            // 
            this.dgvInstructores.ColumnHeadersHeight = 29;
            this.dgvInstructores.Location = new System.Drawing.Point(20, 30);
            this.dgvInstructores.Name = "dgvInstructores";
            this.dgvInstructores.ReadOnly = true;
            this.dgvInstructores.RowHeadersWidth = 51;
            this.dgvInstructores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstructores.Size = new System.Drawing.Size(440, 160);
            this.dgvInstructores.TabIndex = 0;
            // 
            // dgvClases
            // 
            this.dgvClases.ColumnHeadersHeight = 29;
            this.dgvClases.Location = new System.Drawing.Point(20, 306);
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.ReadOnly = true;
            this.dgvClases.RowHeadersWidth = 51;
            this.dgvClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClases.Size = new System.Drawing.Size(440, 134);
            this.dgvClases.TabIndex = 1;
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.ColumnHeadersHeight = 29;
            this.dgvParticipantes.Location = new System.Drawing.Point(500, 30);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.ReadOnly = true;
            this.dgvParticipantes.RowHeadersWidth = 51;
            this.dgvParticipantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipantes.Size = new System.Drawing.Size(440, 252);
            this.dgvParticipantes.TabIndex = 2;
            // 
            // lblInsId
            // 
            this.lblInsId.AutoSize = true;
            this.lblInsId.Location = new System.Drawing.Point(20, 200);
            this.lblInsId.Name = "lblInsId";
            this.lblInsId.Size = new System.Drawing.Size(166, 16);
            this.lblInsId.TabIndex = 3;
            this.lblInsId.Text = "ID Instructor (vacío -> auto):";
            // 
            // lblInsNombre
            // 
            this.lblInsNombre.AutoSize = true;
            this.lblInsNombre.Location = new System.Drawing.Point(260, 200);
            this.lblInsNombre.Name = "lblInsNombre";
            this.lblInsNombre.Size = new System.Drawing.Size(59, 16);
            this.lblInsNombre.TabIndex = 5;
            this.lblInsNombre.Text = "Nombre:";
            // 
            // lblInsEsp
            // 
            this.lblInsEsp.AutoSize = true;
            this.lblInsEsp.Location = new System.Drawing.Point(20, 230);
            this.lblInsEsp.Name = "lblInsEsp";
            this.lblInsEsp.Size = new System.Drawing.Size(90, 16);
            this.lblInsEsp.TabIndex = 7;
            this.lblInsEsp.Text = "Especialidad:";
            // 
            // txtIdInstructor
            // 
            this.txtIdInstructor.Location = new System.Drawing.Point(170, 196);
            this.txtIdInstructor.Name = "txtIdInstructor";
            this.txtIdInstructor.Size = new System.Drawing.Size(70, 22);
            this.txtIdInstructor.TabIndex = 4;
            // 
            // txtNombreInstructor
            // 
            this.txtNombreInstructor.Location = new System.Drawing.Point(320, 196);
            this.txtNombreInstructor.Name = "txtNombreInstructor";
            this.txtNombreInstructor.Size = new System.Drawing.Size(140, 22);
            this.txtNombreInstructor.TabIndex = 6;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(116, 226);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(330, 22);
            this.txtEspecialidad.TabIndex = 8;
            // 
            // btnInsertarInstructor
            // 
            this.btnInsertarInstructor.Location = new System.Drawing.Point(70, 254);
            this.btnInsertarInstructor.Name = "btnInsertarInstructor";
            this.btnInsertarInstructor.Size = new System.Drawing.Size(140, 28);
            this.btnInsertarInstructor.TabIndex = 9;
            this.btnInsertarInstructor.Text = "Insertar Instructor";
            this.btnInsertarInstructor.Click += new System.EventHandler(this.btnInsertarInstructor_Click);
            // 
            // btnEliminarInstructor
            // 
            this.btnEliminarInstructor.Location = new System.Drawing.Point(226, 254);
            this.btnEliminarInstructor.Name = "btnEliminarInstructor";
            this.btnEliminarInstructor.Size = new System.Drawing.Size(140, 28);
            this.btnEliminarInstructor.TabIndex = 10;
            this.btnEliminarInstructor.Text = "Eliminar Instructor";
            this.btnEliminarInstructor.Click += new System.EventHandler(this.btnEliminarInstructor_Click);
            // 
            // lblClaseId
            // 
            this.lblClaseId.AutoSize = true;
            this.lblClaseId.Location = new System.Drawing.Point(20, 450);
            this.lblClaseId.Name = "lblClaseId";
            this.lblClaseId.Size = new System.Drawing.Size(148, 16);
            this.lblClaseId.TabIndex = 11;
            this.lblClaseId.Text = "ID Clase (vacío -> auto):";
            // 
            // lblClaseNombre
            // 
            this.lblClaseNombre.AutoSize = true;
            this.lblClaseNombre.Location = new System.Drawing.Point(240, 450);
            this.lblClaseNombre.Name = "lblClaseNombre";
            this.lblClaseNombre.Size = new System.Drawing.Size(97, 16);
            this.lblClaseNombre.TabIndex = 13;
            this.lblClaseNombre.Text = "Nombre Clase:";
            // 
            // lblClaseHorario
            // 
            this.lblClaseHorario.AutoSize = true;
            this.lblClaseHorario.Location = new System.Drawing.Point(20, 480);
            this.lblClaseHorario.Name = "lblClaseHorario";
            this.lblClaseHorario.Size = new System.Drawing.Size(55, 16);
            this.lblClaseHorario.TabIndex = 15;
            this.lblClaseHorario.Text = "Horario:";
            // 
            // lblClaseInstructorId
            // 
            this.lblClaseInstructorId.AutoSize = true;
            this.lblClaseInstructorId.Location = new System.Drawing.Point(240, 480);
            this.lblClaseInstructorId.Name = "lblClaseInstructorId";
            this.lblClaseInstructorId.Size = new System.Drawing.Size(79, 16);
            this.lblClaseInstructorId.TabIndex = 17;
            this.lblClaseInstructorId.Text = "ID Instructor:";
            // 
            // txtIdClase
            // 
            this.txtIdClase.Location = new System.Drawing.Point(150, 446);
            this.txtIdClase.Name = "txtIdClase";
            this.txtIdClase.Size = new System.Drawing.Size(70, 22);
            this.txtIdClase.TabIndex = 12;
            // 
            // txtNombreClase
            // 
            this.txtNombreClase.Location = new System.Drawing.Point(340, 446);
            this.txtNombreClase.Name = "txtNombreClase";
            this.txtNombreClase.Size = new System.Drawing.Size(160, 22);
            this.txtNombreClase.TabIndex = 14;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(90, 476);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(120, 22);
            this.txtHorario.TabIndex = 16;
            // 
            // txtClase_IdInstructor
            // 
            this.txtClase_IdInstructor.Location = new System.Drawing.Point(320, 476);
            this.txtClase_IdInstructor.Name = "txtClase_IdInstructor";
            this.txtClase_IdInstructor.Size = new System.Drawing.Size(80, 22);
            this.txtClase_IdInstructor.TabIndex = 18;
            // 
            // btnInsertarClase
            // 
            this.btnInsertarClase.Location = new System.Drawing.Point(150, 504);
            this.btnInsertarClase.Name = "btnInsertarClase";
            this.btnInsertarClase.Size = new System.Drawing.Size(120, 28);
            this.btnInsertarClase.TabIndex = 19;
            this.btnInsertarClase.Text = "Insertar Clase";
            this.btnInsertarClase.Click += new System.EventHandler(this.btnInsertarClase_Click);
            // 
            // btnEliminarClase
            // 
            this.btnEliminarClase.Location = new System.Drawing.Point(280, 504);
            this.btnEliminarClase.Name = "btnEliminarClase";
            this.btnEliminarClase.Size = new System.Drawing.Size(120, 28);
            this.btnEliminarClase.TabIndex = 20;
            this.btnEliminarClase.Text = "Eliminar Clase";
            this.btnEliminarClase.Click += new System.EventHandler(this.btnEliminarClase_Click);
            // 
            // lblPartId
            // 
            this.lblPartId.AutoSize = true;
            this.lblPartId.Location = new System.Drawing.Point(500, 310);
            this.lblPartId.Name = "lblPartId";
            this.lblPartId.Size = new System.Drawing.Size(184, 16);
            this.lblPartId.TabIndex = 21;
            this.lblPartId.Text = "ID Participante (vacío -> auto):";
            // 
            // lblPartNombre
            // 
            this.lblPartNombre.AutoSize = true;
            this.lblPartNombre.Location = new System.Drawing.Point(500, 340);
            this.lblPartNombre.Name = "lblPartNombre";
            this.lblPartNombre.Size = new System.Drawing.Size(59, 16);
            this.lblPartNombre.TabIndex = 23;
            this.lblPartNombre.Text = "Nombre:";
            // 
            // lblPartClaseId
            // 
            this.lblPartClaseId.AutoSize = true;
            this.lblPartClaseId.Location = new System.Drawing.Point(751, 340);
            this.lblPartClaseId.Name = "lblPartClaseId";
            this.lblPartClaseId.Size = new System.Drawing.Size(61, 16);
            this.lblPartClaseId.TabIndex = 25;
            this.lblPartClaseId.Text = "ID Clase:";
            // 
            // txtIdParticipante
            // 
            this.txtIdParticipante.Location = new System.Drawing.Point(700, 306);
            this.txtIdParticipante.Name = "txtIdParticipante";
            this.txtIdParticipante.Size = new System.Drawing.Size(70, 22);
            this.txtIdParticipante.TabIndex = 22;
            // 
            // txtNombreParticipante
            // 
            this.txtNombreParticipante.Location = new System.Drawing.Point(560, 336);
            this.txtNombreParticipante.Name = "txtNombreParticipante";
            this.txtNombreParticipante.Size = new System.Drawing.Size(185, 22);
            this.txtNombreParticipante.TabIndex = 24;
            // 
            // txtParticipante_IdClase
            // 
            this.txtParticipante_IdClase.Location = new System.Drawing.Point(818, 338);
            this.txtParticipante_IdClase.Name = "txtParticipante_IdClase";
            this.txtParticipante_IdClase.Size = new System.Drawing.Size(80, 22);
            this.txtParticipante_IdClase.TabIndex = 26;
            this.txtParticipante_IdClase.TextChanged += new System.EventHandler(this.txtParticipante_IdClase_TextChanged);
            // 
            // btnInsertarParticipante
            // 
            this.btnInsertarParticipante.Location = new System.Drawing.Point(592, 377);
            this.btnInsertarParticipante.Name = "btnInsertarParticipante";
            this.btnInsertarParticipante.Size = new System.Drawing.Size(140, 28);
            this.btnInsertarParticipante.TabIndex = 27;
            this.btnInsertarParticipante.Text = "Insertar Participante";
            this.btnInsertarParticipante.Click += new System.EventHandler(this.btnInsertarParticipante_Click);
            // 
            // btnEliminarParticipante
            // 
            this.btnEliminarParticipante.Location = new System.Drawing.Point(754, 377);
            this.btnEliminarParticipante.Name = "btnEliminarParticipante";
            this.btnEliminarParticipante.Size = new System.Drawing.Size(140, 28);
            this.btnEliminarParticipante.TabIndex = 28;
            this.btnEliminarParticipante.Text = "Eliminar Participante";
            this.btnEliminarParticipante.Click += new System.EventHandler(this.btnEliminarParticipante_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(980, 540);
            this.Controls.Add(this.dgvInstructores);
            this.Controls.Add(this.dgvClases);
            this.Controls.Add(this.dgvParticipantes);
            this.Controls.Add(this.lblInsId);
            this.Controls.Add(this.txtIdInstructor);
            this.Controls.Add(this.lblInsNombre);
            this.Controls.Add(this.txtNombreInstructor);
            this.Controls.Add(this.lblInsEsp);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.btnInsertarInstructor);
            this.Controls.Add(this.btnEliminarInstructor);
            this.Controls.Add(this.lblClaseId);
            this.Controls.Add(this.txtIdClase);
            this.Controls.Add(this.lblClaseNombre);
            this.Controls.Add(this.txtNombreClase);
            this.Controls.Add(this.lblClaseHorario);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.lblClaseInstructorId);
            this.Controls.Add(this.txtClase_IdInstructor);
            this.Controls.Add(this.btnInsertarClase);
            this.Controls.Add(this.btnEliminarClase);
            this.Controls.Add(this.lblPartId);
            this.Controls.Add(this.txtIdParticipante);
            this.Controls.Add(this.lblPartNombre);
            this.Controls.Add(this.txtNombreParticipante);
            this.Controls.Add(this.lblPartClaseId);
            this.Controls.Add(this.txtParticipante_IdClase);
            this.Controls.Add(this.btnInsertarParticipante);
            this.Controls.Add(this.btnEliminarParticipante);
            this.Name = "Form1";
            this.Text = "Sistema de Gestión de Clases de Gimnasio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
