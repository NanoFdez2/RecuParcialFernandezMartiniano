using ArrayObjeto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecupSegundoParcial.Windows
{
    public partial class frmObjeto : Form
    {
        private Objeto? objeto;

        public frmObjeto()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboColorRelleno();
            CargarDatosComboTipoDeBorde();
            if (objeto != null)
            {
                textBox1.Text = objeto.GetLado().ToString();
                //textBox2.Text = objeto.GetLado2().ToString(); si llegara a necesitar otro atributo a ingresar!
                cboRelleno.SelectedItem = objeto.ColorRelleno;
                cboBordes.SelectedItem = objeto.TipoDeBorde;

            }
        }

        private void CargarDatosComboTipoDeBorde()
        {
            var listaBordes = Enum.GetValues(typeof(TipodeBorde)).Cast<TipodeBorde>().ToList();
            cboBordes.DataSource = listaBordes;
            cboBordes.SelectedIndex = 0;
        }

        private void CargarDatosComboColorRelleno()
        {
            var listaColores = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();
            cboRelleno.DataSource = listaColores;
            cboRelleno.SelectedIndex = 0;
        }

        internal Objeto GetObjeto()
        {
            return objeto;
        }

        public void SetObjeto(Objeto? objeto)
        {
            this.objeto = objeto;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (objeto == null)
                {
                    objeto = new Objeto();
                }
                objeto.SetLado(int.Parse(textBox1.Text));
                objeto.ColorRelleno = (ColorRelleno)cboRelleno.SelectedItem;
                objeto.TipoDeBorde = (TipodeBorde)cboBordes.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(textBox1.Text, out int arista))
            {
                valido = false;
                errorProvider1.SetError(textBox1, "Nro. mal ingresado.");
            }
            else if (arista <= 0)
            {
                valido = false;
                errorProvider1.SetError(textBox1, "El valor no puede ser menor que cero");
            }

            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
