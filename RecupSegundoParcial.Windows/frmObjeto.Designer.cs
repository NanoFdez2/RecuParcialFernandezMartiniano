namespace RecupSegundoParcial.Windows
{
    partial class frmObjeto
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboBordes = new ComboBox();
            cboRelleno = new ComboBox();
            textBox1 = new TextBox();
            btnOk = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la medida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 101);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Relleno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 194);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo de borde";
            // 
            // cboBordes
            // 
            cboBordes.FormattingEnabled = true;
            cboBordes.Location = new Point(124, 191);
            cboBordes.Name = "cboBordes";
            cboBordes.Size = new Size(121, 23);
            cboBordes.TabIndex = 3;
            // 
            // cboRelleno
            // 
            cboRelleno.FormattingEnabled = true;
            cboRelleno.Location = new Point(124, 93);
            cboRelleno.Name = "cboRelleno";
            cboRelleno.Size = new Size(121, 23);
            cboRelleno.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(31, 250);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 56);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(159, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 56);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmObjeto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 328);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(textBox1);
            Controls.Add(cboRelleno);
            Controls.Add(cboBordes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmObjeto";
            Text = "frmObjeto";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboBordes;
        private ComboBox cboRelleno;
        private TextBox textBox1;
        private Button btnOk;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}