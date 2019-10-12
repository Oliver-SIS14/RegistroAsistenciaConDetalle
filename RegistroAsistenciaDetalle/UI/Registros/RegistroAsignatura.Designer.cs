namespace RegistroAsistenciaDetalle.UI.Registros
{
    partial class RegistroAsignatura
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
            this.AsignaturaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AsignaturaTextBox
            // 
            this.AsignaturaTextBox.Location = new System.Drawing.Point(76, 69);
            this.AsignaturaTextBox.Name = "AsignaturaTextBox";
            this.AsignaturaTextBox.Size = new System.Drawing.Size(358, 20);
            this.AsignaturaTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asignatura";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(76, 12);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(233, 20);
            this.IDnumericUpDown.TabIndex = 4;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.BuscarIcon__1_;
            this.BuscarButton.Location = new System.Drawing.Point(315, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(119, 61);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.NuevoIcon__1_;
            this.NuevoButton.Location = new System.Drawing.Point(76, 120);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(119, 63);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.GuardarIcon__1_;
            this.GuardarButton.Location = new System.Drawing.Point(201, 120);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(108, 63);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click_1);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::RegistroAsistenciaDetalle.Properties.Resources.cancelarn;
            this.EliminarButton.Location = new System.Drawing.Point(315, 120);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(119, 63);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click_1);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistroAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 195);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsignaturaTextBox);
            this.Name = "RegistroAsignatura";
            this.Text = "RegistroAsignatura";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AsignaturaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}