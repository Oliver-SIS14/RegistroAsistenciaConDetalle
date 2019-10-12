namespace RegistroAsistenciaDetalle.UI.Consultas
{
    partial class ConsultaDetalle
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
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(13, 60);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(562, 344);
            this.ConsultaDataGridView.TabIndex = 1;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Location = new System.Drawing.Point(12, 33);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(197, 21);
            this.FiltroComboBox.TabIndex = 8;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(215, 33);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(210, 20);
            this.CriterioTextBox.TabIndex = 9;
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Location = new System.Drawing.Point(431, 30);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(144, 23);
            this.ConsultarButton.TabIndex = 10;
            this.ConsultarButton.Text = "Consultar";
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Criterio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filtro";
            // 
            // ConsultaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Name = "ConsultaDetalle";
            this.Text = "ConsultaDetalle";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}