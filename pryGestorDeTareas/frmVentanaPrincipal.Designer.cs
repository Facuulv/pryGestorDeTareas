namespace pryGestorDeTareas
{
    partial class frmVentanaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.optVencimiento = new System.Windows.Forms.RadioButton();
            this.optPrioridad = new System.Windows.Forms.RadioButton();
            this.optCategoria = new System.Windows.Forms.RadioButton();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.optTodas = new System.Windows.Forms.RadioButton();
            this.optMisTareas = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvHacer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvHaciendo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvHecha = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslLeyenda = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBienvenido = new System.Windows.Forms.ToolStripLabel();
            this.tslUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.pbLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbConfirmar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbPapelera = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHacer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaciendo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHecha)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(212, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 372);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbFiltros);
            this.groupBox1.Controls.Add(this.gbUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(475, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 116);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnLimpiar);
            this.gbFiltros.Controls.Add(this.cmbPrioridad);
            this.gbFiltros.Controls.Add(this.cmbCategorias);
            this.gbFiltros.Controls.Add(this.optVencimiento);
            this.gbFiltros.Controls.Add(this.optPrioridad);
            this.gbFiltros.Controls.Add(this.optCategoria);
            this.gbFiltros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.Location = new System.Drawing.Point(158, 17);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(233, 93);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "POR";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(152, 66);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(98, 41);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(129, 23);
            this.cmbPrioridad.TabIndex = 4;
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(98, 16);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(129, 23);
            this.cmbCategorias.TabIndex = 3;
            // 
            // optVencimiento
            // 
            this.optVencimiento.AutoSize = true;
            this.optVencimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optVencimiento.Location = new System.Drawing.Point(6, 68);
            this.optVencimiento.Name = "optVencimiento";
            this.optVencimiento.Size = new System.Drawing.Size(133, 19);
            this.optVencimiento.TabIndex = 2;
            this.optVencimiento.TabStop = true;
            this.optVencimiento.Text = "Proximas a Vencer";
            this.optVencimiento.UseVisualStyleBackColor = true;
            // 
            // optPrioridad
            // 
            this.optPrioridad.AutoSize = true;
            this.optPrioridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPrioridad.Location = new System.Drawing.Point(6, 44);
            this.optPrioridad.Name = "optPrioridad";
            this.optPrioridad.Size = new System.Drawing.Size(77, 19);
            this.optPrioridad.TabIndex = 1;
            this.optPrioridad.TabStop = true;
            this.optPrioridad.Text = "Prioridad";
            this.optPrioridad.UseVisualStyleBackColor = true;
            // 
            // optCategoria
            // 
            this.optCategoria.AutoSize = true;
            this.optCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCategoria.Location = new System.Drawing.Point(6, 20);
            this.optCategoria.Name = "optCategoria";
            this.optCategoria.Size = new System.Drawing.Size(87, 19);
            this.optCategoria.TabIndex = 0;
            this.optCategoria.TabStop = true;
            this.optCategoria.Text = "Categorías";
            this.optCategoria.UseVisualStyleBackColor = true;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.optTodas);
            this.gbUsuario.Controls.Add(this.optMisTareas);
            this.gbUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.Location = new System.Drawing.Point(7, 17);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(133, 93);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            // 
            // optTodas
            // 
            this.optTodas.AutoSize = true;
            this.optTodas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTodas.Location = new System.Drawing.Point(6, 56);
            this.optTodas.Name = "optTodas";
            this.optTodas.Size = new System.Drawing.Size(121, 19);
            this.optTodas.TabIndex = 1;
            this.optTodas.TabStop = true;
            this.optTodas.Text = "Todas las Tareas";
            this.optTodas.UseVisualStyleBackColor = true;
            this.optTodas.CheckedChanged += new System.EventHandler(this.optTodas_CheckedChanged);
            // 
            // optMisTareas
            // 
            this.optMisTareas.AutoSize = true;
            this.optMisTareas.Checked = true;
            this.optMisTareas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMisTareas.Location = new System.Drawing.Point(6, 20);
            this.optMisTareas.Name = "optMisTareas";
            this.optMisTareas.Size = new System.Drawing.Size(87, 19);
            this.optMisTareas.TabIndex = 0;
            this.optMisTareas.TabStop = true;
            this.optMisTareas.Text = "Mis Tareas";
            this.optMisTareas.UseVisualStyleBackColor = true;
            this.optMisTareas.CheckedChanged += new System.EventHandler(this.optMisTareas_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(239, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 353);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.dgvHacer);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PARA HACER";
            // 
            // dgvHacer
            // 
            this.dgvHacer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvHacer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHacer.Location = new System.Drawing.Point(3, 3);
            this.dgvHacer.Name = "dgvHacer";
            this.dgvHacer.ReadOnly = true;
            this.dgvHacer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHacer.Size = new System.Drawing.Size(623, 319);
            this.dgvHacer.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OldLace;
            this.tabPage2.Controls.Add(this.dgvHaciendo);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HACIENDO";
            // 
            // dgvHaciendo
            // 
            this.dgvHaciendo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvHaciendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHaciendo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHaciendo.Location = new System.Drawing.Point(3, 3);
            this.dgvHaciendo.Name = "dgvHaciendo";
            this.dgvHaciendo.ReadOnly = true;
            this.dgvHaciendo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHaciendo.Size = new System.Drawing.Size(623, 319);
            this.dgvHaciendo.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.OldLace;
            this.tabPage3.Controls.Add(this.dgvHecha);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(629, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HECHAS";
            // 
            // dgvHecha
            // 
            this.dgvHecha.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvHecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHecha.Location = new System.Drawing.Point(3, 3);
            this.dgvHecha.Name = "dgvHecha";
            this.dgvHecha.ReadOnly = true;
            this.dgvHecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHecha.Size = new System.Drawing.Size(623, 319);
            this.dgvHecha.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbEliminar,
            this.toolStripSeparator2,
            this.tsbConfirmar,
            this.tsbModificar,
            this.tsbPapelera,
            this.toolStripSeparator7});
            this.toolStrip2.Location = new System.Drawing.Point(212, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 458);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(22, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(22, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLeyenda,
            this.toolStripSeparator6,
            this.tslBienvenido,
            this.tslUsuario,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.toolStripDropDownButton2,
            this.toolStripSeparator5,
            this.tsbCerrarSesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(212, 458);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslLeyenda
            // 
            this.tslLeyenda.AutoSize = false;
            this.tslLeyenda.BackColor = System.Drawing.Color.OldLace;
            this.tslLeyenda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslLeyenda.ForeColor = System.Drawing.SystemColors.Window;
            this.tslLeyenda.Name = "tslLeyenda";
            this.tslLeyenda.Size = new System.Drawing.Size(200, 50);
            this.tslLeyenda.Text = "GESTOR DE TAREAS";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(210, 6);
            // 
            // tslBienvenido
            // 
            this.tslBienvenido.Font = new System.Drawing.Font("Arial Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tslBienvenido.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.tslBienvenido.Name = "tslBienvenido";
            this.tslBienvenido.Size = new System.Drawing.Size(210, 30);
            this.tslBienvenido.Text = "¡Bienvenido!";
            // 
            // tslUsuario
            // 
            this.tslUsuario.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.tslUsuario.Name = "tslUsuario";
            this.tslUsuario.Size = new System.Drawing.Size(210, 0);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.BackColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(210, 6);
            // 
            // pbLogoPrincipal
            // 
            this.pbLogoPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.pbLogoPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogoPrincipal.Image = global::pryGestorDeTareas.Properties.Resources.home_app_logo_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.pbLogoPrincipal.Location = new System.Drawing.Point(308, 9);
            this.pbLogoPrincipal.Name = "pbLogoPrincipal";
            this.pbLogoPrincipal.Size = new System.Drawing.Size(100, 96);
            this.pbLogoPrincipal.TabIndex = 12;
            this.pbLogoPrincipal.TabStop = false;
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = global::pryGestorDeTareas.Properties.Resources.person_add_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(22, 20);
            this.tsbAgregar.Text = "Agregar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::pryGestorDeTareas.Properties.Resources.person_remove_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(22, 20);
            this.tsbEliminar.Text = "Eliminar";
            // 
            // tsbConfirmar
            // 
            this.tsbConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConfirmar.Image = global::pryGestorDeTareas.Properties.Resources.check_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfirmar.Name = "tsbConfirmar";
            this.tsbConfirmar.Size = new System.Drawing.Size(22, 20);
            this.tsbConfirmar.Text = "Realizar Tarea";
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = global::pryGestorDeTareas.Properties.Resources.edit_document_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(22, 20);
            this.tsbModificar.Text = "Modificar Tarea";
            // 
            // tsbPapelera
            // 
            this.tsbPapelera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPapelera.Image = global::pryGestorDeTareas.Properties.Resources.delete_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbPapelera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPapelera.Name = "tsbPapelera";
            this.tsbPapelera.Size = new System.Drawing.Size(22, 20);
            this.tsbPapelera.Text = "Papelera";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownButton1.Image = global::pryGestorDeTareas.Properties.Resources.lists_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(150, 40);
            this.toolStripDropDownButton1.Text = "TAREAS";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarToolStripMenuItem.Image = global::pryGestorDeTareas.Properties.Resources.add_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.agregarToolStripMenuItem.Text = "Agregar...";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarToolStripMenuItem.Image = global::pryGestorDeTareas.Properties.Resources.edit_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.modificarToolStripMenuItem.Text = "Modificar...";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.Image = global::pryGestorDeTareas.Properties.Resources.close_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar....";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStripButton3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = global::pryGestorDeTareas.Properties.Resources.category_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(150, 40);
            this.toolStripButton3.Text = "CATEGORÍAS";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStripButton4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = global::pryGestorDeTareas.Properties.Resources.brightness_alert_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(150, 40);
            this.toolStripButton4.Text = "REPORTES";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.AutoSize = false;
            this.toolStripDropDownButton2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownButton2.Image = global::pryGestorDeTareas.Properties.Resources.contacts_product_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(150, 40);
            this.toolStripDropDownButton2.Text = "USUARIOS";
            this.toolStripDropDownButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::pryGestorDeTareas.Properties.Resources.person_search_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Ver...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsbCerrarSesion
            // 
            this.tsbCerrarSesion.AutoSize = false;
            this.tsbCerrarSesion.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tsbCerrarSesion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrarSesion.Image = global::pryGestorDeTareas.Properties.Resources.logout_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarSesion.Name = "tsbCerrarSesion";
            this.tsbCerrarSesion.Size = new System.Drawing.Size(150, 40);
            this.tsbCerrarSesion.Text = "CERRAR SESIÓN";
            this.tsbCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbCerrarSesion.Click += new System.EventHandler(this.tsbCerrarSesion_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 458);
            this.Controls.Add(this.pbLogoPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentanaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHacer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaciendo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHecha)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.RadioButton optVencimiento;
        private System.Windows.Forms.RadioButton optPrioridad;
        private System.Windows.Forms.RadioButton optCategoria;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.RadioButton optTodas;
        private System.Windows.Forms.RadioButton optMisTareas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvHacer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvHaciendo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvHecha;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslLeyenda;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbCerrarSesion;
        private System.Windows.Forms.ToolStripButton tsbConfirmar;
        private System.Windows.Forms.ToolStripButton tsbPapelera;
        private System.Windows.Forms.ToolStripLabel tslUsuario;
        private System.Windows.Forms.ToolStripLabel tslBienvenido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}