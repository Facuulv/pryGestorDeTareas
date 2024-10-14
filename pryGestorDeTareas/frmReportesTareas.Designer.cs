namespace pryGestorDeTareas
{
    partial class frmReportesTareas
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.btnCompletadas = new System.Windows.Forms.Button();
            this.txtPendientes = new System.Windows.Forms.TextBox();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.txtCompletadas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "TAREAS PENDIENTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "TAREAS COMPLETADAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPendientes
            // 
            this.btnPendientes.Location = new System.Drawing.Point(27, 376);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(267, 41);
            this.btnPendientes.TabIndex = 5;
            this.btnPendientes.Text = "Listar Tareas Pendientes";
            this.btnPendientes.UseVisualStyleBackColor = true;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // btnCompletadas
            // 
            this.btnCompletadas.Location = new System.Drawing.Point(312, 376);
            this.btnCompletadas.Name = "btnCompletadas";
            this.btnCompletadas.Size = new System.Drawing.Size(267, 41);
            this.btnCompletadas.TabIndex = 6;
            this.btnCompletadas.Text = "Listar Tareas Completadas";
            this.btnCompletadas.UseVisualStyleBackColor = true;
            this.btnCompletadas.Click += new System.EventHandler(this.btnCompletadas_Click);
            // 
            // txtPendientes
            // 
            this.txtPendientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendientes.Location = new System.Drawing.Point(27, 65);
            this.txtPendientes.Multiline = true;
            this.txtPendientes.Name = "txtPendientes";
            this.txtPendientes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPendientes.Size = new System.Drawing.Size(267, 304);
            this.txtPendientes.TabIndex = 7;
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.Location = new System.Drawing.Point(27, 423);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(552, 41);
            this.btnLimpiarTodo.TabIndex = 8;
            this.btnLimpiarTodo.Text = "Limpiar Todo";
            this.btnLimpiarTodo.UseVisualStyleBackColor = true;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // txtCompletadas
            // 
            this.txtCompletadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompletadas.Location = new System.Drawing.Point(312, 65);
            this.txtCompletadas.Multiline = true;
            this.txtCompletadas.Name = "txtCompletadas";
            this.txtCompletadas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCompletadas.Size = new System.Drawing.Size(267, 304);
            this.txtCompletadas.TabIndex = 9;
            // 
            // frmReportesTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 474);
            this.Controls.Add(this.txtCompletadas);
            this.Controls.Add(this.btnLimpiarTodo);
            this.Controls.Add(this.txtPendientes);
            this.Controls.Add(this.btnCompletadas);
            this.Controls.Add(this.btnPendientes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmReportesTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Tareas";
            this.Load += new System.EventHandler(this.frmReportesTareas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.Button btnCompletadas;
        private System.Windows.Forms.TextBox txtPendientes;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.TextBox txtCompletadas;
    }
}