namespace pryGestorDeTareas
{
    partial class frmBuscarTareas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.optTodas = new System.Windows.Forms.RadioButton();
            this.optMisTareas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.optVencimiento = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPrioridades = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÚSQUEDA DE TAREAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 417);
            this.panel1.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.optTodas);
            this.panel7.Controls.Add(this.optMisTareas);
            this.panel7.Location = new System.Drawing.Point(21, 59);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 49);
            this.panel7.TabIndex = 8;
            // 
            // optTodas
            // 
            this.optTodas.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.optTodas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTodas.Location = new System.Drawing.Point(106, 3);
            this.optTodas.Name = "optTodas";
            this.optTodas.Size = new System.Drawing.Size(121, 36);
            this.optTodas.TabIndex = 7;
            this.optTodas.Text = "Todas las Tareas";
            this.optTodas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optTodas.UseVisualStyleBackColor = true;
            this.optTodas.CheckedChanged += new System.EventHandler(this.optTodas_CheckedChanged);
            // 
            // optMisTareas
            // 
            this.optMisTareas.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.optMisTareas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMisTareas.Location = new System.Drawing.Point(3, 3);
            this.optMisTareas.Name = "optMisTareas";
            this.optMisTareas.Size = new System.Drawing.Size(121, 36);
            this.optMisTareas.TabIndex = 6;
            this.optMisTareas.Text = "Mis Tareas";
            this.optMisTareas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optMisTareas.UseVisualStyleBackColor = true;
            this.optMisTareas.CheckedChanged += new System.EventHandler(this.optMisTareas_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(15, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.optVencimiento);
            this.panel6.Location = new System.Drawing.Point(6, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(161, 50);
            this.panel6.TabIndex = 7;
            // 
            // optVencimiento
            // 
            this.optVencimiento.AutoSize = true;
            this.optVencimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.optVencimiento.Location = new System.Drawing.Point(14, 14);
            this.optVencimiento.Name = "optVencimiento";
            this.optVencimiento.Size = new System.Drawing.Size(138, 20);
            this.optVencimiento.TabIndex = 0;
            this.optVencimiento.TabStop = true;
            this.optVencimiento.Text = "Próximo a vencer";
            this.optVencimiento.UseVisualStyleBackColor = true;
            this.optVencimiento.CheckedChanged += new System.EventHandler(this.optVencimiento_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cmbPrioridades);
            this.panel5.Location = new System.Drawing.Point(6, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 50);
            this.panel5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prioridad:";
            // 
            // cmbPrioridades
            // 
            this.cmbPrioridades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridades.FormattingEnabled = true;
            this.cmbPrioridades.Location = new System.Drawing.Point(90, 13);
            this.cmbPrioridades.Name = "cmbPrioridades";
            this.cmbPrioridades.Size = new System.Drawing.Size(138, 23);
            this.cmbPrioridades.TabIndex = 4;
            this.cmbPrioridades.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridades_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cmbCategorias);
            this.panel4.Location = new System.Drawing.Point(6, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 50);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoría:";
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(90, 13);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(138, 23);
            this.cmbCategorias.TabIndex = 4;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmbTipoFiltro);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(21, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 63);
            this.panel3.TabIndex = 6;
            // 
            // cmbTipoFiltro
            // 
            this.cmbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFiltro.FormattingEnabled = true;
            this.cmbTipoFiltro.Items.AddRange(new object[] {
            "Categoria",
            "Prioridad",
            "Vencimiento"});
            this.cmbTipoFiltro.Location = new System.Drawing.Point(33, 25);
            this.cmbTipoFiltro.Name = "cmbTipoFiltro";
            this.cmbTipoFiltro.Size = new System.Drawing.Size(176, 23);
            this.cmbTipoFiltro.TabIndex = 3;
            this.cmbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbTipoFiltro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione un filtro";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTareas);
            this.panel2.Location = new System.Drawing.Point(305, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 417);
            this.panel2.TabIndex = 4;
            // 
            // dgvTareas
            // 
            this.dgvTareas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTareas.Location = new System.Drawing.Point(0, 0);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(567, 417);
            this.dgvTareas.TabIndex = 0;
            // 
            // frmBuscarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBuscarTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Tareas";
            this.Load += new System.EventHandler(this.frmBuscarTareas_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbTipoFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPrioridades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton optVencimiento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton optTodas;
        private System.Windows.Forms.RadioButton optMisTareas;
    }
}