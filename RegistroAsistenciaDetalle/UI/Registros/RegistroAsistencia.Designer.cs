namespace RegistroAsistenciaDetalle.UI.Registros
{
    partial class RegistroAsistencia
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
            this.components = new System.ComponentModel.Container();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EstudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.AsistenciaCheckBox = new System.Windows.Forms.CheckBox();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.Estudiante = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AsignaturaButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.AgregarAsistenciaButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(73, 16);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.IDNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(341, 16);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(116, 20);
            this.FechaDateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asignatura";
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(75, 56);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(334, 21);
            this.AsignaturaComboBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgregarAsistenciaButton);
            this.groupBox1.Controls.Add(this.EstudiantesDataGridView);
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Controls.Add(this.AsistenciaCheckBox);
            this.groupBox1.Controls.Add(this.EstudianteComboBox);
            this.groupBox1.Controls.Add(this.Estudiante);
            this.groupBox1.Location = new System.Drawing.Point(7, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 228);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // EstudiantesDataGridView
            // 
            this.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(8, 60);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.ReadOnly = true;
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(442, 159);
            this.EstudiantesDataGridView.TabIndex = 11;
            // 
            // AsistenciaCheckBox
            // 
            this.AsistenciaCheckBox.AutoSize = true;
            this.AsistenciaCheckBox.Location = new System.Drawing.Point(334, 35);
            this.AsistenciaCheckBox.Name = "AsistenciaCheckBox";
            this.AsistenciaCheckBox.Size = new System.Drawing.Size(68, 17);
            this.AsistenciaCheckBox.TabIndex = 9;
            this.AsistenciaCheckBox.Text = "Presente";
            this.AsistenciaCheckBox.UseVisualStyleBackColor = true;
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(5, 32);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(258, 21);
            this.EstudianteComboBox.TabIndex = 8;
            // 
            // Estudiante
            // 
            this.Estudiante.AutoSize = true;
            this.Estudiante.Location = new System.Drawing.Point(5, 16);
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Size = new System.Drawing.Size(57, 13);
            this.Estudiante.TabIndex = 6;
            this.Estudiante.Text = "Estudiante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cantidad";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(73, 317);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.ReadOnly = true;
            this.CantidadTextBox.Size = new System.Drawing.Size(384, 20);
            this.CantidadTextBox.TabIndex = 9;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // AsignaturaButton
            // 
            this.AsignaturaButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.plus__1_;
            this.AsignaturaButton.Location = new System.Drawing.Point(419, 48);
            this.AsignaturaButton.Name = "AsignaturaButton";
            this.AsignaturaButton.Size = new System.Drawing.Size(44, 36);
            this.AsignaturaButton.TabIndex = 13;
            this.AsignaturaButton.UseVisualStyleBackColor = true;
            this.AsignaturaButton.Click += new System.EventHandler(this.AsignaturaButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.cancelarn;
            this.EliminarButton.Location = new System.Drawing.Point(326, 372);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(131, 58);
            this.EliminarButton.TabIndex = 12;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // Guardar
            // 
            this.MyErrorProvider.SetIconAlignment(this.Guardar, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.Guardar.Image = global::RegistroAsistenciaDetalle.Properties.Resources.GuardarIcon__1_;
            this.Guardar.Location = new System.Drawing.Point(167, 372);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(139, 58);
            this.Guardar.TabIndex = 11;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.NuevoIcon__1_;
            this.NuevoButton.Location = new System.Drawing.Point(15, 372);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(135, 58);
            this.NuevoButton.TabIndex = 10;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // AgregarAsistenciaButton
            // 
            this.AgregarAsistenciaButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.plus__1_;
            this.AgregarAsistenciaButton.Location = new System.Drawing.Point(408, 16);
            this.AgregarAsistenciaButton.Name = "AgregarAsistenciaButton";
            this.AgregarAsistenciaButton.Size = new System.Drawing.Size(42, 38);
            this.AgregarAsistenciaButton.TabIndex = 12;
            this.AgregarAsistenciaButton.UseVisualStyleBackColor = true;
            this.AgregarAsistenciaButton.Click += new System.EventHandler(this.AgregarAsistenciaButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.plus__1_;
            this.AgregarButton.Location = new System.Drawing.Point(273, 16);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(45, 38);
            this.AgregarButton.TabIndex = 10;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.BuscarIcon__1_;
            this.BuscarButton.Location = new System.Drawing.Point(167, 9);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(103, 38);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // RegistroAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 442);
            this.Controls.Add(this.AsignaturaButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AsignaturaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDNumericUpDown);
            this.Name = "RegistroAsistencia";
            this.Text = "Registro Asistencia";
            this.Load += new System.EventHandler(this.RegistroAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.CheckBox AsistenciaCheckBox;
        private System.Windows.Forms.ComboBox EstudianteComboBox;
        private System.Windows.Forms.Label Estudiante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button AgregarAsistenciaButton;
        private System.Windows.Forms.Button AsignaturaButton;
    }
}