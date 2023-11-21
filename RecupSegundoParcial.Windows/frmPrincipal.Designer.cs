namespace RecupSegundoParcial.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbEditar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            ascendenteToolStripMenuItem = new ToolStripMenuItem();
            descendenteToolStripMenuItem = new ToolStripMenuItem();
            tsbSalir = new ToolStripButton();
            panel1 = new Panel();
            dgvDatos = new DataGridView();
            colUno = new DataGridViewTextBoxColumn();
            colDos = new DataGridViewTextBoxColumn();
            colTres = new DataGridViewTextBoxColumn();
            colCuatro = new DataGridViewTextBoxColumn();
            colCinco = new DataGridViewTextBoxColumn();
            colSeis = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            txtCantidad = new TextBox();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, toolStripSeparator1, tsbEditar, tsbFiltrar, tsbActualizar, toolStripSeparator2, tsbOrdenar, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 35);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 35);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 35);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(41, 35);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 35);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { ascendenteToolStripMenuItem, descendenteToolStripMenuItem });
            tsbOrdenar.Image = (Image)resources.GetObject("tsbOrdenar.Image");
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 35);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbOrdenar.Click += tsbOrdenar_Click;
            // 
            // ascendenteToolStripMenuItem
            // 
            ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            ascendenteToolStripMenuItem.Size = new Size(142, 22);
            ascendenteToolStripMenuItem.Text = "Ascendente";
            ascendenteToolStripMenuItem.Click += ascendenteToolStripMenuItem_Click;
            // 
            // descendenteToolStripMenuItem
            // 
            descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            descendenteToolStripMenuItem.Size = new Size(142, 22);
            descendenteToolStripMenuItem.Text = "Descendente";
            descendenteToolStripMenuItem.Click += descendenteToolStripMenuItem_Click;
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(33, 35);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvDatos);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 412);
            panel1.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colUno, colDos, colTres, colCuatro, colCinco, colSeis });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 312);
            dgvDatos.TabIndex = 1;
            // 
            // colUno
            // 
            colUno.HeaderText = "Medida de lado";
            colUno.Name = "colUno";
            colUno.ReadOnly = true;
            // 
            // colDos
            // 
            colDos.HeaderText = "Color";
            colDos.Name = "colDos";
            colDos.ReadOnly = true;
            // 
            // colTres
            // 
            colTres.HeaderText = "Borde";
            colTres.Name = "colTres";
            colTres.ReadOnly = true;
            // 
            // colCuatro
            // 
            colCuatro.HeaderText = "Área";
            colCuatro.Name = "colCuatro";
            colCuatro.ReadOnly = true;
            // 
            // colCinco
            // 
            colCinco.HeaderText = "Perímetro";
            colCinco.Name = "colCinco";
            colCinco.ReadOnly = true;
            // 
            // colSeis
            // 
            colSeis.HeaderText = "Apotema";
            colSeis.Name = "colSeis";
            colSeis.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtCantidad);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 312);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(137, 17);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de registros";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "frmPrincipal";
            Text = "Form1";
            Load += frmPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel panel1;
        private DataGridView dgvDatos;
        private Panel panel2;
        private TextBox txtCantidad;
        private Label label1;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem ascendenteToolStripMenuItem;
        private ToolStripMenuItem descendenteToolStripMenuItem;
        private DataGridViewTextBoxColumn colUno;
        private DataGridViewTextBoxColumn colDos;
        private DataGridViewTextBoxColumn colTres;
        private DataGridViewTextBoxColumn colCuatro;
        private DataGridViewTextBoxColumn colCinco;
        private DataGridViewTextBoxColumn colSeis;
    }
}