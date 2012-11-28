namespace MisPeliculas
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.chkVista = new System.Windows.Forms.CheckBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
            this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.fgPelis = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.chkVistaFiltro = new System.Windows.Forms.CheckBox();
            this.txtGeneroFiltro = new System.Windows.Forms.TextBox();
            this.txtDirectorFiltro = new System.Windows.Forms.TextBox();
            this.txtNombreFiltro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nupValorFiltro = new System.Windows.Forms.NumericUpDown();
            this.nupYearDesdeFiltro = new System.Windows.Forms.NumericUpDown();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.nupYearHastaFiltro = new System.Windows.Forms.NumericUpDown();
            this.chkDesde = new System.Windows.Forms.CheckBox();
            this.chkHasta = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
            this.c1CommandDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgPelis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYearDesdeFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYearHastaFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.chkVista);
            this.groupBox1.Controls.Add(this.pb5);
            this.groupBox1.Controls.Add(this.pb4);
            this.groupBox1.Controls.Add(this.pb3);
            this.groupBox1.Controls.Add(this.pb2);
            this.groupBox1.Controls.Add(this.pb1);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtDirector);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnNueva);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(342, 182);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // chkVista
            // 
            this.chkVista.AutoSize = true;
            this.chkVista.BackColor = System.Drawing.Color.Transparent;
            this.chkVista.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVista.Enabled = false;
            this.chkVista.ForeColor = System.Drawing.Color.Black;
            this.chkVista.Location = new System.Drawing.Point(409, 39);
            this.chkVista.Name = "chkVista";
            this.chkVista.Size = new System.Drawing.Size(49, 17);
            this.chkVista.TabIndex = 18;
            this.chkVista.Text = "Vista";
            this.chkVista.UseVisualStyleBackColor = false;
            // 
            // pb5
            // 
            this.pb5.Image = global::MisPeliculas.Properties.Resources.star;
            this.pb5.InitialImage = global::MisPeliculas.Properties.Resources.star;
            this.pb5.Location = new System.Drawing.Point(171, 145);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(18, 20);
            this.pb5.TabIndex = 17;
            this.pb5.TabStop = false;
            this.pb5.Visible = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::MisPeliculas.Properties.Resources.star;
            this.pb4.InitialImage = global::MisPeliculas.Properties.Resources.star;
            this.pb4.Location = new System.Drawing.Point(152, 145);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(18, 20);
            this.pb4.TabIndex = 16;
            this.pb4.TabStop = false;
            this.pb4.Visible = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::MisPeliculas.Properties.Resources.star;
            this.pb3.InitialImage = global::MisPeliculas.Properties.Resources.star;
            this.pb3.Location = new System.Drawing.Point(133, 145);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(18, 20);
            this.pb3.TabIndex = 15;
            this.pb3.TabStop = false;
            this.pb3.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::MisPeliculas.Properties.Resources.star;
            this.pb2.InitialImage = global::MisPeliculas.Properties.Resources.star;
            this.pb2.Location = new System.Drawing.Point(114, 145);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(18, 20);
            this.pb2.TabIndex = 14;
            this.pb2.TabStop = false;
            this.pb2.Visible = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::MisPeliculas.Properties.Resources.star;
            this.pb1.InitialImage = global::MisPeliculas.Properties.Resources.star;
            this.pb1.Location = new System.Drawing.Point(95, 145);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(18, 20);
            this.pb1.TabIndex = 13;
            this.pb1.TabStop = false;
            this.pb1.Visible = false;
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.White;
            this.txtGenero.Enabled = false;
            this.txtGenero.ForeColor = System.Drawing.Color.Black;
            this.txtGenero.Location = new System.Drawing.Point(95, 119);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(171, 20);
            this.txtGenero.TabIndex = 12;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Enabled = false;
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.Location = new System.Drawing.Point(95, 91);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(60, 20);
            this.txtYear.TabIndex = 11;
            // 
            // txtDirector
            // 
            this.txtDirector.BackColor = System.Drawing.Color.White;
            this.txtDirector.Enabled = false;
            this.txtDirector.ForeColor = System.Drawing.Color.Black;
            this.txtDirector.Location = new System.Drawing.Point(95, 64);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(266, 20);
            this.txtDirector.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Enabled = false;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(95, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valoración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Director";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(504, 182);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNueva.Location = new System.Drawing.Point(423, 182);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 23);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(585, 182);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // c1CommandDock1
            // 
            this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
            this.c1CommandDock1.Id = 1;
            this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
            this.c1CommandDock1.Name = "c1CommandDock1";
            this.c1CommandDock1.Size = new System.Drawing.Size(672, 147);
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.c1DockingTab1.AutoHiding = true;
            this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1DockingTab1.CanAutoHide = true;
            this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.ShowCaption = true;
            this.c1DockingTab1.Size = new System.Drawing.Size(672, 147);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
            this.c1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.CaptionVisible = true;
            this.c1DockingTabPage1.Controls.Add(this.btnBorrar);
            this.c1DockingTabPage1.Controls.Add(this.label11);
            this.c1DockingTabPage1.Controls.Add(this.chkHasta);
            this.c1DockingTabPage1.Controls.Add(this.chkDesde);
            this.c1DockingTabPage1.Controls.Add(this.nupYearHastaFiltro);
            this.c1DockingTabPage1.Controls.Add(this.btnFiltrar);
            this.c1DockingTabPage1.Controls.Add(this.chkVistaFiltro);
            this.c1DockingTabPage1.Controls.Add(this.txtGeneroFiltro);
            this.c1DockingTabPage1.Controls.Add(this.txtDirectorFiltro);
            this.c1DockingTabPage1.Controls.Add(this.txtNombreFiltro);
            this.c1DockingTabPage1.Controls.Add(this.label6);
            this.c1DockingTabPage1.Controls.Add(this.label7);
            this.c1DockingTabPage1.Controls.Add(this.label8);
            this.c1DockingTabPage1.Controls.Add(this.label9);
            this.c1DockingTabPage1.Controls.Add(this.label10);
            this.c1DockingTabPage1.Controls.Add(this.nupValorFiltro);
            this.c1DockingTabPage1.Controls.Add(this.nupYearDesdeFiltro);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(672, 120);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "Filtros";
            // 
            // fgPelis
            // 
            this.fgPelis.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgPelis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgPelis.Location = new System.Drawing.Point(0, 147);
            this.fgPelis.Name = "fgPelis";
            this.fgPelis.Rows.DefaultSize = 19;
            this.fgPelis.Size = new System.Drawing.Size(672, 254);
            this.fgPelis.TabIndex = 4;
            this.fgPelis.Click += new System.EventHandler(this.fgPelis_Click);
            // 
            // chkVistaFiltro
            // 
            this.chkVistaFiltro.AutoSize = true;
            this.chkVistaFiltro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVistaFiltro.Checked = true;
            this.chkVistaFiltro.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkVistaFiltro.Location = new System.Drawing.Point(17, 77);
            this.chkVistaFiltro.Name = "chkVistaFiltro";
            this.chkVistaFiltro.Size = new System.Drawing.Size(49, 17);
            this.chkVistaFiltro.TabIndex = 105;
            this.chkVistaFiltro.Text = "Vista";
            this.chkVistaFiltro.UseVisualStyleBackColor = true;
            // 
            // txtGeneroFiltro
            // 
            this.txtGeneroFiltro.BackColor = System.Drawing.Color.White;
            this.txtGeneroFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtGeneroFiltro.Location = new System.Drawing.Point(324, 50);
            this.txtGeneroFiltro.MaxLength = 100;
            this.txtGeneroFiltro.Name = "txtGeneroFiltro";
            this.txtGeneroFiltro.Size = new System.Drawing.Size(172, 20);
            this.txtGeneroFiltro.TabIndex = 103;
            // 
            // txtDirectorFiltro
            // 
            this.txtDirectorFiltro.BackColor = System.Drawing.Color.White;
            this.txtDirectorFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtDirectorFiltro.Location = new System.Drawing.Point(64, 49);
            this.txtDirectorFiltro.MaxLength = 100;
            this.txtDirectorFiltro.Name = "txtDirectorFiltro";
            this.txtDirectorFiltro.Size = new System.Drawing.Size(172, 20);
            this.txtDirectorFiltro.TabIndex = 101;
            // 
            // txtNombreFiltro
            // 
            this.txtNombreFiltro.BackColor = System.Drawing.Color.White;
            this.txtNombreFiltro.ForeColor = System.Drawing.Color.Black;
            this.txtNombreFiltro.Location = new System.Drawing.Point(64, 23);
            this.txtNombreFiltro.MaxLength = 100;
            this.txtNombreFiltro.Name = "txtNombreFiltro";
            this.txtNombreFiltro.Size = new System.Drawing.Size(172, 20);
            this.txtNombreFiltro.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Valoración";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Género";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Año";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Director";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Nombre";
            // 
            // nupValorFiltro
            // 
            this.nupValorFiltro.Location = new System.Drawing.Point(337, 76);
            this.nupValorFiltro.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupValorFiltro.Name = "nupValorFiltro";
            this.nupValorFiltro.Size = new System.Drawing.Size(34, 20);
            this.nupValorFiltro.TabIndex = 104;
            // 
            // nupYearDesdeFiltro
            // 
            this.nupYearDesdeFiltro.Enabled = false;
            this.nupYearDesdeFiltro.Location = new System.Drawing.Point(345, 24);
            this.nupYearDesdeFiltro.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nupYearDesdeFiltro.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nupYearDesdeFiltro.Name = "nupYearDesdeFiltro";
            this.nupYearDesdeFiltro.Size = new System.Drawing.Size(53, 20);
            this.nupYearDesdeFiltro.TabIndex = 102;
            this.nupYearDesdeFiltro.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(585, 73);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 111;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // nupYearHastaFiltro
            // 
            this.nupYearHastaFiltro.Enabled = false;
            this.nupYearHastaFiltro.Location = new System.Drawing.Point(464, 24);
            this.nupYearHastaFiltro.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nupYearHastaFiltro.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nupYearHastaFiltro.Name = "nupYearHastaFiltro";
            this.nupYearHastaFiltro.Size = new System.Drawing.Size(53, 20);
            this.nupYearHastaFiltro.TabIndex = 112;
            this.nupYearHastaFiltro.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // chkDesde
            // 
            this.chkDesde.AutoSize = true;
            this.chkDesde.Location = new System.Drawing.Point(324, 26);
            this.chkDesde.Name = "chkDesde";
            this.chkDesde.Size = new System.Drawing.Size(15, 14);
            this.chkDesde.TabIndex = 113;
            this.chkDesde.UseVisualStyleBackColor = true;
            this.chkDesde.CheckedChanged += new System.EventHandler(this.chkDesde_CheckedChanged);
            // 
            // chkHasta
            // 
            this.chkHasta.AutoSize = true;
            this.chkHasta.Location = new System.Drawing.Point(443, 26);
            this.chkHasta.Name = "chkHasta";
            this.chkHasta.Size = new System.Drawing.Size(15, 14);
            this.chkHasta.TabIndex = 114;
            this.chkHasta.UseVisualStyleBackColor = true;
            this.chkHasta.CheckedChanged += new System.EventHandler(this.chkHasta_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 115;
            this.label11.Text = "hasta";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(585, 44);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 116;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 618);
            this.Controls.Add(this.fgPelis);
            this.Controls.Add(this.c1CommandDock1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mis Peliculas";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
            this.c1CommandDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            this.c1DockingTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgPelis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYearDesdeFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupYearHastaFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.CheckBox chkVista;
        private System.Windows.Forms.Button btnPrint;
        private C1.Win.C1Command.C1CommandDock c1CommandDock1;
        private C1.Win.C1Command.C1DockingTab c1DockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private C1.Win.C1FlexGrid.C1FlexGrid fgPelis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkHasta;
        private System.Windows.Forms.CheckBox chkDesde;
        private System.Windows.Forms.NumericUpDown nupYearHastaFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox chkVistaFiltro;
        private System.Windows.Forms.TextBox txtGeneroFiltro;
        private System.Windows.Forms.TextBox txtDirectorFiltro;
        private System.Windows.Forms.TextBox txtNombreFiltro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nupValorFiltro;
        private System.Windows.Forms.NumericUpDown nupYearDesdeFiltro;
        private System.Windows.Forms.Button btnBorrar;

    }
}

