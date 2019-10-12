namespace RegistroAsistenciaDetalle.UI.Registros
{
    partial class RegistroEstudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.EstudianteTextBox = new System.Windows.Forms.TextBox();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante";
            // 
            // EstudianteTextBox
            // 
            this.EstudianteTextBox.Location = new System.Drawing.Point(76, 66);
            this.EstudianteTextBox.Name = "EstudianteTextBox";
            this.EstudianteTextBox.Size = new System.Drawing.Size(358, 20);
            this.EstudianteTextBox.TabIndex = 1;
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(76, 12);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(240, 20);
            this.IDnumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.BuscarIcon__1_;
            this.BuscarButton.Location = new System.Drawing.Point(322, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(112, 58);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.NuevoIcon__1_;
            this.NuevoButton.Location = new System.Drawing.Point(76, 118);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(119, 57);
            this.NuevoButton.TabIndex = 7;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.GuardarIcon__1_;
            this.AgregarButton.Location = new System.Drawing.Point(201, 118);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(115, 57);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.cancelarn;
            this.EliminarButton.Location = new System.Drawing.Point(322, 118);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(112, 57);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistroEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 187);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.EstudianteTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEstudiante";
            this.Text = "Agregar Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EstudianteTextBox;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}