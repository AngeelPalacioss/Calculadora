namespace Calculadora.Formularios
{
    partial class frmContador
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
            lblContador = new Label();
            btnIniciar = new Button();
            btnDetener = new Button();
            tcbVelocidad = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tcbVelocidad).BeginInit();
            SuspendLayout();
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(230, 75);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(39, 42);
            lblContador.TabIndex = 0;
            lblContador.Text = "0";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(129, 206);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(295, 206);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(75, 23);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // tcbVelocidad
            // 
            tcbVelocidad.Enabled = false;
            tcbVelocidad.Location = new Point(100, 132);
            tcbVelocidad.Maximum = 5;
            tcbVelocidad.Minimum = 1;
            tcbVelocidad.Name = "tcbVelocidad";
            tcbVelocidad.Size = new Size(303, 45);
            tcbVelocidad.TabIndex = 3;
            tcbVelocidad.Value = 1;
            tcbVelocidad.Scroll += tcbVelocidad_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // frmContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 300);
            Controls.Add(tcbVelocidad);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(lblContador);
            Name = "frmContador";
            Text = "Contador";
            ((System.ComponentModel.ISupportInitialize)tcbVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContador;
        private Button btnIniciar;
        private Button btnDetener;
        private TrackBar tcbVelocidad;
        private System.Windows.Forms.Timer tmrContador;
    }
}