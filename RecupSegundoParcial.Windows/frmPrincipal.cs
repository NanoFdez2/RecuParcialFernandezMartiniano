using ArrayObjeto.Datos;
using ArrayObjeto.Entidades;

namespace RecupSegundoParcial.Windows
{
    public partial class frmPrincipal : Form
    {
        private RepositorioDeObjetos repo;
        private List<Objeto> lista;
        int intValor;
        private Objeto objeto;
        public frmPrincipal()
        {
            InitializeComponent();
            repo = new RepositorioDeObjetos();
            ActualizarCantidadDeRegistros();
        }

        private void ActualizarCantidadDeRegistros()
        {
            if (intValor > 0)
            {
                txtCantidad.Text = repo.GetCantidad(intValor).ToString();
            }
            else
            {
                txtCantidad.Text = repo.GetCantidad().ToString();
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            lista = repo.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
            intValor = 0;
            tsbFiltrar.BackColor = Color.White;
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var objeto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, objeto);
                AgregarFila(r);
            }

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Objeto objeto)
        {
            r.Cells[colUno.Index].Value = objeto.GetLado();
            r.Cells[colDos.Index].Value = objeto.ColorRelleno;
            r.Cells[colTres.Index].Value = objeto.TipoDeBorde;
            r.Cells[colCuatro.Index].Value = objeto.GetArea();
            r.Cells[colCinco.Index].Value = objeto.GetPerimetro();
            r.Cells[colSeis.Index].Value = objeto.GetApotema();
            r.Tag = objeto;

        }
        
        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmObjeto frm = new frmObjeto() { Text = "Agregar objeto." };
            DialogResult dr = frm.ShowDialog();
            if (dr != DialogResult.OK)
            {
                return;
            }
            Objeto objeto = frm.GetObjeto();
            if (!repo.Existe(objeto))
            {
                repo.Agregar(objeto);
                txtCantidad.Text = repo.GetCantidad().ToString();
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, objeto);
                AgregarFila(r);
                MessageBox.Show("Registro agregado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("El registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("¿Desea borrar el objeto?", "Confirmar baja.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Objeto objeto = filaSeleccionada.Tag as Objeto;
            repo.Borrar(objeto);
            txtCantidad.Text = repo.GetCantidad().ToString();
            QuitarFila(filaSeleccionada);
        }

        private void QuitarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Registro borrado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var filaSeleccionada = dgvDatos.SelectedRows[0];
            Objeto objeto = (Objeto)filaSeleccionada.Tag;
            int ladoAnterior = objeto.GetLado();
            frmObjeto frm = new frmObjeto() { Text = "Edite el objeto" };
            frm.SetObjeto(objeto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            objeto = frm.GetObjeto();
            repo.Editar(ladoAnterior, objeto);
            SetearFila(filaSeleccionada, objeto);
            MessageBox.Show("Registro editado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            var stringValor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor a filtrar.",
                "Filtrar por mayor o igual",
                "0", 400, 400);
            if(!int.TryParse(stringValor,out int valor))
            {
                return;
            }
            if (intValor <= 0)
            {
                return;
            }
            lista = repo.Filtrar(intValor);
            tsbFiltrar.BackColor = Color.DarkBlue;
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
            MessageBox.Show("¡Filtro aplicado!");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (repo.GetCantidad() > 0)
            {
                lista = repo.GetLista();
                MostrarDatosEnGrilla();

            }
        }

        private void ascendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarAsc();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void descendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repo.OrdenarDesc();
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void tsbOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}