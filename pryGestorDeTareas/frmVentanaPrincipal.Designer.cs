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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.optTodas = new System.Windows.Forms.RadioButton();
            this.optMisTareas = new System.Windows.Forms.RadioButton();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpHacer = new System.Windows.Forms.TabPage();
            this.dgvHacer = new System.Windows.Forms.DataGridView();
            this.tpHaciendo = new System.Windows.Forms.TabPage();
            this.dgvHaciendo = new System.Windows.Forms.DataGridView();
            this.tpHecha = new System.Windows.Forms.TabPage();
            this.dgvHecha = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConfirmar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbPapelera = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslLeyenda = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBienvenido = new System.Windows.Forms.ToolStripLabel();
            this.tslUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.pbLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tpHacer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHacer)).BeginInit();
            this.tpHaciendo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaciendo)).BeginInit();
            this.tpHecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHecha)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(212, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 315);
            this.panel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(587, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS";
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.optTodas);
            this.gbUsuario.Controls.Add(this.optMisTareas);
            this.gbUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.Location = new System.Drawing.Point(6, 21);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(273, 66);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            // 
            // optTodas
            // 
            this.optTodas.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.optTodas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optTodas.Location = new System.Drawing.Point(138, 20);
            this.optTodas.Name = "optTodas";
            this.optTodas.Size = new System.Drawing.Size(110, 32);
            this.optTodas.TabIndex = 1;
            this.optTodas.Text = "Todas las Tareas";
            this.optTodas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optTodas.UseVisualStyleBackColor = true;
            this.optTodas.CheckedChanged += new System.EventHandler(this.optTodas_CheckedChanged);
            // 
            // optMisTareas
            // 
            this.optMisTareas.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.optMisTareas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMisTareas.Location = new System.Drawing.Point(6, 20);
            this.optMisTareas.Name = "optMisTareas";
            this.optMisTareas.Size = new System.Drawing.Size(110, 32);
            this.optMisTareas.TabIndex = 0;
            this.optMisTareas.Text = "Mis Tareas";
            this.optMisTareas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optMisTareas.UseVisualStyleBackColor = true;
            this.optMisTareas.CheckedChanged += new System.EventHandler(this.optMisTareas_CheckedChanged);
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tpHacer);
            this.tbControl.Controls.Add(this.tpHaciendo);
            this.tbControl.Controls.Add(this.tpHecha);
            this.tbControl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl.Location = new System.Drawing.Point(239, 107);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(637, 353);
            this.tbControl.TabIndex = 9;
            // 
            // tpHacer
            // 
            this.tpHacer.BackColor = System.Drawing.Color.OldLace;
            this.tpHacer.Controls.Add(this.dgvHacer);
            this.tpHacer.Location = new System.Drawing.Point(4, 24);
            this.tpHacer.Name = "tpHacer";
            this.tpHacer.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpHacer.Size = new System.Drawing.Size(629, 325);
            this.tpHacer.TabIndex = 0;
            this.tpHacer.Text = "PARA HACER";
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
            this.dgvHacer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHacer_CellClick);
            // 
            // tpHaciendo
            // 
            this.tpHaciendo.BackColor = System.Drawing.Color.OldLace;
            this.tpHaciendo.Controls.Add(this.dgvHaciendo);
            this.tpHaciendo.Location = new System.Drawing.Point(4, 24);
            this.tpHaciendo.Name = "tpHaciendo";
            this.tpHaciendo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpHaciendo.Size = new System.Drawing.Size(629, 325);
            this.tpHaciendo.TabIndex = 1;
            this.tpHaciendo.Text = "HACIENDO";
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
            this.dgvHaciendo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHaciendo_CellClick);
            // 
            // tpHecha
            // 
            this.tpHecha.BackColor = System.Drawing.Color.OldLace;
            this.tpHecha.Controls.Add(this.dgvHecha);
            this.tpHecha.Location = new System.Drawing.Point(4, 24);
            this.tpHecha.Name = "tpHecha";
            this.tpHecha.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpHecha.Size = new System.Drawing.Size(629, 325);
            this.tpHecha.TabIndex = 2;
            this.tpHecha.Text = "HECHAS";
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
            this.dgvHecha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHecha_CellClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.toolStripSeparator2,
            this.tsbConfirmar,
            this.tsbModificar,
            this.tsbPapelera,
            this.toolStripSeparator7,
            this.tsbRefrescar,
            this.toolStripSeparator8});
            this.toolStrip2.Location = new System.Drawing.Point(212, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(24, 458);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = global::pryGestorDeTareas.Properties.Resources.person_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(22, 20);
            this.tsbAgregar.Text = "Agregar Usuario";
            this.tsbAgregar.ToolTipText = "Usuarios";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(22, 6);
            // 
            // tsbConfirmar
            // 
            this.tsbConfirmar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConfirmar.Image = global::pryGestorDeTareas.Properties.Resources.check_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfirmar.Name = "tsbConfirmar";
            this.tsbConfirmar.Size = new System.Drawing.Size(22, 20);
            this.tsbConfirmar.Text = "Completar Tarea";
            this.tsbConfirmar.Click += new System.EventHandler(this.tsbConfirmar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = global::pryGestorDeTareas.Properties.Resources.edit_document_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(22, 20);
            this.tsbModificar.Text = "Modificar Tarea";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbPapelera
            // 
            this.tsbPapelera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPapelera.Image = global::pryGestorDeTareas.Properties.Resources.delete_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbPapelera.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPapelera.Name = "tsbPapelera";
            this.tsbPapelera.Size = new System.Drawing.Size(22, 20);
            this.tsbPapelera.Text = "Papelera";
            this.tsbPapelera.Click += new System.EventHandler(this.tsbPapelera_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(22, 6);
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefrescar.Image = global::pryGestorDeTareas.Properties.Resources.refresh_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(22, 20);
            this.tsbRefrescar.Text = "Eliminar Usuario";
            this.tsbRefrescar.ToolTipText = "Refrescar Grillas";
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(22, 6);
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
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem});
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
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar....";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::pryGestorDeTareas.Properties.Resources.search_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.buscarToolStripMenuItem.Text = "Buscar...";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
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
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
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
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.toolStripMenuItem1.Text = "Ver...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.BackColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.OldLace;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(210, 6);
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
            // pbLogoPrincipal
            // 
            this.pbLogoPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.pbLogoPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogoPrincipal.Image = global::pryGestorDeTareas.Properties.Resources.home_app_logo_24dp_5F6368_FILL0_wght400_GRAD0_opsz24;
            this.pbLogoPrincipal.Location = new System.Drawing.Point(310, 5);
            this.pbLogoPrincipal.Name = "pbLogoPrincipal";
            this.pbLogoPrincipal.Size = new System.Drawing.Size(100, 96);
            this.pbLogoPrincipal.TabIndex = 12;
            this.pbLogoPrincipal.TabStop = false;
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 458);
            this.Controls.Add(this.pbLogoPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentanaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmVentanaPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbUsuario.ResumeLayout(false);
            this.tbControl.ResumeLayout(false);
            this.tpHacer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHacer)).EndInit();
            this.tpHaciendo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaciendo)).EndInit();
            this.tpHecha.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.RadioButton optTodas;
        private System.Windows.Forms.RadioButton optMisTareas;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tpHacer;
        private System.Windows.Forms.DataGridView dgvHacer;
        private System.Windows.Forms.TabPage tpHaciendo;
        private System.Windows.Forms.DataGridView dgvHaciendo;
        private System.Windows.Forms.TabPage tpHecha;
        private System.Windows.Forms.DataGridView dgvHecha;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
    }
}