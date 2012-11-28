namespace MisPeliculas
{
    partial class frmPelicula
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nupYear = new System.Windows.Forms.NumericUpDown();
            this.nupValor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkVista = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(116, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Guardar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(197, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nupYear
            // 
            this.nupYear.Location = new System.Drawing.Point(74, 71);
            this.nupYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nupYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nupYear.Name = "nupYear";
            this.nupYear.Size = new System.Drawing.Size(53, 20);
            this.nupYear.TabIndex = 3;
            this.nupYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nupValor
            // 
            this.nupValor.Location = new System.Drawing.Point(87, 123);
            this.nupValor.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupValor.Name = "nupValor";
            this.nupValor.Size = new System.Drawing.Size(34, 20);
            this.nupValor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Valoración";
            // 
            // txtGenero
            // 
            this.txtGenero.BackColor = System.Drawing.Color.White;
            this.txtGenero.ForeColor = System.Drawing.Color.Black;
            this.txtGenero.Location = new System.Drawing.Point(74, 97);
            this.txtGenero.MaxLength = 100;
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(172, 20);
            this.txtGenero.TabIndex = 4;
            // 
            // txtDirector
            // 
            this.txtDirector.BackColor = System.Drawing.Color.White;
            this.txtDirector.ForeColor = System.Drawing.Color.Black;
            this.txtDirector.Location = new System.Drawing.Point(74, 45);
            this.txtDirector.MaxLength = 100;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(172, 20);
            this.txtDirector.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(74, 19);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // chkVista
            // 
            this.chkVista.AutoSize = true;
            this.chkVista.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVista.Location = new System.Drawing.Point(27, 149);
            this.chkVista.Name = "chkVista";
            this.chkVista.Size = new System.Drawing.Size(49, 17);
            this.chkVista.TabIndex = 6;
            this.chkVista.Text = "Vista";
            this.chkVista.UseVisualStyleBackColor = true;
            // 
            // frmPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.ControlBox = false;
            this.Controls.Add(this.chkVista);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupValor);
            this.Controls.Add(this.nupYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPelicula";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.nupYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nupYear;
        private System.Windows.Forms.NumericUpDown nupValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkVista;
    }
}