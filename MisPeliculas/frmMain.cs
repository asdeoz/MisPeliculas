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
    public partial class frmMain : Form
    {
        private const int cNombre = 0;
        private const int cDirector = 1;
        private const int cYear = 2;
        private const int cGenero = 3;
        private const int cValor = 4;
        private const int cVista = 5;

        private DALcontext db;

        public frmMain()
        {
            InitializeComponent();

            db = new DALcontext();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CargaGrid();

            this.nupYearDesdeFiltro.Value = DateTime.Now.Year;
            this.nupYearHastaFiltro.Value = DateTime.Now.Year;
        }

        private void IniGrid()
        {
            fgPelis.Cols.Count = 6;
            fgPelis.Cols.Fixed = 0;
            fgPelis.Rows.Count = 1;
            fgPelis.Rows.Fixed = 1;
            fgPelis.AllowEditing = false;
            fgPelis.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            fgPelis.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None;
            fgPelis.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None;
            fgPelis.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;

            fgPelis.Cols[cNombre][0] = "Nombre";
            fgPelis.Cols[cDirector][0] = "Director";
            fgPelis.Cols[cYear][0] = "Año";
            fgPelis.Cols[cGenero][0] = "Género";
            fgPelis.Cols[cValor][0] = "Valoración";
            fgPelis.Cols[cVista][0] = "Vista";

            fgPelis.Cols[cNombre].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            fgPelis.Cols[cDirector].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            fgPelis.Cols[cYear].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
            fgPelis.Cols[cGenero].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            fgPelis.Cols[cValor].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
            fgPelis.Cols[cVista].DataType = typeof(bool);

            fgPelis.ExtendLastCol = true;
            fgPelis.AutoSizeCols();
        }

        private void CargaGrid()
        {
            this.IniGrid();

            var query = from p in db.Peliculas
                        orderby p.Nombre
                        select p;

            foreach (Pelicula p in query)
            {
                this.InsertaFila(p);
            }

            fgPelis.AutoSizeCols();
            this.BorrarFiltro();
        }

        private void CargaGridFiltro()
        {
            this.IniGrid();

            var query = db.Peliculas.AsQueryable();

            if (!string.IsNullOrEmpty(this.txtNombreFiltro.Text.Trim()))
            {
                query = query.Where(p => p.Nombre.ToUpper().Contains(this.txtNombreFiltro.Text.Trim().ToUpper()));
            }

            if (!string.IsNullOrEmpty(this.txtDirectorFiltro.Text.Trim()))
            {
                query = query.Where(p => p.Director.ToUpper().Contains(this.txtDirectorFiltro.Text.Trim().ToUpper()));
            }

            if (!string.IsNullOrEmpty(this.txtGeneroFiltro.Text.Trim()))
            {
                query = query.Where(p => p.Genero.ToUpper().Contains(this.txtGeneroFiltro.Text.Trim().ToUpper()));
            }

            if (this.chkVistaFiltro.CheckState != CheckState.Indeterminate)
            {
                query = query.Where(p => p.Vista == this.chkVistaFiltro.Checked);
            }

            if (this.chkDesde.Checked)
            {
                query = query.Where(p => p.Year >= this.nupYearDesdeFiltro.Value);
            }

            if (this.chkHasta.Checked)
            {
                query = query.Where(p => p.Year <= this.nupYearHastaFiltro.Value);
            }

            if (this.nupValorFiltro.Value > 0)
            {
                query = query.Where(p => p.Valor >= this.nupValorFiltro.Value);
            }

            query = query.OrderBy(p => p.Nombre);

            foreach (Pelicula p in query)
            {
                this.InsertaFila(p);
            }

            fgPelis.AutoSizeCols();

        }

        private void InsertaFila(Pelicula p)
        {
            C1.Win.C1FlexGrid.Row r = this.fgPelis.Rows.Add();

            r[cNombre] = p.Nombre;
            r[cDirector] = p.Director;
            r[cYear] = p.Year;
            r[cGenero] = p.Genero;
            r[cValor] = p.Valor;
            r[cVista] = p.Vista;

            r.UserData = p;
        }

        private void RellenaDetalles(Pelicula p)
        {
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            pb5.Visible = false;

            this.txtNombre.Text = p.Nombre;
            this.txtDirector.Text = p.Director;
            this.txtGenero.Text = p.Genero;
            this.txtYear.Text = p.Year.ToString();
            this.chkVista.Checked = p.Vista;

            if (p.Valor > 0)
            {
                pb1.Visible = true;
                if (p.Valor > 1)
                {
                    pb2.Visible = true;
                    if (p.Valor > 2)
                    {
                        pb3.Visible = true;
                        if (p.Valor > 3)
                        {
                            pb4.Visible = true;
                            if (p.Valor > 4)
                            {
                                pb5.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void BorrarFiltro()
        {
            this.txtNombreFiltro.Text = "";
            this.txtDirectorFiltro.Text = "";
            this.txtGeneroFiltro.Text = "";
            this.nupValorFiltro.Value = 0;
            this.nupYearDesdeFiltro.Value = DateTime.Now.Year;
            this.nupYearHastaFiltro.Value = DateTime.Now.Year;
            this.chkDesde.Checked = false;
            this.chkHasta.Checked = false;
            this.chkVistaFiltro.CheckState = CheckState.Indeterminate;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            frmPelicula form = new frmPelicula();
            form.Text = "Nueva";

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Pelicula p = form.PeliculaActual;

                db.Peliculas.Add(p);
                db.SaveChanges();

                this.CargaGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            C1.Win.C1FlexGrid.Row r = fgPelis.Rows[fgPelis.RowSel];

            if (r.UserData is Pelicula)
            {
                Pelicula p = (Pelicula)r.UserData;

                frmPelicula form = new frmPelicula(p);
                form.Text = "Editar";

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.SaveChanges();

                    this.CargaGrid();
                }
            }
            else
            {
                MessageBox.Show("Primero selecciona la película que quieres editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            C1.Win.C1FlexGrid.Row r = fgPelis.Rows[fgPelis.RowSel];

            if (r.UserData is Pelicula)
            {
                Pelicula p = (Pelicula)r.UserData;

                if (MessageBox.Show("¿Estás seguro que quieres eliminar la película '" + p.ToString() + "'?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    db.Peliculas.Remove(p);
                    db.SaveChanges();
                    this.CargaGrid();
                }
            }
        }

        private void fgPelis_Click(object sender, EventArgs e)
        {
            if (fgPelis.RowSel > fgPelis.Rows.Fixed)
            {
                C1.Win.C1FlexGrid.Row r = fgPelis.Rows[fgPelis.RowSel];

                if (r.UserData is Pelicula)
                {
                    Pelicula p = (Pelicula)r.UserData;

                    this.RellenaDetalles(p);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            fgPelis.PrintGrid("Lista Películas", C1.Win.C1FlexGrid.PrintGridFlags.ShowPreviewDialog);
        }

        private void chkDesde_CheckedChanged(object sender, EventArgs e)
        {
            this.nupYearDesdeFiltro.Enabled = this.chkDesde.Checked;
        }

        private void chkHasta_CheckedChanged(object sender, EventArgs e)
        {
            this.nupYearHastaFiltro.Enabled = this.chkHasta.Checked;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.CargaGrid();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.CargaGridFiltro();
        }

    }
}
