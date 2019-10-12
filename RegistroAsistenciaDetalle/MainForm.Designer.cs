namespace RegistroAsistenciaDetalle
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciasToolStripMenuItem,
            this.asignaturasToolStripMenuItem,
            this.estudiantesToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registroToolStripMenuItem.Text = "Registros";
            // 
            // asistenciasToolStripMenuItem
            // 
            this.asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
            this.asistenciasToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.asistenciasToolStripMenuItem.Text = "Asistencias";
            this.asistenciasToolStripMenuItem.Click += new System.EventHandler(this.AsistenciasToolStripMenuItem_Click);
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem.Click += new System.EventHandler(this.AsignaturasToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciasToolStripMenuItem1,
            this.asignaturasToolStripMenuItem1,
            this.estudiantesToolStripMenuItem1,
            this.detalleToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // asistenciasToolStripMenuItem1
            // 
            this.asistenciasToolStripMenuItem1.Name = "asistenciasToolStripMenuItem1";
            this.asistenciasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.asistenciasToolStripMenuItem1.Text = "Asistencias";
            this.asistenciasToolStripMenuItem1.Click += new System.EventHandler(this.AsistenciasToolStripMenuItem1_Click);
            // 
            // asignaturasToolStripMenuItem1
            // 
            this.asignaturasToolStripMenuItem1.Name = "asignaturasToolStripMenuItem1";
            this.asignaturasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.asignaturasToolStripMenuItem1.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem1.Click += new System.EventHandler(this.AsignaturasToolStripMenuItem1_Click);
            // 
            // estudiantesToolStripMenuItem1
            // 
            this.estudiantesToolStripMenuItem1.Name = "estudiantesToolStripMenuItem1";
            this.estudiantesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.estudiantesToolStripMenuItem1.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem1.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem1_Click);
            // 
            // detalleToolStripMenuItem
            // 
            this.detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            this.detalleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detalleToolStripMenuItem.Text = "Detalle";
            this.detalleToolStripMenuItem.Click += new System.EventHandler(this.DetalleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Formulario Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
    }
}

