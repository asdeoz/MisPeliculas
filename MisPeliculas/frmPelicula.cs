using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MisPeliculas
{
    public partial class frmPelicula : Form
    {
        public Pelicula PeliculaActual { get; set; }

        public frmPelicula()
        {
            InitializeComponent();

            this.PeliculaActual = new Pelicula();

            if (DateTime.Now.Year < nupYear.Maximum && DateTime.Now.Year > nupYear.Minimum)
            {
                nupYear.Value = DateTime.Now.Year;
            }
        }

        public frmPelicula(Pelicula p)
            : this()
        {
            this.txtNombre.Text = p.Nombre;
            this.txtDirector.Text = p.Director;
            this.txtGenero.Text = p.Genero;
            this.nupYear.Value = p.Year;
            this.nupValor.Value = p.Valor;
            this.chkVista.Checked = p.Vista;

            this.PeliculaActual = p;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si cancelas perderás los cambios. ¿Estás seguro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                this.PeliculaActual = null;
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                this.PeliculaActual.Nombre = this.txtNombre.Text;
                this.PeliculaActual.Director = this.txtDirector.Text;
                this.PeliculaActual.Genero = this.txtGenero.Text;
                this.PeliculaActual.Year = (int)this.nupYear.Value;
                this.PeliculaActual.Valor = (int)this.nupValor.Value;
                this.PeliculaActual.Vista = this.chkVista.Checked;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private bool ComprobarCampos()
        {
            if (this.txtNombre.Text == "")
            {
                return false;
            }

            return true;
        }
    }
}
