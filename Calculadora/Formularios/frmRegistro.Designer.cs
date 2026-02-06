namespace Calculadora.Formularios
{
    partial class frmRegistro
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Registrar = new Button();
            label3 = new Label();
            dtpNacimiento = new DateTimePicker();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvPersonas = new DataGridView();
            btnEliminar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(577, 424);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Registrar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dtpNacimiento);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(569, 396);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Registrar
            // 
            Registrar.Location = new Point(341, 165);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(90, 29);
            Registrar.TabIndex = 6;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 227);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha de Nacimiento";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(28, 272);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(221, 23);
            dtpNacimiento.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(28, 165);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(221, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 127);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(569, 396);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvPersonas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEliminar);
            splitContainer1.Size = new Size(563, 390);
            splitContainer1.SplitterDistance = 264;
            splitContainer1.TabIndex = 1;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Dock = DockStyle.Fill;
            dgvPersonas.Location = new Point(0, 0);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(563, 264);
            dgvPersonas.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(29, 38);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 38);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 423);
            Controls.Add(tabControl1);
            Name = "frmRegistro";
            RightToLeftLayout = true;
            Text = "Registro Alumnos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button Registrar;
        private Label label3;
        private DateTimePicker dtpNacimiento;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private SplitContainer splitContainer1;
        private DataGridView dgvPersonas;
        private Button btnEliminar;
    }
}